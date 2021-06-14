namespace productify1
{
    partial class FormOperasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTambah = new System.Windows.Forms.Button();
            this.lblJenis = new System.Windows.Forms.Label();
            this.cbJenis = new System.Windows.Forms.ComboBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.tbTempat = new System.Windows.Forms.TextBox();
            this.lblTempat = new System.Windows.Forms.Label();
            this.tbDeskripsi = new System.Windows.Forms.TextBox();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.lblPukul = new System.Windows.Forms.Label();
            this.mtbPukul = new System.Windows.Forms.MaskedTextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(40, 174);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(228, 21);
            this.btnTambah.TabIndex = 5;
            this.btnTambah.Text = "Tambahkan";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // lblJenis
            // 
            this.lblJenis.AutoSize = true;
            this.lblJenis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblJenis.Location = new System.Drawing.Point(37, 18);
            this.lblJenis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJenis.Name = "lblJenis";
            this.lblJenis.Size = new System.Drawing.Size(35, 15);
            this.lblJenis.TabIndex = 6;
            this.lblJenis.Text = "Jenis:";
            // 
            // cbJenis
            // 
            this.cbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJenis.FormattingEnabled = true;
            this.cbJenis.Items.AddRange(new object[] {
            "PR",
            "Ulangan",
            "Organisasi",
            "Kerja Kelompok",
            "Lain"});
            this.cbJenis.Location = new System.Drawing.Point(86, 16);
            this.cbJenis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbJenis.Name = "cbJenis";
            this.cbJenis.Size = new System.Drawing.Size(200, 21);
            this.cbJenis.TabIndex = 7;
            this.cbJenis.SelectedIndexChanged += new System.EventHandler(this.cbJenis_SelectedIndexChanged);
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNama.Location = new System.Drawing.Point(30, 39);
            this.lblNama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(42, 15);
            this.lblNama.TabIndex = 8;
            this.lblNama.Text = "Nama:";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(86, 38);
            this.tbNama.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(200, 20);
            this.tbNama.TabIndex = 9;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTanggal.Location = new System.Drawing.Point(21, 59);
            this.lblTanggal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(51, 15);
            this.lblTanggal.TabIndex = 10;
            this.lblTanggal.Text = "Tanggal:";
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Location = new System.Drawing.Point(86, 59);
            this.dtpTanggal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(200, 20);
            this.dtpTanggal.TabIndex = 11;
            // 
            // tbTempat
            // 
            this.tbTempat.Location = new System.Drawing.Point(86, 102);
            this.tbTempat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTempat.Name = "tbTempat";
            this.tbTempat.Size = new System.Drawing.Size(200, 20);
            this.tbTempat.TabIndex = 13;
            // 
            // lblTempat
            // 
            this.lblTempat.AutoSize = true;
            this.lblTempat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTempat.Location = new System.Drawing.Point(23, 103);
            this.lblTempat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTempat.Name = "lblTempat";
            this.lblTempat.Size = new System.Drawing.Size(49, 15);
            this.lblTempat.TabIndex = 12;
            this.lblTempat.Text = "Tempat:";
            // 
            // tbDeskripsi
            // 
            this.tbDeskripsi.Location = new System.Drawing.Point(86, 123);
            this.tbDeskripsi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDeskripsi.Name = "tbDeskripsi";
            this.tbDeskripsi.Size = new System.Drawing.Size(200, 20);
            this.tbDeskripsi.TabIndex = 15;
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDeskripsi.Location = new System.Drawing.Point(13, 124);
            this.lblDeskripsi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(57, 15);
            this.lblDeskripsi.TabIndex = 14;
            this.lblDeskripsi.Text = "Deskripsi:";
            // 
            // lblPukul
            // 
            this.lblPukul.AutoSize = true;
            this.lblPukul.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPukul.Location = new System.Drawing.Point(33, 80);
            this.lblPukul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPukul.Name = "lblPukul";
            this.lblPukul.Size = new System.Drawing.Size(40, 15);
            this.lblPukul.TabIndex = 16;
            this.lblPukul.Text = "Pukul:";
            // 
            // mtbPukul
            // 
            this.mtbPukul.Location = new System.Drawing.Point(86, 81);
            this.mtbPukul.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbPukul.Mask = "00:00";
            this.mtbPukul.Name = "mtbPukul";
            this.mtbPukul.Size = new System.Drawing.Size(34, 20);
            this.mtbPukul.TabIndex = 17;
            this.mtbPukul.ValidatingType = typeof(System.DateTime);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Checked = true;
            this.checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox.Location = new System.Drawing.Point(71, 150);
            this.checkBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(179, 17);
            this.checkBox.TabIndex = 18;
            this.checkBox.Text = "Hubungkan ke Google Calendar";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // FormOperasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(303, 212);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.mtbPukul);
            this.Controls.Add(this.lblPukul);
            this.Controls.Add(this.tbDeskripsi);
            this.Controls.Add(this.lblDeskripsi);
            this.Controls.Add(this.tbTempat);
            this.Controls.Add(this.lblTempat);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.cbJenis);
            this.Controls.Add(this.lblJenis);
            this.Controls.Add(this.btnTambah);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormOperasi";
            this.Text = "Tambah Agenda";
            this.Load += new System.EventHandler(this.FormTambah_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label lblJenis;
        private System.Windows.Forms.ComboBox cbJenis;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.TextBox tbTempat;
        private System.Windows.Forms.Label lblTempat;
        private System.Windows.Forms.TextBox tbDeskripsi;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.Label lblPukul;
        private System.Windows.Forms.MaskedTextBox mtbPukul;
        private System.Windows.Forms.CheckBox checkBox;
    }
}