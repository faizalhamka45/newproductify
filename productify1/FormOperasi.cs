using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace productify1
{
    public partial class FormOperasi : Form
    {
        // ATRIBUT DAN PROPERTI
        static string[] Scopes = { CalendarService.Scope.CalendarEvents };
        static string ApplicationName = "Asisten Belajar";
        Agendum agendum;
        DataGridViewRow row;
        TextBox tbPukul;
        int Id { get; set; }
        internal enum Mode { Insert, Edit }
        Mode mode;

        // KONSTRUKTOR
        public FormOperasi()
        {
            InitializeComponent();
        }

        public FormOperasi(int id)
        {
            InitializeComponent();
            Id = id;
            mode = Mode.Insert;
        }

        public FormOperasi(DataGridViewRow row)
        {
            InitializeComponent();
            ChangeMtbToTb();
            Text = "Edit Agenda";
            btnTambah.Text = "Edit";
            this.row = row;
            Id = (int) row.Cells[0].Value;
            mode = Mode.Edit;
        }

        // EVENTS
        private void FormTambah_Load(object sender, EventArgs e)
        {
            if (mode == Mode.Insert)
                cbJenis.SelectedIndex = 0;
            else
            {
                cbJenis.Text = row.Cells[1].Value as string;
                if (cbJenis.Text == "PR" || cbJenis.Text == "Ulangan" || cbJenis.Text == "Organisasi")
                    tbTempat.Enabled = false;
                tbNama.Text = row.Cells[2].Value as string;
                dtpTanggal.Value = (DateTime) row.Cells[3].Value;
                try { tbPukul.Text = Convert.ToString((TimeSpan)row.Cells[4].Value).Remove(5); } catch { }
                if (row.Cells[5].Value != null)
                    tbTempat.Text = row.Cells[5].Value as string;
                if (row.Cells[6].Value != null)
                    tbDeskripsi.Text = row.Cells[6].Value as string;
                DisposeCheckBox();
            }
        }

        private void cbJenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbJenis.SelectedIndex;
            if (index == 0 || index == 1)
            {
                tbTempat.Text = "";
                tbTempat.Enabled = false;
            }
            else
            {
                tbTempat.Enabled = true;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (tbNama.Text == "")
                MessageBox.Show("Harap isi nama agenda!");
            else if (dtpTanggal.Value < DateTime.Today)
                MessageBox.Show("itu mah udah kemaren");
            else if (mode == Mode.Insert)
            {
                if (TambahData())
                {
                    if (checkBox.Checked)
                        InsertToGCalendar();
                    Close();
                }
            }
            else
                EditData();
        }

        // METHODS
        private bool TambahData()
        {
            using (AgendaModel am = new AgendaModel())
            {
                agendum = new Agendum
                {
                    Id = this.Id,
                    Jenis = cbJenis.Text,
                    Nama = tbNama.Text,
                    Tanggal = dtpTanggal.Value,
                    Deskripsi = tbDeskripsi.Text
                };
                if (cbJenis.SelectedIndex == 2 || cbJenis.SelectedIndex == 3)
                    agendum.Tempat = tbTempat.Text;
                try
                {
                    agendum.Pukul = new TimeSpan(Convert.ToInt32(mtbPukul.Text.Remove(2)), Convert.ToInt32(mtbPukul.Text.Remove(0, 3)), 0);
                }
                catch
                {
                    if (MessageBox.Show("Anda yakin tidak memasukkan pukul?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.No)
                        return false;
                }
                try
                {
                    am.Agenda.Add(agendum);
                    am.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Gagal Bosqu, Monggo diulangi", "Pemberitahuan");
                    return false;
                }
            }
            MessageBox.Show("Agenda berhasil ditambahkan!", "Pemberitahuan");
            return true;
        }

        private void EditData()
        {
            string s = tbPukul.Text;
            if (s == "" && MessageBox.Show("Anda yakin tidak memasukkan pukul?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            TimeSpan timeSpan;
            try { timeSpan = new TimeSpan(Convert.ToInt32(s.Remove(2)), Convert.ToInt32(s.Remove(0,3)), 0);  }
            catch
            {
                MessageBox.Show("Mohon ketikkan pukul dalam format 00:00", "Error Pada Pukul");
                return;
            }
            using (var am = new AgendaModel())
            {
                var result = am.Agenda.SingleOrDefault(a => a.Id == Id);
                result.Jenis = cbJenis.Text;
                result.Nama = tbNama.Text;
                result.Tanggal = dtpTanggal.Value;
                result.Pukul = timeSpan;
                result.Tempat = tbTempat.Text;
                result.Deskripsi = tbDeskripsi.Text;
                try { am.SaveChanges(); }
                catch
                {
                    MessageBox.Show("Gagal Bosqu, Monggo diulangi", "Pemberitahuan");
                    return;
                }
            }
            MessageBox.Show("Agenda berhasil diedit!", "Pemberitahuan");
            Close();
        }

        private void ChangeMtbToTb()
        {
            tbPukul = new TextBox();
            tbPukul.Location = mtbPukul.Location;
            tbPukul.Size = mtbPukul.Size;
            Controls.Remove(mtbPukul);
            Controls.Add(tbPukul);
            mtbPukul.Dispose();
        }

        private void DisposeCheckBox()
        {
            Controls.Remove(checkBox);
            checkBox.Dispose();
        }

        private void InsertToGCalendar()
        {
            UserCredential credential;

            using (FileStream stream =
                new FileStream("client_id.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                try
                {
                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;
                }
                catch { return; }
            }

            // Create Google Calendar API service.
            CalendarService service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Creating New Event
            bool IsAllDay = false;
            try { new TimeSpan(Convert.ToInt32(mtbPukul.Text.Remove(2)), Convert.ToInt32(mtbPukul.Text.Remove(0, 3)), 0); }
            catch { IsAllDay = true; }
            Event newEvent;
            if (!IsAllDay)
            {
                newEvent = new Event()
                {
                    Summary = cbJenis.Text + ": " + tbNama.Text + " " + mtbPukul.Text,
                    Start = new EventDateTime()
                    {
                        Date = dtpTanggal.Value.ToString("yyyy-MM-dd"),
                        TimeZone = "Asia/Jakarta",
                    },
                    End = new EventDateTime()
                    {
                        Date = dtpTanggal.Value.ToString("yyyy-MM-dd"),
                        TimeZone = "Asia/Jakarta",
                    }
                };
            }
            else
            {
                newEvent = new Event()
                {
                    Summary = cbJenis.Text + ": " + tbNama.Text,
                    Start = new EventDateTime()
                    {
                        Date = dtpTanggal.Value.ToString("yyyy-MM-dd"),
                        TimeZone = "Asia/Jakarta",
                    },
                    End = new EventDateTime()
                    {
                        Date = dtpTanggal.Value.ToString("yyyy-MM-dd"),
                        TimeZone = "Asia/Jakarta",
                    }
                };
            }
            if (tbTempat.Text != "")
                newEvent.Location = tbTempat.Text;
            if (tbDeskripsi.Text != "")
                newEvent.Description = tbDeskripsi.Text;

            // DO REQUEST
            string calendarId = "primary";
            try
            {
                EventsResource.InsertRequest request = service.Events.Insert(newEvent, calendarId);
                Event createdEvent = request.Execute();
                MessageBox.Show("Berhasil dihubungkan ke Google Calendar. Silakan buka Google Calendar Anda untuk mengecek.", "Pemberitahuan");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mohon maaf, gagal dihubungkan ke Google Calendar: " + ex.Message, "Pemberitahuan");
            }
        }
    }
}
