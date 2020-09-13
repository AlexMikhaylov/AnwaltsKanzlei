namespace AnwaltsKanzleiUI
{
    partial class Kalender
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelDatum = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBoxTermin = new System.Windows.Forms.GroupBox();
            this.labelPlatzhalterDaten = new System.Windows.Forms.Label();
            this.labelBezeichnungen = new System.Windows.Forms.Label();
            this.groupBoxTermin.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCheck
            // 
            this.buttonCheck.AutoSize = true;
            this.buttonCheck.BackColor = System.Drawing.Color.LightGreen;
            this.buttonCheck.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.buttonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheck.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheck.ForeColor = System.Drawing.Color.White;
            this.buttonCheck.Location = new System.Drawing.Point(0, 601);
            this.buttonCheck.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(956, 61);
            this.buttonCheck.TabIndex = 9;
            this.buttonCheck.Text = "Die Auswahl bestätigen und Termine prüfen";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDatum.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatum.ForeColor = System.Drawing.Color.Black;
            this.labelDatum.Location = new System.Drawing.Point(0, 0);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(407, 38);
            this.labelDatum.TabIndex = 8;
            this.labelDatum.Text = "Bitte wählen Sie ein Datum aus:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.monthCalendar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.monthCalendar1.Location = new System.Drawing.Point(0, 38);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // groupBoxTermin
            // 
            this.groupBoxTermin.Controls.Add(this.labelPlatzhalterDaten);
            this.groupBoxTermin.Controls.Add(this.labelBezeichnungen);
            this.groupBoxTermin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxTermin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTermin.Location = new System.Drawing.Point(0, 460);
            this.groupBoxTermin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxTermin.Name = "groupBoxTermin";
            this.groupBoxTermin.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxTermin.Size = new System.Drawing.Size(956, 141);
            this.groupBoxTermin.TabIndex = 11;
            this.groupBoxTermin.TabStop = false;
            this.groupBoxTermin.Text = "Folgende Daten wurden von Ihnen ausgewählt:";
            // 
            // labelPlatzhalterDaten
            // 
            this.labelPlatzhalterDaten.AutoSize = true;
            this.labelPlatzhalterDaten.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelPlatzhalterDaten.Location = new System.Drawing.Point(129, 36);
            this.labelPlatzhalterDaten.Name = "labelPlatzhalterDaten";
            this.labelPlatzhalterDaten.Size = new System.Drawing.Size(190, 32);
            this.labelPlatzhalterDaten.TabIndex = 1;
            this.labelPlatzhalterDaten.Text = "PlatzhalterDaten";
            // 
            // labelBezeichnungen
            // 
            this.labelBezeichnungen.AutoSize = true;
            this.labelBezeichnungen.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelBezeichnungen.Location = new System.Drawing.Point(3, 36);
            this.labelBezeichnungen.Name = "labelBezeichnungen";
            this.labelBezeichnungen.Size = new System.Drawing.Size(126, 32);
            this.labelBezeichnungen.TabIndex = 0;
            this.labelBezeichnungen.Text = "Platzhalter";
            // 
            // Kalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBoxTermin);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.labelDatum);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Kalender";
            this.Size = new System.Drawing.Size(956, 662);
            this.groupBoxTermin.ResumeLayout(false);
            this.groupBoxTermin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBoxTermin;
        private System.Windows.Forms.Label labelBezeichnungen;
        private System.Windows.Forms.Label labelPlatzhalterDaten;
    }
}
