namespace AnwaltsKanzleiUI
{
    partial class Termine
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
            this.labelTerminHinzufuegen = new System.Windows.Forms.Label();
            this.labelBis = new System.Windows.Forms.Label();
            this.labelVon = new System.Windows.Forms.Label();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.labelTermine = new System.Windows.Forms.Label();
            this.tabelleTermine = new System.Windows.Forms.DataGridView();
            this.datVon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datBis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAktenzeichen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtKlient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDRaum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabelleRaumbelegung = new System.Windows.Forms.DataGridView();
            this.txtVonRaum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBisRaum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingRaum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSitzungsart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingPlatzzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelRaumbelegung = new System.Windows.Forms.Label();
            this.dateTimeVon = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBis = new System.Windows.Forms.DateTimePicker();
            this.labelRaum = new System.Windows.Forms.Label();
            this.comboBoxRaum = new System.Windows.Forms.ComboBox();
            this.labelPlatzhalter = new System.Windows.Forms.Label();
            this.labelPlatzhalterDaten = new System.Windows.Forms.Label();
            this.buttonAllesSchließen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabelleTermine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelleRaumbelegung)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTerminHinzufuegen
            // 
            this.labelTerminHinzufuegen.AutoSize = true;
            this.labelTerminHinzufuegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTerminHinzufuegen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTerminHinzufuegen.ForeColor = System.Drawing.Color.Black;
            this.labelTerminHinzufuegen.Location = new System.Drawing.Point(20, 589);
            this.labelTerminHinzufuegen.Name = "labelTerminHinzufuegen";
            this.labelTerminHinzufuegen.Size = new System.Drawing.Size(222, 32);
            this.labelTerminHinzufuegen.TabIndex = 66;
            this.labelTerminHinzufuegen.Text = "Termin hinzufügen:";
            // 
            // labelBis
            // 
            this.labelBis.AutoSize = true;
            this.labelBis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBis.ForeColor = System.Drawing.Color.Black;
            this.labelBis.Location = new System.Drawing.Point(310, 643);
            this.labelBis.Name = "labelBis";
            this.labelBis.Size = new System.Drawing.Size(50, 32);
            this.labelBis.TabIndex = 62;
            this.labelBis.Text = "Bis:";
            // 
            // labelVon
            // 
            this.labelVon.AutoSize = true;
            this.labelVon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelVon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVon.ForeColor = System.Drawing.Color.Black;
            this.labelVon.Location = new System.Drawing.Point(299, 595);
            this.labelVon.Name = "labelVon";
            this.labelVon.Size = new System.Drawing.Size(61, 32);
            this.labelVon.TabIndex = 61;
            this.labelVon.Text = "Von:";
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.BackColor = System.Drawing.Color.LightGreen;
            this.buttonSpeichern.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonSpeichern.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.buttonSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpeichern.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.buttonSpeichern.ForeColor = System.Drawing.Color.White;
            this.buttonSpeichern.Location = new System.Drawing.Point(1239, 580);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(230, 52);
            this.buttonSpeichern.TabIndex = 60;
            this.buttonSpeichern.Text = "speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = false;
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // labelTermine
            // 
            this.labelTermine.AutoSize = true;
            this.labelTermine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTermine.ForeColor = System.Drawing.Color.Black;
            this.labelTermine.Location = new System.Drawing.Point(249, 129);
            this.labelTermine.Name = "labelTermine";
            this.labelTermine.Size = new System.Drawing.Size(116, 38);
            this.labelTermine.TabIndex = 54;
            this.labelTermine.Text = "Termine";
            // 
            // tabelleTermine
            // 
            this.tabelleTermine.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabelleTermine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelleTermine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datVon,
            this.datBis,
            this.txtAktenzeichen,
            this.txtKlient,
            this.IDRaum});
            this.tabelleTermine.Location = new System.Drawing.Point(6, 164);
            this.tabelleTermine.Name = "tabelleTermine";
            this.tabelleTermine.RowHeadersWidth = 62;
            this.tabelleTermine.RowTemplate.Height = 28;
            this.tabelleTermine.Size = new System.Drawing.Size(718, 397);
            this.tabelleTermine.TabIndex = 53;
            // 
            // datVon
            // 
            this.datVon.HeaderText = "Von";
            this.datVon.MinimumWidth = 6;
            this.datVon.Name = "datVon";
            this.datVon.Width = 125;
            // 
            // datBis
            // 
            this.datBis.HeaderText = "Bis";
            this.datBis.MinimumWidth = 6;
            this.datBis.Name = "datBis";
            this.datBis.Width = 125;
            // 
            // txtAktenzeichen
            // 
            this.txtAktenzeichen.HeaderText = "Aktenzeichen";
            this.txtAktenzeichen.MinimumWidth = 6;
            this.txtAktenzeichen.Name = "txtAktenzeichen";
            this.txtAktenzeichen.Width = 125;
            // 
            // txtKlient
            // 
            this.txtKlient.HeaderText = "Klient";
            this.txtKlient.MinimumWidth = 6;
            this.txtKlient.Name = "txtKlient";
            this.txtKlient.Width = 125;
            // 
            // IDRaum
            // 
            this.IDRaum.HeaderText = "Raum";
            this.IDRaum.MinimumWidth = 6;
            this.IDRaum.Name = "IDRaum";
            this.IDRaum.Width = 125;
            // 
            // tabelleRaumbelegung
            // 
            this.tabelleRaumbelegung.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabelleRaumbelegung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelleRaumbelegung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtVonRaum,
            this.txtBisRaum,
            this.ingRaum,
            this.txtSitzungsart,
            this.ingPlatzzahl});
            this.tabelleRaumbelegung.Location = new System.Drawing.Point(751, 164);
            this.tabelleRaumbelegung.Name = "tabelleRaumbelegung";
            this.tabelleRaumbelegung.RowHeadersWidth = 62;
            this.tabelleRaumbelegung.RowTemplate.Height = 28;
            this.tabelleRaumbelegung.Size = new System.Drawing.Size(718, 397);
            this.tabelleRaumbelegung.TabIndex = 67;
            // 
            // txtVonRaum
            // 
            this.txtVonRaum.HeaderText = "Von";
            this.txtVonRaum.MinimumWidth = 6;
            this.txtVonRaum.Name = "txtVonRaum";
            this.txtVonRaum.Width = 125;
            // 
            // txtBisRaum
            // 
            this.txtBisRaum.HeaderText = "Bis";
            this.txtBisRaum.MinimumWidth = 6;
            this.txtBisRaum.Name = "txtBisRaum";
            this.txtBisRaum.Width = 125;
            // 
            // ingRaum
            // 
            this.ingRaum.HeaderText = "Raum";
            this.ingRaum.MinimumWidth = 6;
            this.ingRaum.Name = "ingRaum";
            this.ingRaum.Width = 125;
            // 
            // txtSitzungsart
            // 
            this.txtSitzungsart.HeaderText = "Sitzungsart";
            this.txtSitzungsart.MinimumWidth = 6;
            this.txtSitzungsart.Name = "txtSitzungsart";
            this.txtSitzungsart.Width = 125;
            // 
            // ingPlatzzahl
            // 
            this.ingPlatzzahl.HeaderText = "Platzzahl";
            this.ingPlatzzahl.MinimumWidth = 6;
            this.ingPlatzzahl.Name = "ingPlatzzahl";
            this.ingPlatzzahl.Width = 125;
            // 
            // labelRaumbelegung
            // 
            this.labelRaumbelegung.AutoSize = true;
            this.labelRaumbelegung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRaumbelegung.ForeColor = System.Drawing.Color.Black;
            this.labelRaumbelegung.Location = new System.Drawing.Point(1037, 129);
            this.labelRaumbelegung.Name = "labelRaumbelegung";
            this.labelRaumbelegung.Size = new System.Drawing.Size(205, 38);
            this.labelRaumbelegung.TabIndex = 68;
            this.labelRaumbelegung.Text = "Raumbelegung";
            // 
            // dateTimeVon
            // 
            this.dateTimeVon.CustomFormat = "HH:mm";
            this.dateTimeVon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeVon.Location = new System.Drawing.Point(401, 582);
            this.dateTimeVon.Name = "dateTimeVon";
            this.dateTimeVon.Size = new System.Drawing.Size(114, 45);
            this.dateTimeVon.TabIndex = 69;
            this.dateTimeVon.ValueChanged += new System.EventHandler(this.dateTimeVon_ValueChanged);
            // 
            // dateTimeBis
            // 
            this.dateTimeBis.CustomFormat = "HH:mm";
            this.dateTimeBis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeBis.Location = new System.Drawing.Point(401, 633);
            this.dateTimeBis.Name = "dateTimeBis";
            this.dateTimeBis.Size = new System.Drawing.Size(114, 45);
            this.dateTimeBis.TabIndex = 70;
            this.dateTimeBis.ValueChanged += new System.EventHandler(this.dateTimeVon_ValueChanged);
            // 
            // labelRaum
            // 
            this.labelRaum.AutoSize = true;
            this.labelRaum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRaum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRaum.ForeColor = System.Drawing.Color.Black;
            this.labelRaum.Location = new System.Drawing.Point(765, 592);
            this.labelRaum.Name = "labelRaum";
            this.labelRaum.Size = new System.Drawing.Size(81, 32);
            this.labelRaum.TabIndex = 71;
            this.labelRaum.Text = "Raum:";
            // 
            // comboBoxRaum
            // 
            this.comboBoxRaum.FormattingEnabled = true;
            this.comboBoxRaum.Location = new System.Drawing.Point(881, 581);
            this.comboBoxRaum.Name = "comboBoxRaum";
            this.comboBoxRaum.Size = new System.Drawing.Size(343, 46);
            this.comboBoxRaum.TabIndex = 72;
            // 
            // labelPlatzhalter
            // 
            this.labelPlatzhalter.AutoSize = true;
            this.labelPlatzhalter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPlatzhalter.ForeColor = System.Drawing.Color.Black;
            this.labelPlatzhalter.Location = new System.Drawing.Point(5, 9);
            this.labelPlatzhalter.Name = "labelPlatzhalter";
            this.labelPlatzhalter.Size = new System.Drawing.Size(153, 38);
            this.labelPlatzhalter.TabIndex = 73;
            this.labelPlatzhalter.Text = "Platzhalter:";
            // 
            // labelPlatzhalterDaten
            // 
            this.labelPlatzhalterDaten.AutoSize = true;
            this.labelPlatzhalterDaten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPlatzhalterDaten.ForeColor = System.Drawing.Color.Black;
            this.labelPlatzhalterDaten.Location = new System.Drawing.Point(171, 9);
            this.labelPlatzhalterDaten.Name = "labelPlatzhalterDaten";
            this.labelPlatzhalterDaten.Size = new System.Drawing.Size(185, 38);
            this.labelPlatzhalterDaten.TabIndex = 74;
            this.labelPlatzhalterDaten.Text = "<Platzhalter>";
            // 
            // buttonAllesSchließen
            // 
            this.buttonAllesSchließen.BackColor = System.Drawing.Color.LightPink;
            this.buttonAllesSchließen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.buttonAllesSchließen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonAllesSchließen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllesSchließen.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.buttonAllesSchließen.ForeColor = System.Drawing.Color.White;
            this.buttonAllesSchließen.Location = new System.Drawing.Point(1239, 642);
            this.buttonAllesSchließen.Name = "buttonAllesSchließen";
            this.buttonAllesSchließen.Size = new System.Drawing.Size(230, 52);
            this.buttonAllesSchließen.TabIndex = 75;
            this.buttonAllesSchließen.Text = "Programm beenden";
            this.buttonAllesSchließen.UseVisualStyleBackColor = false;
            this.buttonAllesSchließen.Click += new System.EventHandler(this.buttonAllesSchließen_Click);
            // 
            // Termine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1481, 706);
            this.Controls.Add(this.buttonAllesSchließen);
            this.Controls.Add(this.labelPlatzhalterDaten);
            this.Controls.Add(this.labelPlatzhalter);
            this.Controls.Add(this.comboBoxRaum);
            this.Controls.Add(this.labelRaum);
            this.Controls.Add(this.dateTimeBis);
            this.Controls.Add(this.dateTimeVon);
            this.Controls.Add(this.labelRaumbelegung);
            this.Controls.Add(this.tabelleRaumbelegung);
            this.Controls.Add(this.labelTerminHinzufuegen);
            this.Controls.Add(this.labelBis);
            this.Controls.Add(this.labelVon);
            this.Controls.Add(this.buttonSpeichern);
            this.Controls.Add(this.labelTermine);
            this.Controls.Add(this.tabelleTermine);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Termine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anwaltskanzlei - Termine";
            ((System.ComponentModel.ISupportInitialize)(this.tabelleTermine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelleRaumbelegung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTerminHinzufuegen;
        private System.Windows.Forms.Label labelBis;
        private System.Windows.Forms.Label labelVon;
        private System.Windows.Forms.Button buttonSpeichern;
        private System.Windows.Forms.Label labelTermine;
        private System.Windows.Forms.DataGridView tabelleTermine;
        private System.Windows.Forms.DataGridView tabelleRaumbelegung;
        private System.Windows.Forms.Label labelRaumbelegung;
        private System.Windows.Forms.DateTimePicker dateTimeVon;
        private System.Windows.Forms.DateTimePicker dateTimeBis;
        private System.Windows.Forms.Label labelRaum;
        private System.Windows.Forms.ComboBox comboBoxRaum;
        private System.Windows.Forms.Label labelPlatzhalter;
        private System.Windows.Forms.Label labelPlatzhalterDaten;
        private System.Windows.Forms.Button buttonAllesSchließen;
        private System.Windows.Forms.DataGridViewTextBoxColumn datVon;
        private System.Windows.Forms.DataGridViewTextBoxColumn datBis;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAktenzeichen;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtKlient;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRaum;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtVonRaum;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBisRaum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingRaum;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSitzungsart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingPlatzzahl;
    }
}