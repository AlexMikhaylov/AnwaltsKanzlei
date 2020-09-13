namespace AnwaltsKanzleiUI
{
    partial class AnwaltsKanzleiForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageTermine = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAktenzeichen = new System.Windows.Forms.Label();
            this.dropDownKlienten = new System.Windows.Forms.ComboBox();
            this.dropDownAktenzeichen = new System.Windows.Forms.ComboBox();
            this.labelKlienten = new System.Windows.Forms.Label();
            this.buttonExitTermine = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.tabPageKlienten = new System.Windows.Forms.TabPage();
            this.buttonExtiKlienten = new System.Windows.Forms.Button();
            this.groupBoxKlienten = new System.Windows.Forms.GroupBox();
            this.buttonLoeschenKlienten = new System.Windows.Forms.Button();
            this.buttonAktualisierenKlienten = new System.Windows.Forms.Button();
            this.buttonHinzufuegenKlienten = new System.Windows.Forms.Button();
            this.labelAlleKlienten = new System.Windows.Forms.Label();
            this.tabelleKlienten = new System.Windows.Forms.DataGridView();
            this.IDKlienten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAnrede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtVorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStrasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtOrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPLZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageMitarbeiter = new System.Windows.Forms.TabPage();
            this.groupBoxMitarbeiter = new System.Windows.Forms.GroupBox();
            this.buttonLoeschenMitarbeiter = new System.Windows.Forms.Button();
            this.buttonAktualisierenMitarbeiter = new System.Windows.Forms.Button();
            this.buttonHinzufuegenMitarbeiter = new System.Windows.Forms.Button();
            this.buttonExitMitarbeiter = new System.Windows.Forms.Button();
            this.labelAlleMitarbeiter = new System.Windows.Forms.Label();
            this.tabelleMitarbeiter = new System.Windows.Forms.DataGridView();
            this.IDMitarbeiter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAnredeMitarbeiter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTitel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNameMitarbeiter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtVornameMitarbeiter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDFunktion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtStrasseMitarbeiter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtOrtMitarbeiter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPLZMitarbeiter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageRaum = new System.Windows.Forms.TabPage();
            this.groupBoxRaum = new System.Windows.Forms.GroupBox();
            this.buttonLoeschenRaum = new System.Windows.Forms.Button();
            this.buttonAktualisierenRaum = new System.Windows.Forms.Button();
            this.buttonHinzufuegenRaum = new System.Windows.Forms.Button();
            this.buttonExitRaum = new System.Windows.Forms.Button();
            this.labelRaum = new System.Windows.Forms.Label();
            this.tabelleRaum = new System.Windows.Forms.DataGridView();
            this.IDRaum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSitzungsart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingPlatzzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info1 = new AnwaltsKanzleiUI.Info();
            this.kalender1 = new AnwaltsKanzleiUI.Kalender();
            this.tabControl.SuspendLayout();
            this.tabPageTermine.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.tabPageKlienten.SuspendLayout();
            this.groupBoxKlienten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelleKlienten)).BeginInit();
            this.tabPageMitarbeiter.SuspendLayout();
            this.groupBoxMitarbeiter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelleMitarbeiter)).BeginInit();
            this.tabPageRaum.SuspendLayout();
            this.groupBoxRaum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelleRaum)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageTermine);
            this.tabControl.Controls.Add(this.tabPageKlienten);
            this.tabControl.Controls.Add(this.tabPageMitarbeiter);
            this.tabControl.Controls.Add(this.tabPageRaum);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1498, 735);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageTermine
            // 
            this.tabPageTermine.Controls.Add(this.groupBox1);
            this.tabPageTermine.Controls.Add(this.buttonExitTermine);
            this.tabPageTermine.Controls.Add(this.panelContainer);
            this.tabPageTermine.ForeColor = System.Drawing.Color.Black;
            this.tabPageTermine.Location = new System.Drawing.Point(4, 46);
            this.tabPageTermine.Name = "tabPageTermine";
            this.tabPageTermine.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTermine.Size = new System.Drawing.Size(1490, 685);
            this.tabPageTermine.TabIndex = 0;
            this.tabPageTermine.Text = "Termine";
            this.tabPageTermine.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAktenzeichen);
            this.groupBox1.Controls.Add(this.dropDownKlienten);
            this.groupBox1.Controls.Add(this.dropDownAktenzeichen);
            this.groupBox1.Controls.Add(this.labelKlienten);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1043, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 327);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aktenzeichen / Klienten-Auswahl:";
            // 
            // labelAktenzeichen
            // 
            this.labelAktenzeichen.AutoSize = true;
            this.labelAktenzeichen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAktenzeichen.ForeColor = System.Drawing.Color.Black;
            this.labelAktenzeichen.Location = new System.Drawing.Point(48, 73);
            this.labelAktenzeichen.Name = "labelAktenzeichen";
            this.labelAktenzeichen.Size = new System.Drawing.Size(132, 28);
            this.labelAktenzeichen.TabIndex = 0;
            this.labelAktenzeichen.Text = "Aktenzeichen:";
            // 
            // dropDownKlienten
            // 
            this.dropDownKlienten.FormattingEnabled = true;
            this.dropDownKlienten.Location = new System.Drawing.Point(54, 217);
            this.dropDownKlienten.Name = "dropDownKlienten";
            this.dropDownKlienten.Size = new System.Drawing.Size(306, 36);
            this.dropDownKlienten.TabIndex = 3;
            this.dropDownKlienten.SelectedValueChanged += new System.EventHandler(this.dropDownKlienten_SelectedValueChanged);
            // 
            // dropDownAktenzeichen
            // 
            this.dropDownAktenzeichen.FormattingEnabled = true;
            this.dropDownAktenzeichen.Location = new System.Drawing.Point(54, 120);
            this.dropDownAktenzeichen.Name = "dropDownAktenzeichen";
            this.dropDownAktenzeichen.Size = new System.Drawing.Size(306, 36);
            this.dropDownAktenzeichen.TabIndex = 2;
            this.dropDownAktenzeichen.SelectedValueChanged += new System.EventHandler(this.dropDownAktenzeichen_SelectedValueChanged);
            // 
            // labelKlienten
            // 
            this.labelKlienten.AutoSize = true;
            this.labelKlienten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelKlienten.ForeColor = System.Drawing.Color.Black;
            this.labelKlienten.Location = new System.Drawing.Point(48, 176);
            this.labelKlienten.Name = "labelKlienten";
            this.labelKlienten.Size = new System.Drawing.Size(66, 28);
            this.labelKlienten.TabIndex = 1;
            this.labelKlienten.Text = "Klient:";
            // 
            // buttonExitTermine
            // 
            this.buttonExitTermine.BackColor = System.Drawing.Color.LightPink;
            this.buttonExitTermine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.buttonExitTermine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonExitTermine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitTermine.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.buttonExitTermine.ForeColor = System.Drawing.Color.White;
            this.buttonExitTermine.Location = new System.Drawing.Point(1337, 625);
            this.buttonExitTermine.Name = "buttonExitTermine";
            this.buttonExitTermine.Size = new System.Drawing.Size(148, 52);
            this.buttonExitTermine.TabIndex = 55;
            this.buttonExitTermine.Text = "beenden";
            this.buttonExitTermine.UseVisualStyleBackColor = false;
            this.buttonExitTermine.Click += new System.EventHandler(this.buttonFinisch_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.info1);
            this.panelContainer.Controls.Add(this.kalender1);
            this.panelContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelContainer.Location = new System.Drawing.Point(8, 18);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1026, 634);
            this.panelContainer.TabIndex = 7;
            // 
            // tabPageKlienten
            // 
            this.tabPageKlienten.Controls.Add(this.buttonExtiKlienten);
            this.tabPageKlienten.Controls.Add(this.groupBoxKlienten);
            this.tabPageKlienten.Controls.Add(this.labelAlleKlienten);
            this.tabPageKlienten.Controls.Add(this.tabelleKlienten);
            this.tabPageKlienten.ForeColor = System.Drawing.Color.Black;
            this.tabPageKlienten.Location = new System.Drawing.Point(4, 46);
            this.tabPageKlienten.Name = "tabPageKlienten";
            this.tabPageKlienten.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKlienten.Size = new System.Drawing.Size(1490, 685);
            this.tabPageKlienten.TabIndex = 1;
            this.tabPageKlienten.Text = "Klienten";
            this.tabPageKlienten.UseVisualStyleBackColor = true;
            // 
            // buttonExtiKlienten
            // 
            this.buttonExtiKlienten.BackColor = System.Drawing.Color.LightPink;
            this.buttonExtiKlienten.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.buttonExtiKlienten.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonExtiKlienten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExtiKlienten.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.buttonExtiKlienten.ForeColor = System.Drawing.Color.White;
            this.buttonExtiKlienten.Location = new System.Drawing.Point(1256, 607);
            this.buttonExtiKlienten.Name = "buttonExtiKlienten";
            this.buttonExtiKlienten.Size = new System.Drawing.Size(148, 52);
            this.buttonExtiKlienten.TabIndex = 56;
            this.buttonExtiKlienten.Text = "beenden";
            this.buttonExtiKlienten.UseVisualStyleBackColor = false;
            this.buttonExtiKlienten.Click += new System.EventHandler(this.buttonExtiKlienten_Click);
            // 
            // groupBoxKlienten
            // 
            this.groupBoxKlienten.Controls.Add(this.buttonLoeschenKlienten);
            this.groupBoxKlienten.Controls.Add(this.buttonAktualisierenKlienten);
            this.groupBoxKlienten.Controls.Add(this.buttonHinzufuegenKlienten);
            this.groupBoxKlienten.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxKlienten.Location = new System.Drawing.Point(304, 481);
            this.groupBoxKlienten.Name = "groupBoxKlienten";
            this.groupBoxKlienten.Size = new System.Drawing.Size(872, 178);
            this.groupBoxKlienten.TabIndex = 53;
            this.groupBoxKlienten.TabStop = false;
            this.groupBoxKlienten.Text = "Klientenverwaltung";
            // 
            // buttonLoeschenKlienten
            // 
            this.buttonLoeschenKlienten.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoeschenKlienten.ForeColor = System.Drawing.Color.Black;
            this.buttonLoeschenKlienten.Location = new System.Drawing.Point(582, 61);
            this.buttonLoeschenKlienten.Name = "buttonLoeschenKlienten";
            this.buttonLoeschenKlienten.Size = new System.Drawing.Size(242, 70);
            this.buttonLoeschenKlienten.TabIndex = 3;
            this.buttonLoeschenKlienten.Text = "Löschen";
            this.buttonLoeschenKlienten.UseVisualStyleBackColor = true;
            this.buttonLoeschenKlienten.Click += new System.EventHandler(this.buttonLoeschenKlienten_Click);
            // 
            // buttonAktualisierenKlienten
            // 
            this.buttonAktualisierenKlienten.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAktualisierenKlienten.ForeColor = System.Drawing.Color.Black;
            this.buttonAktualisierenKlienten.Location = new System.Drawing.Point(316, 61);
            this.buttonAktualisierenKlienten.Name = "buttonAktualisierenKlienten";
            this.buttonAktualisierenKlienten.Size = new System.Drawing.Size(242, 70);
            this.buttonAktualisierenKlienten.TabIndex = 2;
            this.buttonAktualisierenKlienten.Text = "Ändern";
            this.buttonAktualisierenKlienten.UseVisualStyleBackColor = true;
            this.buttonAktualisierenKlienten.Click += new System.EventHandler(this.buttonAktualisierenKlienten_Click);
            // 
            // buttonHinzufuegenKlienten
            // 
            this.buttonHinzufuegenKlienten.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHinzufuegenKlienten.ForeColor = System.Drawing.Color.Black;
            this.buttonHinzufuegenKlienten.Location = new System.Drawing.Point(48, 61);
            this.buttonHinzufuegenKlienten.Name = "buttonHinzufuegenKlienten";
            this.buttonHinzufuegenKlienten.Size = new System.Drawing.Size(242, 70);
            this.buttonHinzufuegenKlienten.TabIndex = 1;
            this.buttonHinzufuegenKlienten.Text = "Hinzufügen";
            this.buttonHinzufuegenKlienten.UseVisualStyleBackColor = true;
            this.buttonHinzufuegenKlienten.Click += new System.EventHandler(this.buttonHinzufuegenKlienten_Click);
            // 
            // labelAlleKlienten
            // 
            this.labelAlleKlienten.AutoSize = true;
            this.labelAlleKlienten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAlleKlienten.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlleKlienten.ForeColor = System.Drawing.Color.Black;
            this.labelAlleKlienten.Location = new System.Drawing.Point(499, 0);
            this.labelAlleKlienten.Name = "labelAlleKlienten";
            this.labelAlleKlienten.Size = new System.Drawing.Size(150, 32);
            this.labelAlleKlienten.TabIndex = 2;
            this.labelAlleKlienten.Text = "Alle Klienten";
            this.labelAlleKlienten.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // tabelleKlienten
            // 
            this.tabelleKlienten.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelleKlienten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabelleKlienten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelleKlienten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDKlienten,
            this.txtAnrede,
            this.txtName,
            this.txtVorname,
            this.txtStrasse,
            this.txtOrt,
            this.txtPLZ});
            this.tabelleKlienten.Location = new System.Drawing.Point(8, 41);
            this.tabelleKlienten.Name = "tabelleKlienten";
            this.tabelleKlienten.RowHeadersWidth = 62;
            this.tabelleKlienten.RowTemplate.Height = 28;
            this.tabelleKlienten.Size = new System.Drawing.Size(1474, 429);
            this.tabelleKlienten.TabIndex = 0;
            // 
            // IDKlienten
            // 
            this.IDKlienten.HeaderText = "ID";
            this.IDKlienten.MinimumWidth = 8;
            this.IDKlienten.Name = "IDKlienten";
            this.IDKlienten.Width = 150;
            // 
            // txtAnrede
            // 
            this.txtAnrede.HeaderText = "Anrede";
            this.txtAnrede.MinimumWidth = 8;
            this.txtAnrede.Name = "txtAnrede";
            this.txtAnrede.Width = 150;
            // 
            // txtName
            // 
            this.txtName.HeaderText = "Name";
            this.txtName.MinimumWidth = 8;
            this.txtName.Name = "txtName";
            this.txtName.Width = 150;
            // 
            // txtVorname
            // 
            this.txtVorname.HeaderText = "Vorname";
            this.txtVorname.MinimumWidth = 8;
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Width = 150;
            // 
            // txtStrasse
            // 
            this.txtStrasse.HeaderText = "Strasse";
            this.txtStrasse.MinimumWidth = 8;
            this.txtStrasse.Name = "txtStrasse";
            this.txtStrasse.Width = 150;
            // 
            // txtOrt
            // 
            this.txtOrt.HeaderText = "Ort";
            this.txtOrt.MinimumWidth = 8;
            this.txtOrt.Name = "txtOrt";
            this.txtOrt.Width = 150;
            // 
            // txtPLZ
            // 
            this.txtPLZ.HeaderText = "PLZ";
            this.txtPLZ.MinimumWidth = 8;
            this.txtPLZ.Name = "txtPLZ";
            this.txtPLZ.Width = 150;
            // 
            // tabPageMitarbeiter
            // 
            this.tabPageMitarbeiter.Controls.Add(this.groupBoxMitarbeiter);
            this.tabPageMitarbeiter.Controls.Add(this.buttonExitMitarbeiter);
            this.tabPageMitarbeiter.Controls.Add(this.labelAlleMitarbeiter);
            this.tabPageMitarbeiter.Controls.Add(this.tabelleMitarbeiter);
            this.tabPageMitarbeiter.ForeColor = System.Drawing.Color.Black;
            this.tabPageMitarbeiter.Location = new System.Drawing.Point(4, 46);
            this.tabPageMitarbeiter.Name = "tabPageMitarbeiter";
            this.tabPageMitarbeiter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMitarbeiter.Size = new System.Drawing.Size(1490, 685);
            this.tabPageMitarbeiter.TabIndex = 2;
            this.tabPageMitarbeiter.Text = "Mitarbeiter";
            this.tabPageMitarbeiter.UseVisualStyleBackColor = true;
            // 
            // groupBoxMitarbeiter
            // 
            this.groupBoxMitarbeiter.Controls.Add(this.buttonLoeschenMitarbeiter);
            this.groupBoxMitarbeiter.Controls.Add(this.buttonAktualisierenMitarbeiter);
            this.groupBoxMitarbeiter.Controls.Add(this.buttonHinzufuegenMitarbeiter);
            this.groupBoxMitarbeiter.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMitarbeiter.Location = new System.Drawing.Point(224, 468);
            this.groupBoxMitarbeiter.Name = "groupBoxMitarbeiter";
            this.groupBoxMitarbeiter.Size = new System.Drawing.Size(918, 184);
            this.groupBoxMitarbeiter.TabIndex = 57;
            this.groupBoxMitarbeiter.TabStop = false;
            this.groupBoxMitarbeiter.Text = "Personalverwaltung";
            // 
            // buttonLoeschenMitarbeiter
            // 
            this.buttonLoeschenMitarbeiter.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoeschenMitarbeiter.ForeColor = System.Drawing.Color.Black;
            this.buttonLoeschenMitarbeiter.Location = new System.Drawing.Point(625, 61);
            this.buttonLoeschenMitarbeiter.Name = "buttonLoeschenMitarbeiter";
            this.buttonLoeschenMitarbeiter.Size = new System.Drawing.Size(242, 70);
            this.buttonLoeschenMitarbeiter.TabIndex = 3;
            this.buttonLoeschenMitarbeiter.Text = "Löschen";
            this.buttonLoeschenMitarbeiter.UseVisualStyleBackColor = true;
            this.buttonLoeschenMitarbeiter.Click += new System.EventHandler(this.buttonLoeschenMitarbeiter_Click);
            // 
            // buttonAktualisierenMitarbeiter
            // 
            this.buttonAktualisierenMitarbeiter.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAktualisierenMitarbeiter.ForeColor = System.Drawing.Color.Black;
            this.buttonAktualisierenMitarbeiter.Location = new System.Drawing.Point(334, 61);
            this.buttonAktualisierenMitarbeiter.Name = "buttonAktualisierenMitarbeiter";
            this.buttonAktualisierenMitarbeiter.Size = new System.Drawing.Size(242, 70);
            this.buttonAktualisierenMitarbeiter.TabIndex = 2;
            this.buttonAktualisierenMitarbeiter.Text = "Ändern";
            this.buttonAktualisierenMitarbeiter.UseVisualStyleBackColor = true;
            this.buttonAktualisierenMitarbeiter.Click += new System.EventHandler(this.buttonAktualisierenMitarbeiter_Click);
            // 
            // buttonHinzufuegenMitarbeiter
            // 
            this.buttonHinzufuegenMitarbeiter.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHinzufuegenMitarbeiter.ForeColor = System.Drawing.Color.Black;
            this.buttonHinzufuegenMitarbeiter.Location = new System.Drawing.Point(48, 61);
            this.buttonHinzufuegenMitarbeiter.Name = "buttonHinzufuegenMitarbeiter";
            this.buttonHinzufuegenMitarbeiter.Size = new System.Drawing.Size(242, 70);
            this.buttonHinzufuegenMitarbeiter.TabIndex = 1;
            this.buttonHinzufuegenMitarbeiter.Text = "Hinzufügen";
            this.buttonHinzufuegenMitarbeiter.UseVisualStyleBackColor = true;
            this.buttonHinzufuegenMitarbeiter.Click += new System.EventHandler(this.buttonHinzufuegenMitarbeiter_Click);
            // 
            // buttonExitMitarbeiter
            // 
            this.buttonExitMitarbeiter.BackColor = System.Drawing.Color.LightPink;
            this.buttonExitMitarbeiter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.buttonExitMitarbeiter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonExitMitarbeiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitMitarbeiter.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.buttonExitMitarbeiter.ForeColor = System.Drawing.Color.White;
            this.buttonExitMitarbeiter.Location = new System.Drawing.Point(1277, 615);
            this.buttonExitMitarbeiter.Name = "buttonExitMitarbeiter";
            this.buttonExitMitarbeiter.Size = new System.Drawing.Size(148, 51);
            this.buttonExitMitarbeiter.TabIndex = 56;
            this.buttonExitMitarbeiter.Text = "beenden";
            this.buttonExitMitarbeiter.UseVisualStyleBackColor = false;
            this.buttonExitMitarbeiter.Click += new System.EventHandler(this.buttonExitMitarbeiter_Click);
            // 
            // labelAlleMitarbeiter
            // 
            this.labelAlleMitarbeiter.AutoSize = true;
            this.labelAlleMitarbeiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAlleMitarbeiter.ForeColor = System.Drawing.Color.Black;
            this.labelAlleMitarbeiter.Location = new System.Drawing.Point(414, 20);
            this.labelAlleMitarbeiter.Name = "labelAlleMitarbeiter";
            this.labelAlleMitarbeiter.Size = new System.Drawing.Size(201, 37);
            this.labelAlleMitarbeiter.TabIndex = 2;
            this.labelAlleMitarbeiter.Text = "Alle Mitarbeiter";
            // 
            // tabelleMitarbeiter
            // 
            this.tabelleMitarbeiter.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelleMitarbeiter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabelleMitarbeiter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelleMitarbeiter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMitarbeiter,
            this.txtAnredeMitarbeiter,
            this.txtTitel,
            this.txtNameMitarbeiter,
            this.txtVornameMitarbeiter,
            this.txtTelefon,
            this.IDFunktion,
            this.txtStrasseMitarbeiter,
            this.txtOrtMitarbeiter,
            this.txtPLZMitarbeiter});
            this.tabelleMitarbeiter.Location = new System.Drawing.Point(8, 68);
            this.tabelleMitarbeiter.Name = "tabelleMitarbeiter";
            this.tabelleMitarbeiter.RowHeadersWidth = 62;
            this.tabelleMitarbeiter.RowTemplate.Height = 28;
            this.tabelleMitarbeiter.Size = new System.Drawing.Size(1477, 372);
            this.tabelleMitarbeiter.TabIndex = 0;
            // 
            // IDMitarbeiter
            // 
            this.IDMitarbeiter.HeaderText = "Personalnummer";
            this.IDMitarbeiter.MinimumWidth = 8;
            this.IDMitarbeiter.Name = "IDMitarbeiter";
            this.IDMitarbeiter.Width = 150;
            // 
            // txtAnredeMitarbeiter
            // 
            this.txtAnredeMitarbeiter.HeaderText = "Anrede";
            this.txtAnredeMitarbeiter.MinimumWidth = 8;
            this.txtAnredeMitarbeiter.Name = "txtAnredeMitarbeiter";
            this.txtAnredeMitarbeiter.Width = 150;
            // 
            // txtTitel
            // 
            this.txtTitel.HeaderText = "Titel";
            this.txtTitel.MinimumWidth = 8;
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Width = 150;
            // 
            // txtNameMitarbeiter
            // 
            this.txtNameMitarbeiter.HeaderText = "Name";
            this.txtNameMitarbeiter.MinimumWidth = 8;
            this.txtNameMitarbeiter.Name = "txtNameMitarbeiter";
            this.txtNameMitarbeiter.Width = 150;
            // 
            // txtVornameMitarbeiter
            // 
            this.txtVornameMitarbeiter.HeaderText = "Vorname";
            this.txtVornameMitarbeiter.MinimumWidth = 8;
            this.txtVornameMitarbeiter.Name = "txtVornameMitarbeiter";
            this.txtVornameMitarbeiter.Width = 150;
            // 
            // txtTelefon
            // 
            this.txtTelefon.HeaderText = "Telefon";
            this.txtTelefon.MinimumWidth = 8;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Width = 150;
            // 
            // IDFunktion
            // 
            this.IDFunktion.HeaderText = "Funktion";
            this.IDFunktion.MinimumWidth = 8;
            this.IDFunktion.Name = "IDFunktion";
            this.IDFunktion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IDFunktion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IDFunktion.Width = 150;
            // 
            // txtStrasseMitarbeiter
            // 
            this.txtStrasseMitarbeiter.HeaderText = "Strasse";
            this.txtStrasseMitarbeiter.MinimumWidth = 8;
            this.txtStrasseMitarbeiter.Name = "txtStrasseMitarbeiter";
            this.txtStrasseMitarbeiter.Width = 150;
            // 
            // txtOrtMitarbeiter
            // 
            this.txtOrtMitarbeiter.HeaderText = "Ort";
            this.txtOrtMitarbeiter.MinimumWidth = 8;
            this.txtOrtMitarbeiter.Name = "txtOrtMitarbeiter";
            this.txtOrtMitarbeiter.Width = 150;
            // 
            // txtPLZMitarbeiter
            // 
            this.txtPLZMitarbeiter.HeaderText = "PLZ";
            this.txtPLZMitarbeiter.MinimumWidth = 8;
            this.txtPLZMitarbeiter.Name = "txtPLZMitarbeiter";
            this.txtPLZMitarbeiter.Width = 150;
            // 
            // tabPageRaum
            // 
            this.tabPageRaum.Controls.Add(this.groupBoxRaum);
            this.tabPageRaum.Controls.Add(this.buttonExitRaum);
            this.tabPageRaum.Controls.Add(this.labelRaum);
            this.tabPageRaum.Controls.Add(this.tabelleRaum);
            this.tabPageRaum.ForeColor = System.Drawing.Color.Black;
            this.tabPageRaum.Location = new System.Drawing.Point(4, 46);
            this.tabPageRaum.Name = "tabPageRaum";
            this.tabPageRaum.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRaum.Size = new System.Drawing.Size(1490, 685);
            this.tabPageRaum.TabIndex = 3;
            this.tabPageRaum.Text = "Räume";
            this.tabPageRaum.UseVisualStyleBackColor = true;
            this.tabPageRaum.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBoxRaum
            // 
            this.groupBoxRaum.Controls.Add(this.buttonLoeschenRaum);
            this.groupBoxRaum.Controls.Add(this.buttonAktualisierenRaum);
            this.groupBoxRaum.Controls.Add(this.buttonHinzufuegenRaum);
            this.groupBoxRaum.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRaum.Location = new System.Drawing.Point(220, 473);
            this.groupBoxRaum.Name = "groupBoxRaum";
            this.groupBoxRaum.Size = new System.Drawing.Size(918, 185);
            this.groupBoxRaum.TabIndex = 68;
            this.groupBoxRaum.TabStop = false;
            this.groupBoxRaum.Text = "Raumverwaltung";
            // 
            // buttonLoeschenRaum
            // 
            this.buttonLoeschenRaum.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoeschenRaum.ForeColor = System.Drawing.Color.Black;
            this.buttonLoeschenRaum.Location = new System.Drawing.Point(629, 61);
            this.buttonLoeschenRaum.Name = "buttonLoeschenRaum";
            this.buttonLoeschenRaum.Size = new System.Drawing.Size(242, 70);
            this.buttonLoeschenRaum.TabIndex = 3;
            this.buttonLoeschenRaum.Text = "Löschen";
            this.buttonLoeschenRaum.UseVisualStyleBackColor = true;
            this.buttonLoeschenRaum.Click += new System.EventHandler(this.buttonLoeschenRaum_Click);
            // 
            // buttonAktualisierenRaum
            // 
            this.buttonAktualisierenRaum.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAktualisierenRaum.ForeColor = System.Drawing.Color.Black;
            this.buttonAktualisierenRaum.Location = new System.Drawing.Point(337, 61);
            this.buttonAktualisierenRaum.Name = "buttonAktualisierenRaum";
            this.buttonAktualisierenRaum.Size = new System.Drawing.Size(242, 70);
            this.buttonAktualisierenRaum.TabIndex = 2;
            this.buttonAktualisierenRaum.Text = "Ändern";
            this.buttonAktualisierenRaum.UseVisualStyleBackColor = true;
            this.buttonAktualisierenRaum.Click += new System.EventHandler(this.buttonAktualisierenRaum_Click);
            // 
            // buttonHinzufuegenRaum
            // 
            this.buttonHinzufuegenRaum.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHinzufuegenRaum.ForeColor = System.Drawing.Color.Black;
            this.buttonHinzufuegenRaum.Location = new System.Drawing.Point(48, 61);
            this.buttonHinzufuegenRaum.Name = "buttonHinzufuegenRaum";
            this.buttonHinzufuegenRaum.Size = new System.Drawing.Size(242, 70);
            this.buttonHinzufuegenRaum.TabIndex = 1;
            this.buttonHinzufuegenRaum.Text = "Hinzufügen";
            this.buttonHinzufuegenRaum.UseVisualStyleBackColor = true;
            this.buttonHinzufuegenRaum.Click += new System.EventHandler(this.buttonHinzufuegenRaum_Click);
            // 
            // buttonExitRaum
            // 
            this.buttonExitRaum.BackColor = System.Drawing.Color.LightPink;
            this.buttonExitRaum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.buttonExitRaum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonExitRaum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitRaum.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.buttonExitRaum.ForeColor = System.Drawing.Color.White;
            this.buttonExitRaum.Location = new System.Drawing.Point(1281, 606);
            this.buttonExitRaum.Name = "buttonExitRaum";
            this.buttonExitRaum.Size = new System.Drawing.Size(148, 52);
            this.buttonExitRaum.TabIndex = 67;
            this.buttonExitRaum.Text = "beenden";
            this.buttonExitRaum.UseVisualStyleBackColor = false;
            this.buttonExitRaum.Click += new System.EventHandler(this.buttonExitRaum_Click);
            // 
            // labelRaum
            // 
            this.labelRaum.AutoSize = true;
            this.labelRaum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRaum.ForeColor = System.Drawing.Color.Black;
            this.labelRaum.Location = new System.Drawing.Point(434, 3);
            this.labelRaum.Name = "labelRaum";
            this.labelRaum.Size = new System.Drawing.Size(151, 37);
            this.labelRaum.TabIndex = 54;
            this.labelRaum.Text = "Alle Räume";
            // 
            // tabelleRaum
            // 
            this.tabelleRaum.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelleRaum.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tabelleRaum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelleRaum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDRaum,
            this.txtSitzungsart,
            this.ingPlatzzahl});
            this.tabelleRaum.Location = new System.Drawing.Point(26, 48);
            this.tabelleRaum.Name = "tabelleRaum";
            this.tabelleRaum.RowHeadersWidth = 62;
            this.tabelleRaum.RowTemplate.Height = 56;
            this.tabelleRaum.Size = new System.Drawing.Size(1438, 397);
            this.tabelleRaum.TabIndex = 53;
            // 
            // IDRaum
            // 
            this.IDRaum.HeaderText = "Nummer";
            this.IDRaum.MinimumWidth = 8;
            this.IDRaum.Name = "IDRaum";
            this.IDRaum.Width = 150;
            // 
            // txtSitzungsart
            // 
            this.txtSitzungsart.HeaderText = "Sitzung";
            this.txtSitzungsart.MinimumWidth = 8;
            this.txtSitzungsart.Name = "txtSitzungsart";
            this.txtSitzungsart.Width = 150;
            // 
            // ingPlatzzahl
            // 
            this.ingPlatzzahl.HeaderText = "Platzzahl";
            this.ingPlatzzahl.MinimumWidth = 8;
            this.ingPlatzzahl.Name = "ingPlatzzahl";
            this.ingPlatzzahl.Width = 150;
            // 
            // info1
            // 
            this.info1.BackColor = System.Drawing.Color.White;
            this.info1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info1.ForeColor = System.Drawing.Color.Black;
            this.info1.Location = new System.Drawing.Point(0, 0);
            this.info1.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(1026, 634);
            this.info1.TabIndex = 3;
            // 
            // kalender1
            // 
            this.kalender1.BackColor = System.Drawing.Color.White;
            this.kalender1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kalender1.Location = new System.Drawing.Point(0, 0);
            this.kalender1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.kalender1.Name = "kalender1";
            this.kalender1.Size = new System.Drawing.Size(1026, 634);
            this.kalender1.TabIndex = 2;
            // 
            // AnwaltsKanzleiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1498, 735);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "AnwaltsKanzleiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anwaltskanzlei";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnwaltsKanzleiForm_FormClosing);
            this.Load += new System.EventHandler(this.AnwaltsKanzleiForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageTermine.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.tabPageKlienten.ResumeLayout(false);
            this.tabPageKlienten.PerformLayout();
            this.groupBoxKlienten.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelleKlienten)).EndInit();
            this.tabPageMitarbeiter.ResumeLayout(false);
            this.tabPageMitarbeiter.PerformLayout();
            this.groupBoxMitarbeiter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelleMitarbeiter)).EndInit();
            this.tabPageRaum.ResumeLayout(false);
            this.tabPageRaum.PerformLayout();
            this.groupBoxRaum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelleRaum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageTermine;
        private System.Windows.Forms.Label labelKlienten;
        private System.Windows.Forms.Label labelAktenzeichen;
        private System.Windows.Forms.TabPage tabPageKlienten;
        private System.Windows.Forms.TabPage tabPageMitarbeiter;
        private System.Windows.Forms.ComboBox dropDownAktenzeichen;
        private System.Windows.Forms.ComboBox dropDownKlienten;
        private System.Windows.Forms.DataGridView tabelleKlienten;
        private System.Windows.Forms.DataGridView tabelleMitarbeiter;
        private System.Windows.Forms.Label labelAlleKlienten;
        private System.Windows.Forms.Label labelAlleMitarbeiter;
        private System.Windows.Forms.TabPage tabPageRaum;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label labelRaum;
        private System.Windows.Forms.DataGridView tabelleRaum;
        private Kalender kalender1;
        private Info info1;
        private System.Windows.Forms.GroupBox groupBoxKlienten;
        private System.Windows.Forms.Button buttonLoeschenKlienten;
        private System.Windows.Forms.Button buttonAktualisierenKlienten;
        private System.Windows.Forms.Button buttonHinzufuegenKlienten;
        private System.Windows.Forms.Button buttonExitTermine;
        private System.Windows.Forms.Button buttonExtiKlienten;
        private System.Windows.Forms.Button buttonExitMitarbeiter;
        private System.Windows.Forms.Button buttonExitRaum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxMitarbeiter;
        private System.Windows.Forms.Button buttonLoeschenMitarbeiter;
        private System.Windows.Forms.Button buttonAktualisierenMitarbeiter;
        private System.Windows.Forms.Button buttonHinzufuegenMitarbeiter;
        private System.Windows.Forms.GroupBox groupBoxRaum;
        private System.Windows.Forms.Button buttonLoeschenRaum;
        private System.Windows.Forms.Button buttonAktualisierenRaum;
        private System.Windows.Forms.Button buttonHinzufuegenRaum;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRaum;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSitzungsart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingPlatzzahl;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMitarbeiter;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAnredeMitarbeiter;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTitel;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNameMitarbeiter;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtVornameMitarbeiter;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTelefon;
        private System.Windows.Forms.DataGridViewComboBoxColumn IDFunktion;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtStrasseMitarbeiter;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtOrtMitarbeiter;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPLZMitarbeiter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDKlienten;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAnrede;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtVorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtStrasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtOrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPLZ;
    }
}

