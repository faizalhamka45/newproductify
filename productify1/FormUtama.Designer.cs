namespace productify1
{
    partial class FormUtama
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUtama));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTentang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbTambah = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbHapus = new System.Windows.Forms.ToolStripButton();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseAgendaDataSet = new productify1.DatabaseAgendaDataSet();
            this.agendaTableAdapter = new productify1.DatabaseAgendaDataSetTableAdapters.AgendaTableAdapter();
            this.databaseAgendaDataSet1 = new productify1.DatabaseAgendaDataSet();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAgendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAgendaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStatus,
            this.tsmiTentang});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip.Size = new System.Drawing.Size(912, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // tsmiStatus
            // 
            this.tsmiStatus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLog});
            this.tsmiStatus.Name = "tsmiStatus";
            this.tsmiStatus.Size = new System.Drawing.Size(57, 22);
            this.tsmiStatus.Text = "Status: ";
            // 
            // tsmiLog
            // 
            this.tsmiLog.Name = "tsmiLog";
            this.tsmiLog.Size = new System.Drawing.Size(94, 22);
            this.tsmiLog.Text = "Log";
            this.tsmiLog.Click += new System.EventHandler(this.tsmiLog_Click);
            // 
            // tsmiTentang
            // 
            this.tsmiTentang.Name = "tsmiTentang";
            this.tsmiTentang.Size = new System.Drawing.Size(84, 22);
            this.tsmiTentang.Text = "Tentang - F1";
            this.tsmiTentang.Click += new System.EventHandler(this.tsmiTentang_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEdit,
            this.tsbTambah,
            this.tsbHapus});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(912, 31);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsbTambah
            // 
            this.tsbTambah.Image = ((System.Drawing.Image)(resources.GetObject("tsbTambah.Image")));
            this.tsbTambah.ImageTransparentColor = System.Drawing.SystemColors.Control;
            this.tsbTambah.Name = "tsbTambah";
            this.tsbTambah.Size = new System.Drawing.Size(77, 28);
            this.tsbTambah.Text = "Tambah";
            this.tsbTambah.Click += new System.EventHandler(this.tsbTambah_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.SystemColors.Control;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(55, 28);
            this.tsbEdit.Text = "Edit";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbHapus
            // 
            this.tsbHapus.Image = ((System.Drawing.Image)(resources.GetObject("tsbHapus.Image")));
            this.tsbHapus.ImageTransparentColor = System.Drawing.SystemColors.Control;
            this.tsbHapus.Name = "tsbHapus";
            this.tsbHapus.Size = new System.Drawing.Size(69, 28);
            this.tsbHapus.Text = "Hapus";
            this.tsbHapus.Click += new System.EventHandler(this.tsbHapus_Click);
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.AllowUserToAddRows = false;
            this.dgvAgenda.AutoGenerateColumns = false;
            this.dgvAgenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAgenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgvAgenda.DataSource = this.agendaBindingSource;
            this.dgvAgenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAgenda.Location = new System.Drawing.Point(0, 55);
            this.dgvAgenda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.ReadOnly = true;
            this.dgvAgenda.RowTemplate.Height = 28;
            this.dgvAgenda.Size = new System.Drawing.Size(912, 432);
            this.dgvAgenda.TabIndex = 2;
            this.dgvAgenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgenda_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Jenis";
            this.dataGridViewTextBoxColumn2.HeaderText = "Jenis";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nama";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nama";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Tanggal";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tanggal";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Pukul";
            this.dataGridViewTextBoxColumn5.HeaderText = "Pukul";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Tempat";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tempat";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Deskripsi";
            this.dataGridViewTextBoxColumn7.HeaderText = "Deskripsi";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // agendaBindingSource
            // 
            this.agendaBindingSource.DataMember = "Agenda";
            this.agendaBindingSource.DataSource = this.databaseAgendaDataSet;
            // 
            // databaseAgendaDataSet
            // 
            this.databaseAgendaDataSet.DataSetName = "DatabaseAgendaDataSet";
            this.databaseAgendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agendaTableAdapter
            // 
            this.agendaTableAdapter.ClearBeforeFill = true;
            // 
            // databaseAgendaDataSet1
            // 
            this.databaseAgendaDataSet1.DataSetName = "DatabaseAgendaDataSet";
            this.databaseAgendaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 487);
            this.Controls.Add(this.dgvAgenda);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormUtama";
            this.Text = "Productify";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormUtama_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAgendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAgendaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiTentang;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbTambah;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbHapus;
        private System.Windows.Forms.DataGridView dgvAgenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pukulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsiDataGridViewTextBoxColumn;
        private DatabaseAgendaDataSet databaseAgendaDataSet;
        private System.Windows.Forms.BindingSource agendaBindingSource;
        private DatabaseAgendaDataSetTableAdapters.AgendaTableAdapter agendaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ToolStripMenuItem tsmiStatus;
        private System.Windows.Forms.ToolStripMenuItem tsmiLog;
        private DatabaseAgendaDataSet databaseAgendaDataSet1;
    }
}

