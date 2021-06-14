using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace productify1
{
    public partial class FormUtama : Form
    {
        // KONSTRUKTOR
        public FormUtama()
        {
            InitializeComponent();
        }

        // EVENTS
        private void FormUtama_Load(object sender, EventArgs e)
        {
            agendaTableAdapter.Fill(databaseAgendaDataSet.Agenda);
            dgvAgenda.Columns[0].Visible = false;
            dgvAgenda.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvAgenda.Columns[4].DefaultCellStyle.Format = "hh':'mm";
            HapusAgendaLampau();
            dgvAgenda.Sort(dgvAgenda.Columns[3], ListSortDirection.Ascending);
            UpdateStatus();
        }

        private void FormUtama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                MessageBox.Show("Aplikasi ini dibuat untuk membantu belajar. Fitur aplikasi ini adalah membuat tabel PR/tugas, ulangan, kerja kelompok, dll. dan menghubungkannya dengan Google Calendar.",
                    "Tentang Aplikasi");
        }

        private void tsmiTentang_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikasi ini dibuat untuk membantu belajar. Fitur aplikasi ini adalah membuat tabel PR/tugas, ulangan, kerja kelompok, dll. dan menghubungkannya dengan Google Calendar.",
                    "Tentang Aplikasi");
        }

        private void tsbHapus_Click(object sender, EventArgs e)
        {
            if (dgvAgenda.Rows.Count != 0)
            {
                string jenis = dgvAgenda.CurrentRow.Cells[1].Value as string;
                string nama = dgvAgenda.CurrentRow.Cells[2].Value as string;
                if (MessageBox.Show("Yakin hapus " + jenis + ": " + nama + "?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dgvAgenda.Rows.RemoveAt(dgvAgenda.CurrentRow.Index);
                    agendaTableAdapter.Update(databaseAgendaDataSet.Agenda);
                }
            }
            else
                MessageBox.Show("Tidak ada agenda untuk dihapus!", "Pemberitahuan");
        }

        private void tsbTambah_Click(object sender, EventArgs e)
        {
            EventTambah();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (dgvAgenda.Rows.Count != 0)
            {
                new FormOperasi(dgvAgenda.CurrentRow).ShowDialog();
                agendaTableAdapter.Fill(databaseAgendaDataSet.Agenda);
            }
            else
                MessageBox.Show("Tidak ada agenda untuk diedit!", "Pemberitahuan");
        }

        private void tsmiLog_Click(object sender, EventArgs e)
        {
            if (tsmiLog.Text == "Logout")
            {
                try
                {
                    File.Delete(Environment.CurrentDirectory + @"\token.json\Google.Apis.Auth.OAuth2.Responses.TokenResponse-user");
                    UpdateStatus();
                    MessageBox.Show("Logout berhasil!", "Pemberitahuan");
                }
                catch { MessageBox.Show("Mohon maaf, gagal logout.", "Pemberitahuan"); }
            }
            else
            {
                EventTambah();
            }
        }

        // METODE
        private void HapusAgendaLampau()
        {
            List<int> indexes = new List<int>();
            foreach (DataGridViewRow row in dgvAgenda.Rows)
            {
                if ((DateTime)row.Cells[3].Value < DateTime.Today)
                    indexes.Add(row.Index);
            }
            indexes.TrimExcess();
            if (indexes.Count != 0)
                if (MessageBox.Show("Hapus agenda yang sudah lalu?", "Selamat Datang Kembali", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (int index in indexes)
                        dgvAgenda.Rows.RemoveAt(index);
                    agendaTableAdapter.Update(databaseAgendaDataSet.Agenda);
                }
        }

        private void UpdateStatus()
        {
            if (Directory.EnumerateFileSystemEntries(Environment.CurrentDirectory + @"\token.json").Any())
            {
                tsmiStatus.Text = "Status: Ter-login dengan Google Calendar";
                tsmiLog.Text = "Logout";
            }
            else
            {
                tsmiStatus.Text = "Status: Belum login ke Google Calendar";
                tsmiLog.Text = "Tambah Agenda untuk login ke Google Calendar";
            }
        }

        private void EventTambah()
        {
            int id = 0;
            foreach (DataGridViewRow row in dgvAgenda.Rows)
                if (row.Cells[0].Value != null)
                    if ((int)row.Cells[0].Value > id)
                        id = (int)row.Cells[0].Value;
            new FormOperasi(++id).ShowDialog();
            agendaTableAdapter.Fill(databaseAgendaDataSet.Agenda);
            UpdateStatus();
        }

        private void dgvAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
