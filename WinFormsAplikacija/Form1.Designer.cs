
namespace WinFormsAplikacija
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDrzavljanstvo = new System.Windows.Forms.TextBox();
            this.lblSpol = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDrzavljanstvo = new System.Windows.Forms.Label();
            this.lblOib = new System.Windows.Forms.Label();
            this.btnDodajClana = new System.Windows.Forms.Button();
            this.lblClanovi = new System.Windows.Forms.Label();
            this.txtPrezimeDjelatnik = new System.Windows.Forms.TextBox();
            this.txtImeDjelatnik = new System.Windows.Forms.TextBox();
            this.txtIdDjelatnik = new System.Windows.Forms.TextBox();
            this.lblSpo = new System.Windows.Forms.Label();
            this.lblDatumRodjenaDjelatnik = new System.Windows.Forms.Label();
            this.lblPrezimeDjelatnik = new System.Windows.Forms.Label();
            this.lblImeDjelatnik = new System.Windows.Forms.Label();
            this.lblIdDjelatnik = new System.Windows.Forms.Label();
            this.dataGridViewClanovi = new System.Windows.Forms.DataGridView();
            this.Obriši = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewDjelatnici = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumRodjenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.drzavljanstvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.djelatniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumRodjenaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spolDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clanoviObiteljiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClanovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDjelatnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.djelatniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanoviObiteljiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtDrzavljanstvo);
            this.panel1.Controls.Add(this.lblSpol);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblDrzavljanstvo);
            this.panel1.Controls.Add(this.lblOib);
            this.panel1.Controls.Add(this.btnDodajClana);
            this.panel1.Controls.Add(this.lblClanovi);
            this.panel1.Controls.Add(this.txtPrezimeDjelatnik);
            this.panel1.Controls.Add(this.txtImeDjelatnik);
            this.panel1.Controls.Add(this.txtIdDjelatnik);
            this.panel1.Controls.Add(this.lblSpo);
            this.panel1.Controls.Add(this.lblDatumRodjenaDjelatnik);
            this.panel1.Controls.Add(this.lblPrezimeDjelatnik);
            this.panel1.Controls.Add(this.lblImeDjelatnik);
            this.panel1.Controls.Add(this.lblIdDjelatnik);
            this.panel1.Controls.Add(this.dataGridViewClanovi);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(33, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 281);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.djelatniciBindingSource, "DatumRodjena", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(83, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.djelatniciBindingSource, "Spol", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Muško",
            "Žensko"});
            this.comboBox1.Location = new System.Drawing.Point(83, 156);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.djelatniciBindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(83, 225);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(151, 20);
            this.txtEmail.TabIndex = 19;
            // 
            // txtDrzavljanstvo
            // 
            this.txtDrzavljanstvo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.djelatniciBindingSource, "Drzavljanstvo", true));
            this.txtDrzavljanstvo.Location = new System.Drawing.Point(83, 193);
            this.txtDrzavljanstvo.Name = "txtDrzavljanstvo";
            this.txtDrzavljanstvo.Size = new System.Drawing.Size(151, 20);
            this.txtDrzavljanstvo.TabIndex = 18;
            // 
            // lblSpol
            // 
            this.lblSpol.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.djelatniciBindingSource, "OIB", true));
            this.lblSpol.Location = new System.Drawing.Point(83, 127);
            this.lblSpol.Name = "lblSpol";
            this.lblSpol.Size = new System.Drawing.Size(151, 20);
            this.lblSpol.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 225);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email:";
            // 
            // lblDrzavljanstvo
            // 
            this.lblDrzavljanstvo.AutoSize = true;
            this.lblDrzavljanstvo.Location = new System.Drawing.Point(9, 193);
            this.lblDrzavljanstvo.Name = "lblDrzavljanstvo";
            this.lblDrzavljanstvo.Size = new System.Drawing.Size(74, 13);
            this.lblDrzavljanstvo.TabIndex = 15;
            this.lblDrzavljanstvo.Text = "Državljanstvo:";
            // 
            // lblOib
            // 
            this.lblOib.AutoSize = true;
            this.lblOib.Location = new System.Drawing.Point(7, 129);
            this.lblOib.Name = "lblOib";
            this.lblOib.Size = new System.Drawing.Size(28, 13);
            this.lblOib.TabIndex = 14;
            this.lblOib.Text = "OIB:";
            // 
            // btnDodajClana
            // 
            this.btnDodajClana.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDodajClana.Location = new System.Drawing.Point(669, 77);
            this.btnDodajClana.Name = "btnDodajClana";
            this.btnDodajClana.Size = new System.Drawing.Size(53, 37);
            this.btnDodajClana.TabIndex = 13;
            this.btnDodajClana.Text = "Dodaj člana";
            this.btnDodajClana.UseVisualStyleBackColor = false;
            this.btnDodajClana.Click += new System.EventHandler(this.btnDodajClana_Click);
            // 
            // lblClanovi
            // 
            this.lblClanovi.AutoSize = true;
            this.lblClanovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClanovi.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblClanovi.Location = new System.Drawing.Point(292, 59);
            this.lblClanovi.Name = "lblClanovi";
            this.lblClanovi.Size = new System.Drawing.Size(124, 20);
            this.lblClanovi.TabIndex = 12;
            this.lblClanovi.Text = "Članovi obitelji";
            // 
            // txtPrezimeDjelatnik
            // 
            this.txtPrezimeDjelatnik.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.djelatniciBindingSource, "Prezime", true));
            this.txtPrezimeDjelatnik.Location = new System.Drawing.Point(83, 64);
            this.txtPrezimeDjelatnik.Name = "txtPrezimeDjelatnik";
            this.txtPrezimeDjelatnik.Size = new System.Drawing.Size(151, 20);
            this.txtPrezimeDjelatnik.TabIndex = 9;
            // 
            // txtImeDjelatnik
            // 
            this.txtImeDjelatnik.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.djelatniciBindingSource, "Ime", true));
            this.txtImeDjelatnik.Location = new System.Drawing.Point(83, 39);
            this.txtImeDjelatnik.Name = "txtImeDjelatnik";
            this.txtImeDjelatnik.Size = new System.Drawing.Size(151, 20);
            this.txtImeDjelatnik.TabIndex = 8;
            // 
            // txtIdDjelatnik
            // 
            this.txtIdDjelatnik.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.djelatniciBindingSource, "Id", true));
            this.txtIdDjelatnik.Location = new System.Drawing.Point(83, 3);
            this.txtIdDjelatnik.Name = "txtIdDjelatnik";
            this.txtIdDjelatnik.ReadOnly = true;
            this.txtIdDjelatnik.Size = new System.Drawing.Size(23, 20);
            this.txtIdDjelatnik.TabIndex = 7;
            // 
            // lblSpo
            // 
            this.lblSpo.AutoSize = true;
            this.lblSpo.Location = new System.Drawing.Point(7, 156);
            this.lblSpo.Name = "lblSpo";
            this.lblSpo.Size = new System.Drawing.Size(31, 13);
            this.lblSpo.TabIndex = 6;
            this.lblSpo.Text = "Spol:";
            // 
            // lblDatumRodjenaDjelatnik
            // 
            this.lblDatumRodjenaDjelatnik.AutoSize = true;
            this.lblDatumRodjenaDjelatnik.Location = new System.Drawing.Point(-3, 101);
            this.lblDatumRodjenaDjelatnik.Name = "lblDatumRodjenaDjelatnik";
            this.lblDatumRodjenaDjelatnik.Size = new System.Drawing.Size(80, 13);
            this.lblDatumRodjenaDjelatnik.TabIndex = 5;
            this.lblDatumRodjenaDjelatnik.Text = "Datum rođenja:";
            // 
            // lblPrezimeDjelatnik
            // 
            this.lblPrezimeDjelatnik.AutoSize = true;
            this.lblPrezimeDjelatnik.Location = new System.Drawing.Point(3, 64);
            this.lblPrezimeDjelatnik.Name = "lblPrezimeDjelatnik";
            this.lblPrezimeDjelatnik.Size = new System.Drawing.Size(47, 13);
            this.lblPrezimeDjelatnik.TabIndex = 4;
            this.lblPrezimeDjelatnik.Text = "Prezime:";
            // 
            // lblImeDjelatnik
            // 
            this.lblImeDjelatnik.AutoSize = true;
            this.lblImeDjelatnik.Location = new System.Drawing.Point(7, 39);
            this.lblImeDjelatnik.Name = "lblImeDjelatnik";
            this.lblImeDjelatnik.Size = new System.Drawing.Size(27, 13);
            this.lblImeDjelatnik.TabIndex = 3;
            this.lblImeDjelatnik.Text = "Ime:";
            // 
            // lblIdDjelatnik
            // 
            this.lblIdDjelatnik.AutoSize = true;
            this.lblIdDjelatnik.Location = new System.Drawing.Point(7, 10);
            this.lblIdDjelatnik.Name = "lblIdDjelatnik";
            this.lblIdDjelatnik.Size = new System.Drawing.Size(59, 13);
            this.lblIdDjelatnik.TabIndex = 2;
            this.lblIdDjelatnik.Text = "Djelatik ID:";
            // 
            // dataGridViewClanovi
            // 
            this.dataGridViewClanovi.AllowUserToAddRows = false;
            this.dataGridViewClanovi.AllowUserToDeleteRows = false;
            this.dataGridViewClanovi.AutoGenerateColumns = false;
            this.dataGridViewClanovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClanovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.Obriši,
            this.imeDataGridViewTextBoxColumn1,
            this.prezimeDataGridViewTextBoxColumn1,
            this.datumRodjenaDataGridViewTextBoxColumn1,
            this.spolDataGridViewTextBoxColumn1});
            this.dataGridViewClanovi.DataSource = this.clanoviObiteljiBindingSource;
            this.dataGridViewClanovi.Location = new System.Drawing.Point(296, 81);
            this.dataGridViewClanovi.Name = "dataGridViewClanovi";
            this.dataGridViewClanovi.Size = new System.Drawing.Size(367, 100);
            this.dataGridViewClanovi.TabIndex = 1;
            this.dataGridViewClanovi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClanovi_CellContentClick);
            // 
            // Obriši
            // 
            this.Obriši.HeaderText = "Obriši";
            this.Obriši.Name = "Obriši";
            this.Obriši.Text = "X";
            this.Obriši.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewDjelatnici
            // 
            this.dataGridViewDjelatnici.AllowUserToAddRows = false;
            this.dataGridViewDjelatnici.AllowUserToDeleteRows = false;
            this.dataGridViewDjelatnici.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDjelatnici.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDjelatnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDjelatnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Delete,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.datumRodjenaDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn,
            this.spolDataGridViewTextBoxColumn,
            this.drzavljanstvoDataGridViewTextBoxColumn,
            this.Email});
            this.dataGridViewDjelatnici.DataSource = this.djelatniciBindingSource;
            this.dataGridViewDjelatnici.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewDjelatnici.Location = new System.Drawing.Point(0, 369);
            this.dataGridViewDjelatnici.Name = "dataGridViewDjelatnici";
            this.dataGridViewDjelatnici.Size = new System.Drawing.Size(800, 150);
            this.dataGridViewDjelatnici.TabIndex = 1;
            this.dataGridViewDjelatnici.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDjelatnici_CellClick);
            this.dataGridViewDjelatnici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDjelatnici_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "X";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDodaj.Location = new System.Drawing.Point(220, 301);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 31);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.BackColor = System.Drawing.Color.PowderBlue;
            this.btnUredi.Location = new System.Drawing.Point(352, 301);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 31);
            this.btnUredi.TabIndex = 3;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = false;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(466, 301);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 31);
            this.btnOdustani.TabIndex = 4;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click_1);
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSpremi.Location = new System.Drawing.Point(600, 301);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 31);
            this.btnSpremi.TabIndex = 5;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // datumRodjenaDataGridViewTextBoxColumn
            // 
            this.datumRodjenaDataGridViewTextBoxColumn.DataPropertyName = "DatumRodjena";
            this.datumRodjenaDataGridViewTextBoxColumn.HeaderText = "DatumRodjena";
            this.datumRodjenaDataGridViewTextBoxColumn.Name = "datumRodjenaDataGridViewTextBoxColumn";
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            // 
            // spolDataGridViewTextBoxColumn
            // 
            this.spolDataGridViewTextBoxColumn.DataPropertyName = "Spol";
            this.spolDataGridViewTextBoxColumn.HeaderText = "Spol";
            this.spolDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Muško",
            "Žensko"});
            this.spolDataGridViewTextBoxColumn.Name = "spolDataGridViewTextBoxColumn";
            this.spolDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.spolDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // drzavljanstvoDataGridViewTextBoxColumn
            // 
            this.drzavljanstvoDataGridViewTextBoxColumn.DataPropertyName = "Drzavljanstvo";
            this.drzavljanstvoDataGridViewTextBoxColumn.HeaderText = "Drzavljanstvo";
            this.drzavljanstvoDataGridViewTextBoxColumn.Name = "drzavljanstvoDataGridViewTextBoxColumn";
            // 
            // djelatniciBindingSource
            // 
            this.djelatniciBindingSource.DataSource = typeof(WinFormsAplikacija.Djelatnici);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // imeDataGridViewTextBoxColumn1
            // 
            this.imeDataGridViewTextBoxColumn1.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn1.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn1.Name = "imeDataGridViewTextBoxColumn1";
            // 
            // prezimeDataGridViewTextBoxColumn1
            // 
            this.prezimeDataGridViewTextBoxColumn1.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn1.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn1.Name = "prezimeDataGridViewTextBoxColumn1";
            // 
            // datumRodjenaDataGridViewTextBoxColumn1
            // 
            this.datumRodjenaDataGridViewTextBoxColumn1.DataPropertyName = "DatumRodjena";
            this.datumRodjenaDataGridViewTextBoxColumn1.HeaderText = "DatumRodjena";
            this.datumRodjenaDataGridViewTextBoxColumn1.Name = "datumRodjenaDataGridViewTextBoxColumn1";
            // 
            // spolDataGridViewTextBoxColumn1
            // 
            this.spolDataGridViewTextBoxColumn1.DataPropertyName = "Spol";
            this.spolDataGridViewTextBoxColumn1.HeaderText = "Spol";
            this.spolDataGridViewTextBoxColumn1.Items.AddRange(new object[] {
            "Muško",
            "Žensko"});
            this.spolDataGridViewTextBoxColumn1.Name = "spolDataGridViewTextBoxColumn1";
            this.spolDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.spolDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clanoviObiteljiBindingSource
            // 
            this.clanoviObiteljiBindingSource.DataSource = typeof(WinFormsAplikacija.ClanoviObitelji);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dataGridViewDjelatnici);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClanovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDjelatnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.djelatniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanoviObiteljiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDodajClana;
        private System.Windows.Forms.Label lblClanovi;
        private System.Windows.Forms.TextBox txtPrezimeDjelatnik;
        private System.Windows.Forms.TextBox txtImeDjelatnik;
        private System.Windows.Forms.TextBox txtIdDjelatnik;
        private System.Windows.Forms.Label lblSpo;
        private System.Windows.Forms.Label lblDatumRodjenaDjelatnik;
        private System.Windows.Forms.Label lblPrezimeDjelatnik;
        private System.Windows.Forms.Label lblImeDjelatnik;
        private System.Windows.Forms.Label lblIdDjelatnik;
        private System.Windows.Forms.DataGridView dataGridViewClanovi;
        private System.Windows.Forms.DataGridView dataGridViewDjelatnici;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.BindingSource clanoviObiteljiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn emaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource djelatniciBindingSource;
        private System.Windows.Forms.TextBox lblSpol;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDrzavljanstvo;
        private System.Windows.Forms.Label lblOib;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDrzavljanstvo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumRodjenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn spolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drzavljanstvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn Obriši;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumRodjenaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn spolDataGridViewTextBoxColumn1;
    }
}

