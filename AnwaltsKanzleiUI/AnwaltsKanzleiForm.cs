using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Reflection;
using AnwaltsKanzleiLibrary;

namespace AnwaltsKanzleiUI
{
    /// <summary>
    /// Hauptform: Hier werden alle Tabs bereitgestellt und die Daten in die DateGridView-Tabellen aus der Datenbank geschrieben
    /// </summary>
    public partial class AnwaltsKanzleiForm : Form
    {
        //Sammlungen von Klassenobjekten deklarieren. Diese werden dann mit einzelnen Instanzen aus der Datenbank gefüllt
        private Dictionary<int, Klient> klienten = new Dictionary<int, Klient>();
        private Dictionary<int, Mitarbeiter> mitarbeiter = new Dictionary<int, Mitarbeiter>();
        private Dictionary<string, Aktenzeichen> aktenzeichen = new Dictionary<string, Aktenzeichen>();
        private Dictionary<int, Raum> raeume = new Dictionary<int, Raum>();


        public AnwaltsKanzleiForm()
        {
            InitializeComponent();
            
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Klienten, Mitarbeiter und Räume in die jeweiligen Tabellen des Programms aus der Datenbank laden und die Sammlungen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnwaltsKanzleiForm_Load(object sender, EventArgs e)
        {
            try
            {
                //Verindung eröffnen
                // Verbindung zur DB herstellen
                OleDbConnection dbConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AnwaltskanzleiDB.mdb");
                

                // Verbindung zur DB herstellen
                dbConnection.Open();

                //Abfrage senden
                string queryKlienten = "SELECT * FROM (tblKlienten INNER JOIN tblAdressen ON tblKlienten.IDAdresse = tblAdressen.IDAdresse) ORDER BY IDKlienten";

                string queryMitarbeiter = "SELECT * FROM (tblMitarbeiter INNER JOIN tblAdressen ON tblMitarbeiter.IDAdresse = tblAdressen.IDAdresse) " +
                                            "INNER JOIN tblFunktionen ON tblMitarbeiter.IDFunktion = tblFunktionen.IDFunktion";

                string queryRaum = "SELECT * FROM tblRaeume";

                //Spalte "Funktion" im DataGridView an 
                OleDbDataAdapter adapterFunktionen = new OleDbDataAdapter("SELECT * FROM tblFunktionen", dbConnection);
                DataSet ds = new DataSet();
                adapterFunktionen.Fill(ds);
                DataGridViewComboBoxColumn funktion = (DataGridViewComboBoxColumn)tabelleMitarbeiter.Columns[6];
                funktion.DataSource = ds.Tables[0];
                funktion.DisplayMember = "txtFBezeichnung";
                funktion.ValueMember = "IDFunktion";

                //Abfrage machen und die Daten speichern
                string queryAktenzeichen = "SELECT * FROM tblAktenzeichen ORDER BY IDAktenzeichen";
                OleDbDataAdapter adapterAktenzeichen = new OleDbDataAdapter(queryAktenzeichen, dbConnection);
                DataSet dsAktenzeichen = new DataSet();
                adapterAktenzeichen.Fill(dsAktenzeichen);

                //Default-Wert einfügen
                DataRow row = dsAktenzeichen.Tables[0].NewRow();
                row["IDAktenzeichen"] = "Wählen Sie ein Aktenzeichen aus";
                row["IDKlienten"] = -1;
                row["IDMitarbeiter"] = -1;
                dsAktenzeichen.Tables[0].Rows.InsertAt(row, 0);

                //Daten in der Auswahlliste anzeigen
                dropDownAktenzeichen.DataSource = dsAktenzeichen.Tables[0];
                dropDownAktenzeichen.DisplayMember = "IDAktenzeichen";
                dropDownAktenzeichen.ValueMember = "IDKlienten";
                //dropDownAktenzeichen.SelectedItem = null;
                //dropDownAktenzeichen.SelectedText = "Wählen Sie ein Aktenzeichen aus";

                //Klienten in der DropDown-Liste anzeigen und den Default-Wert auf -1 setzten
                OleDbDataAdapter adapterKlienten = new OleDbDataAdapter("SELECT * FROM tblKlienten ORDER BY txtName", dbConnection);
                DataSet dsKlienten = new DataSet();
                adapterKlienten.Fill(dsKlienten);

                //Default-Wert einfügen
                DataRow row2 = dsKlienten.Tables[0].NewRow();
                row2["IDKlienten"] = -1;
                row2["txtName"] = "Wählen Sie einen Klienten aus";
                dsKlienten.Tables[0].Rows.InsertAt(row2, 0);

                dropDownKlienten.DataSource = dsKlienten.Tables[0];
                dropDownKlienten.DisplayMember = "txtName";
                dropDownKlienten.ValueMember = "IDKlienten";
                //dropDownKlienten.SelectedItem = null;
                //dropDownKlienten.SelectedText = "Wählen Sie einen Klienten aus";


                OleDbCommand dbCommandKlienten = new OleDbCommand(queryKlienten, dbConnection);
                OleDbCommand dbCommandMitarbeiter = new OleDbCommand(queryMitarbeiter, dbConnection);
                OleDbCommand dbCommandRaum = new OleDbCommand(queryRaum, dbConnection);
                OleDbCommand dbCommandAktenzeichen = new OleDbCommand(queryAktenzeichen, dbConnection);

                //Daten auslesen
                OleDbDataReader dbReaderKlienten = dbCommandKlienten.ExecuteReader();
                OleDbDataReader dbReaderMitarbeiter = dbCommandMitarbeiter.ExecuteReader();
                OleDbDataReader dbReaderRaum = dbCommandRaum.ExecuteReader();
                OleDbDataReader dbReaderAktenzeichen = dbCommandAktenzeichen.ExecuteReader();

                //Prüfen ob die Daten ausgelesen wurden
                if (dbReaderKlienten.HasRows == false)
                {
                    MessageBox.Show("Klientendaten wurden nicht ausgelesen", "Fehler");
                }
                else if (dbReaderMitarbeiter.HasRows == false)
                {

                    MessageBox.Show("Mitarbeiterdaten wurden nicht ausgelesen", "Fehler");
                }
                else if (dbReaderRaum.HasRows == false)
                {
                    MessageBox.Show("Räume wurden nicht ausgelesen", "Fehler");
                }
                else if (dbReaderAktenzeichen.HasRows == false)
                {
                    MessageBox.Show("Aktenzeichen wurden nicht ausgelesen", "Fehler");
                }
                else
                {
                    //Klientendaten ins Grid-Dataset schreiben
                    klienten.Clear();
                    while (dbReaderKlienten.Read())
                    {
                        //Daten in der Tabelle ausgeben
                        tabelleKlienten.Rows.Add(dbReaderKlienten["IDKlienten"], dbReaderKlienten["txtAnrede"], dbReaderKlienten["txtName"], dbReaderKlienten["txtVorname"], dbReaderKlienten["txtStrasse"], dbReaderKlienten["txtOrt"], dbReaderKlienten["txtPLZ"]);
                        
                        //Klienten-Objekt erstellen 
                        Klient klient = new Klient
                        {
                            Id = Convert.ToInt32(dbReaderKlienten["IDKlienten"]),
                            Anrede = dbReaderKlienten["txtAnrede"].ToString(),
                            Name = dbReaderKlienten["txtName"].ToString(),
                            Vorname = dbReaderKlienten["txtVorname"].ToString()
                        };

                        //Daten der Klientensammlung hnzufügen
                        try
                        {
                            
                            klienten.Add(klient.Id, klient);
                        }catch(Exception ex)
                        {
                            //
                        }
                        
                        //MessageBox.Show(klienten.Count.ToString(), "Klienten-Sammlung");

                    }

                    // Mitarbeiterdaten schreiben
                    mitarbeiter.Clear();
                    while (dbReaderMitarbeiter.Read())
                    {
                        //Daten in der Tabelle ausgeben
                        tabelleMitarbeiter.Rows.Add(dbReaderMitarbeiter["IDMitarbeiter"], dbReaderMitarbeiter["txtAnrede"],  dbReaderMitarbeiter["txtTitel"], dbReaderMitarbeiter["txtName"], dbReaderMitarbeiter["txtVorname"], dbReaderMitarbeiter["txtTelefon"], dbReaderMitarbeiter["tblFunktionen.IDFunktion"], dbReaderMitarbeiter["txtStrasse"], dbReaderMitarbeiter["txtOrt"], dbReaderMitarbeiter["txtPLZ"]);

                        //Mitarbeiter-Objekt erstellen und der Mitarbeitersammlung hinzufügen
                        Mitarbeiter ma = new Mitarbeiter
                        {
                            Personalnummer = Convert.ToInt32(dbReaderMitarbeiter["IDMitarbeiter"]),
                            Anrede = dbReaderMitarbeiter["txtAnrede"].ToString(),
                            Titel = dbReaderMitarbeiter["txtTitel"].ToString(),
                            Name = dbReaderMitarbeiter["txtName"].ToString(),
                            Vorname = dbReaderMitarbeiter["txtVorname"].ToString(),
                            Telefon = dbReaderMitarbeiter["txtTelefon"].ToString(),
                            Funktion = dbReaderMitarbeiter["tblFunktionen.IDFunktion"].ToString()
                        };
                        
                        try
                        {
                            //Sammlung mitarbeiter aktualisieren
                            
                            mitarbeiter.Add(ma.Personalnummer, ma);
                        }
                        catch (Exception ex)
                        {
                            //
                        }
                        
                        //MessageBox.Show(mitarbeiter.Count.ToString(), "MA-Sammlung");

                    }

                    //Räume schreiben
                    raeume.Clear();
                    while (dbReaderRaum.Read())
                    {
                        //Daten in der Tabelle ausgeben
                        tabelleRaum.Rows.Add(dbReaderRaum["IDRaum"], dbReaderRaum["txtSitzungsart"], dbReaderRaum["ingPlatzzahl"]);

                        //ein Raum-Objekt erstellen und die Raum-Sammlung füllen
                        Raum raum = new Raum();
                        raum.Raumnummer = Convert.ToInt32(dbReaderRaum["IDRaum"]);
                        raum.Sitzungsart = dbReaderRaum["txtSitzungsart"].ToString();
                        raum.Platzzahl = Convert.ToInt32(dbReaderRaum["ingPlatzzahl"]);

                        try
                        {
                            
                            raeume.Add(raum.Raumnummer, raum);
                            //MessageBox.Show(raeume.Count.ToString(), "Räume-Sammlung");
                        }
                        catch (Exception ex)
                        {
                            //
                        }

                    }

                    //Aktenzeichen-Objekte erstellen und die Sammlung füllen
                    aktenzeichen.Clear();
                    while (dbReaderAktenzeichen.Read())
                    {
                        Aktenzeichen az = new Aktenzeichen();
                        if (klienten.ContainsKey(Convert.ToInt32(dbReaderAktenzeichen["IDKlienten"]))){
                            az.Id = dbReaderAktenzeichen["IDAktenzeichen"].ToString();
                            az.Klient = klienten[Convert.ToInt32(dbReaderAktenzeichen["IDKlienten"])];
                            //Dem Klienten das Aktenzeichen in die Liste hinzufügen
                            klienten[Convert.ToInt32(dbReaderAktenzeichen["IDKlienten"])].Aktenzeichen.Add(dbReaderAktenzeichen["IDAktenzeichen"].ToString());

                            if (mitarbeiter.ContainsKey(Convert.ToInt32(dbReaderAktenzeichen["IDMitarbeiter"])))
                            {
                            
                            az.Mitarbeiter = mitarbeiter[Convert.ToInt32(dbReaderAktenzeichen["IDMitarbeiter"])];
                            //Dem Mitarbeiter das Aktenzeichen in die Liste hinzufügen
                            mitarbeiter[Convert.ToInt32(dbReaderAktenzeichen["IDMitarbeiter"])].Aktenzeichen.Add(dbReaderAktenzeichen["IDAktenzeichen"].ToString());
                            }

                            try
                            {
                                
                                aktenzeichen.Add(az.Id, az);
                            }catch(Exception ex)
                            {
                                //
                            }
                            
                        }                       
                    }
                }

                //Verbindung schließen
                dbReaderKlienten.Close();
                dbReaderMitarbeiter.Close();
                dbReaderRaum.Close();
                dbReaderAktenzeichen.Close();

                dbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Folgender Fehler ist aufgetreten:\n " + ex.Message, "Fehler");
            }
        }
            

        /// <summary>
        /// Programm je Tab beenden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFinisch_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonExtiKlienten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonExitMitarbeiter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonExitRaum_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Neuen Klienten hinzufügen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHinzufuegenKlienten_Click(object sender, EventArgs e)
        {
            //Zeilenauswahl prüfen
            if(tabelleKlienten.SelectedRows.Count != 1)
            {
                MessageBox.Show("Bitte tragen Sie alle Daten in eine neue Zeile ein, wählen Sie diese aus und klicken Sie auf \"Hinzufügen\"", "Keine Zeile wurde ausgewählt");
                //Method verlassen
                return;
            }

            //Index der ausgewählten Zeile speichern
            int index = tabelleKlienten.SelectedRows[0].Index;

            //Eingetragene Daten auf Vollständigkeit prüfen
            if(tabelleKlienten.Rows[index].Cells[1].Value == null ||
               tabelleKlienten.Rows[index].Cells[2].Value == null ||
               tabelleKlienten.Rows[index].Cells[3].Value == null ||
               tabelleKlienten.Rows[index].Cells[4].Value == null ||
               tabelleKlienten.Rows[index].Cells[5].Value == null ||
               tabelleKlienten.Rows[index].Cells[6].Value == null
                )
            {
                MessageBox.Show("Nicht alle Daten wurden angegeben.", "Warnung");
                //Method verlassen
                return;
            }

            //Eingetragene Daten auslesen
            string anrede = tabelleKlienten.Rows[index].Cells[1].Value.ToString();
            string name = tabelleKlienten.Rows[index].Cells[2].Value.ToString();
            string vorname = tabelleKlienten.Rows[index].Cells[3].Value.ToString();
            string strasse = tabelleKlienten.Rows[index].Cells[4].Value.ToString();
            string ort = tabelleKlienten.Rows[index].Cells[5].Value.ToString();
            string plz = tabelleKlienten.Rows[index].Cells[6].Value.ToString();

            // Verbindung zur DB herstellen
            OleDbConnection dbConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AnwaltskanzleiDB.mdb");
            dbConnection.Open();

            //Adresse in die Datenbank eintragen und die letzte ID der eingefügten Adresse ermitteln
            string queryAdresse = "INSERT INTO tblAdressen (txtStrasse, txtOrt, txtPLZ) VALUES ('" +  strasse + "', '" + ort + "', '" + plz + "')";
            string queryLastIndex = "SELECT @@IDENTITY";
            
            //Befehl erstellen
            OleDbCommand cmdAdresse = new OleDbCommand(queryAdresse, dbConnection);
            OleDbCommand cmdLastIndex = new OleDbCommand(queryLastIndex, dbConnection);

            if(cmdAdresse.ExecuteNonQuery() == 1)
            {
                int lastIndex = Convert.ToInt32(cmdLastIndex.ExecuteScalar());
                //Einfügen Klienten
                string queryKlienten = "INSERT INTO tblKlienten (txtAnrede, txtName, txtVorname, IDAdresse) VALUES ('" + anrede + "', '" + name + "', '" + vorname + "', " + lastIndex + ")";
                OleDbCommand cmdKlienten = new OleDbCommand(queryKlienten, dbConnection);
                if (cmdKlienten.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Daten wurden erfolgreich gespeichert", "Info");
                    tabelleKlienten.Rows.Clear();
                    tabelleMitarbeiter.Rows.Clear();
                    tabelleRaum.Rows.Clear();
                    AnwaltsKanzleiForm_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Fehler während der Speicherung", "Fehler");
                }
            }
            else
            {
                MessageBox.Show("Fehler während der Speicherung", "Fehler");
            }
           
            //Verbindung schließen
            dbConnection.Close();

        }


        /// <summary>
        /// In dieser Funktion wird die Entscheidung getroffen, welcher Kunde nun ausgewählt wird. Hier erfolgt eine Verknüpfung
        /// von Klienten-, Mitarbeiter- und Aktenzeichen-Daten. Durch die Auswahl eines Aktenzeichens oder Klienten erfolgt
        /// ein Übergang zum nächsten Steuerelement mit einer Datumauswahl-Möglichkeit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dropDownAktenzeichen_SelectedValueChanged(object sender, EventArgs e)
        {

            //in der Klienten-Liste nur den Klienten anzeigen, dem das ausgewählte Aktenzeichen zugeordnet ist
            try
            {
                //Prüfen, ob ein gültiger Index ausgewählt ist
                int IDKlienten = Convert.ToInt32(dropDownAktenzeichen.SelectedValue);
                


                if (IDKlienten > 0)
                {
                    //Ausgewähltes Aktenzeichen auslesen und speichern
                    string Aktenzeichen = dropDownAktenzeichen.Text;

                    //Den zugeordneten Klienten in der anderen Liste auswählen
                    if (Convert.ToInt32(dropDownKlienten.SelectedValue) != IDKlienten)
                    {
                        dropDownKlienten.SelectedValue = IDKlienten;
                    }
                    

                    //Den Standard-Benutzersteuerelement "Info1" verbergen
                    info1.Hide();

                    //Das Aktenzeichen-Objekt in der Sammlung finden und an das Kalender-Window übergeben
                    kalender1.setObjekte(aktenzeichen[Aktenzeichen], aktenzeichen);

                    //Die ausgewählten Daten das erste Mal anzeigen
                    kalender1.monthCalendar1_DateSelected(null, null);
                    //kalender1.monthCalendar1_DateSelected(klienten[IDKlienten], null);



                }
            }catch (Exception ex)
            {
                //der Wert kann nicht in int konvertiert werden
                //MessageBox.Show(ex.Message);
            }

            

            //Benutzer-Kontroll-Fenster mit dem Text schließen und das Kalender-Fenster sichtbar machen

            //Auf dem Kontroll-Fenster den zuständgen Mitarbeiter für den Klienten anzeigen
        }
        
        /// <summary>
        /// Abgleich der ID des ausgewählten Klienten mit seinen Aktenzechen und die Daten
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dropDownKlienten_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                //Prüfen, ob ein gültiger Index ausgewählt ist
                string az = dropDownAktenzeichen.Text;
                int IDKlienten = Convert.ToInt32(dropDownKlienten.SelectedValue);
                if (IDKlienten > 0)
                {
                    if (Convert.ToInt32(dropDownAktenzeichen.SelectedValue) != IDKlienten)
                    {
                        dropDownAktenzeichen.SelectedValue = IDKlienten;
                        //Meldung falls der ausgewählte Klient kein Aktenzeichen besitzt
                        if(klienten[IDKlienten].Aktenzeichen.Count == 0)
                        {
                            MessageBox.Show($"Dem Klienten {klienten[IDKlienten].Vorname} {klienten[IDKlienten].Name}, Klient-ID {klienten[IDKlienten].Id}, wurde noch kein Aktenzeichen in der Datenbank zugeordnet. Bitte wählen Sie einen anderen Klienten aus.", "Auswahl nicht möglich");
                        }

                        //Falls der ausgewählte Klient mehrere Aktenzeichen besitzt
                        if (klienten[IDKlienten].Aktenzeichen.Count > 1)
                        {
                            MessageBox.Show($"Bitte beachten Sie, dass dem Klienten {klienten[IDKlienten].Vorname} {klienten[IDKlienten].Name}, Klient-ID {klienten[IDKlienten].Id}, mehrere Aktenzeichen zugewiesen worden sind:\n\n{String.Join("\n", klienten[IDKlienten].Aktenzeichen)}", "Warnung");
                        }
                    }
                }
            }catch (Exception ex)
            {
                //Der Wert kann nicht konvertiert werden
                //MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Neuen Raum hinzufügen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHinzufuegenRaum_Click(object sender, EventArgs e)
        {
            //Zeilenauswahl prüfen
            if (tabelleRaum.SelectedRows.Count != 1)
            {
                MessageBox.Show("Bitte tragen Sie alle Daten in eine neue Zeile ein, wählen Sie diese aus und klicken Sie auf \"Hinzufügen\"", "Keine Zeile wurde ausgewählt");
                //Method verlassen
                return;
            }

            //Index der ausgewählten Zeile speichern
            int index = tabelleRaum.SelectedRows[0].Index;

            //Eingetragene Daten auf Vollständigkeit prüfen
            if (tabelleRaum.Rows[index].Cells[0].Value == null ||
               tabelleRaum.Rows[index].Cells[1].Value == null ||
               tabelleRaum.Rows[index].Cells[2].Value == null
                )
            {
                MessageBox.Show("Nicht alle Daten wurden angegeben", "Warnung");
                //Method verlassen
                return;
            }

            //Eingetragene Daten auslesen

            try
            {   
            //Konvertieren der Raumnummer zu Integer versuchen
            int nummer = Convert.ToInt32(tabelleRaum.Rows[index].Cells[0].Value);

            //Konvertieren der Stzungsart zu String
            string sitzung = tabelleRaum.Rows[index].Cells[1].Value.ToString();

            //Konvertieren der Platzzahl zu Integer versuchen
            int platzzahl = Convert.ToInt32(tabelleRaum.Rows[index].Cells[2].Value);

            // Verbindung zur DB herstellen
            OleDbConnection dbConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AnwaltskanzleiDB.mdb");
            dbConnection.Open();

            //Adresse in die Datenbank eintragen und die letzte ID der eingefügten Adresse ermitteln
            string query = "INSERT INTO tblRaeume (IDRaum, txtSitzungsart, ingPlatzzahl) VALUES (" + nummer + ", '" + sitzung + "', " + platzzahl + ")";
   

            //Befehl erstellen
            OleDbCommand cmd = new OleDbCommand(query, dbConnection);

            if (cmd.ExecuteNonQuery() == 1)
            {
               MessageBox.Show("Daten wurden erfolgreich gespeichert", "Info");
                    tabelleKlienten.Rows.Clear();
                    tabelleMitarbeiter.Rows.Clear();
                    tabelleRaum.Rows.Clear();
                    AnwaltsKanzleiForm_Load(sender, e);
            }
            else
            {
               MessageBox.Show("Fehler während der Speicherung", "Fehler");
            }

            //Verbindung schließen
            dbConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Folgender Fehler ist aufgetreten:\n" +
                    String.Concat(ex), "Fehler");
            }
        }

        /// <summary>
        /// Neuen Mitarbeiter hinzufügen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHinzufuegenMitarbeiter_Click(object sender, EventArgs e)
        {
            //Zeilenauswahl prüfen
            if (tabelleMitarbeiter.SelectedRows.Count != 1)
            {
                MessageBox.Show("Bitte tragen Sie alle Daten in eine neue Zeile ein, wählen Sie diese aus und klicken Sie auf \"Hinzufügen\"", "Keine Zeile wurde ausgewählt");
                //Method verlassen
                return;
            }

            //Index der ausgewählten Zeile speichern
            int index = tabelleMitarbeiter.SelectedRows[0].Index;

            //Eingetragene Daten auf Vollständigkeit prüfen
            if (tabelleMitarbeiter.Rows[index].Cells[0].Value == null ||
               tabelleMitarbeiter.Rows[index].Cells[1].Value == null ||
               tabelleMitarbeiter.Rows[index].Cells[3].Value == null ||
               tabelleMitarbeiter.Rows[index].Cells[4].Value == null ||
               tabelleMitarbeiter.Rows[index].Cells[6].Value == null ||
               tabelleMitarbeiter.Rows[index].Cells[7].Value == null ||
               tabelleMitarbeiter.Rows[index].Cells[8].Value == null ||
               tabelleMitarbeiter.Rows[index].Cells[9].Value == null
                )
            {
                MessageBox.Show("Nicht alle Daten wurden angegeben.", "Warnung");
                //Method verlassen
                return;
            }

            try
            {
                //Eingetragene Daten auslesen
                int personalnummer = Convert.ToInt32(tabelleMitarbeiter.Rows[index].Cells[0].Value);
                string anrede = tabelleMitarbeiter.Rows[index].Cells[1].Value.ToString();
                string name = tabelleMitarbeiter.Rows[index].Cells[3].Value.ToString();
                string vorname = tabelleMitarbeiter.Rows[index].Cells[4].Value.ToString();
                int funktion = Convert.ToInt32(tabelleMitarbeiter.Rows[index].Cells[6].Value);
                string strasse = tabelleMitarbeiter.Rows[index].Cells[7].Value.ToString();
                string ort = tabelleMitarbeiter.Rows[index].Cells[8].Value.ToString();
                string plz = tabelleMitarbeiter.Rows[index].Cells[9].Value.ToString();


                // Verbindung zur DB herstellen
                OleDbConnection dbConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AnwaltskanzleiDB.mdb");
                dbConnection.Open();

                //Adresse in die Datenbank eintragen und die letzte ID der eingefügten Adresse ermitteln
                string queryAdresse = $"INSERT INTO tblAdressen (txtStrasse, txtOrt, txtPLZ) VALUES ('{strasse}', '{ort}', '{plz}')";
                string queryLastIndex = "SELECT @@IDENTITY";

                //Befehl erstellen
                OleDbCommand cmdAdresse = new OleDbCommand(queryAdresse, dbConnection);
                OleDbCommand cmdLastIndex = new OleDbCommand(queryLastIndex, dbConnection);

                if (cmdAdresse.ExecuteNonQuery() == 1)
                {
                    int lastIndex = Convert.ToInt32(cmdLastIndex.ExecuteScalar());

                    //Einfügen die Mitarbeiterdaten
                    //prüfen ob "Titel" null ist
                    string queryMitarbeiter;
                    if (tabelleMitarbeiter.Rows[index].Cells[2].Value != null && tabelleMitarbeiter.Rows[index].Cells[5].Value != null)
                    {
                        string titel = tabelleMitarbeiter.Rows[index].Cells[2].Value.ToString();
                        string telefon = tabelleMitarbeiter.Rows[index].Cells[5].Value.ToString();

                        queryMitarbeiter = $"INSERT INTO tblMitarbeiter (IDMitarbeiter, txtAnrede, txtTitel, txtName, txtVorname, txtTelefon, IDFunktion, IDAdresse) VALUES ({personalnummer},'{anrede}', '{titel}', '{name}', '{vorname}', '{telefon}', {funktion}, {lastIndex})";
                    
                    }else if (tabelleMitarbeiter.Rows[index].Cells[2].Value != null && tabelleMitarbeiter.Rows[index].Cells[5].Value == null)
                    {
                        string titel = tabelleMitarbeiter.Rows[index].Cells[2].Value.ToString();
      

                        queryMitarbeiter = $"INSERT INTO tblMitarbeiter (IDMitarbeiter, txtAnrede, txtTitel, txtName, txtVorname, IDFunktion, IDAdresse) VALUES ({personalnummer},'{anrede}', '{titel}', '{name}', '{vorname}', {funktion}, {lastIndex})";

                    }
                    else if(tabelleMitarbeiter.Rows[index].Cells[2].Value == null && tabelleMitarbeiter.Rows[index].Cells[5].Value != null)
                    {
                        
                        string telefon = tabelleMitarbeiter.Rows[index].Cells[5].Value.ToString();

                        queryMitarbeiter = $"INSERT INTO tblMitarbeiter (IDMitarbeiter, txtAnrede, txtName, txtVorname, txtTelefon, IDFunktion, IDAdresse) VALUES ({personalnummer},'{anrede}', '{name}', '{vorname}', '{telefon}', {funktion}, {lastIndex})";

                    }
                    else
                    {
                        queryMitarbeiter = $"INSERT INTO tblMitarbeiter (IDMitarbeiter, txtAnrede, txtName, txtVorname, IDFunktion, IDAdresse) VALUES ({personalnummer},'{anrede}', '{name}', '{vorname}', {funktion}, {lastIndex})";

                    }



                    //string queryMitarbeiter = $"INSERT INTO tblMitarbeiter (IDMitarbeiter, txtAnrede, txtTitel, txtName, txtVorname, txtTelefon, IDFunktion, IDAdresse) VALUES ({personalnummer},'{anrede}', '{titel}', '{name}', '{vorname}', '{telefon}', {funktion}, {lastIndex})";
                    OleDbCommand cmdMitarbeiter = new OleDbCommand(queryMitarbeiter, dbConnection);
                    if (cmdMitarbeiter.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Daten wurden erfolgreich gespeichert", "Info");
                        tabelleKlienten.Rows.Clear();
                        tabelleMitarbeiter.Rows.Clear();
                        tabelleRaum.Rows.Clear();
                        AnwaltsKanzleiForm_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Fehler während der Speicherung", "Fehler");
                    }
                }
                else
                {   
                    MessageBox.Show("Fehler während der Speicherung von Adressdaten", "Fehler");

                }

                //Verbindung schließen
                dbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Folgender Fehler ist aufgetreten:\n" +
                String.Concat(ex), "Fehler");
            }
        }

        /// <summary>
        /// Klientendaten ändern
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAktualisierenKlienten_Click(object sender, EventArgs e)
        {
            //Zeilenauswahl prüfen
            if (tabelleKlienten.SelectedRows.Count != 1)
            {
                MessageBox.Show("Bitte wählen Sie die Zeile aus, die Sie ändern möchten", "Warnung");
                //Method verlassen
                return;
            }

            //Index der ausgewählten Zeile speichern
            int index = tabelleKlienten.SelectedRows[0].Index;

            //Eingetragene Daten auf Vollständigkeit prüfen
            if (tabelleKlienten.Rows[index].Cells[0].Value == null ||
               tabelleKlienten.Rows[index].Cells[1].Value == null ||
               tabelleKlienten.Rows[index].Cells[2].Value == null ||
               tabelleKlienten.Rows[index].Cells[3].Value == null ||
               tabelleKlienten.Rows[index].Cells[4].Value == null ||
               tabelleKlienten.Rows[index].Cells[5].Value == null ||
               tabelleKlienten.Rows[index].Cells[6].Value == null
                )
            {
                MessageBox.Show("Nicht alle Daten wurden angegeben.", "Warnung");
                //Method verlassen
                return;
            }

            //Eingetragene Daten auslesen
            int id = Convert.ToInt32(tabelleKlienten.Rows[index].Cells[0].Value);
            string anrede = tabelleKlienten.Rows[index].Cells[1].Value.ToString();
            string name = tabelleKlienten.Rows[index].Cells[2].Value.ToString();
            string vorname = tabelleKlienten.Rows[index].Cells[3].Value.ToString();
            string strasse = tabelleKlienten.Rows[index].Cells[4].Value.ToString();
            string ort = tabelleKlienten.Rows[index].Cells[5].Value.ToString();
            string plz = tabelleKlienten.Rows[index].Cells[6].Value.ToString();

            // Verbindung zur DB herstellen
            OleDbConnection dbConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AnwaltskanzleiDB.mdb");
            dbConnection.Open();

            //Adresse in die Datenbank eintragen und die letzte ID der eingefügten Adresse ermitteln
            string query = $"UPDATE tblAdressen INNER JOIN tblKlienten ON tblAdressen.IDAdresse = tblKlienten.IDAdresse SET txtAnrede = '{anrede}', txtName = '{name}', txtVorname = '{vorname}', txtStrasse = '{strasse}', txtOrt = '{ort}', txtPLZ = '{plz}' WHERE tblKlienten.IDKlienten = {id}";
            

            //Befehl erstellen
            OleDbCommand cmdAdresse = new OleDbCommand(query, dbConnection);
            

            if (cmdAdresse.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Daten wurden erfolgreich geändert", "Info");
                tabelleKlienten.Rows.Clear();
                tabelleMitarbeiter.Rows.Clear();
                tabelleRaum.Rows.Clear();
                AnwaltsKanzleiForm_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Fehler während der Speicherung", "Fehler");
            }

            //Verbindung schließen
            dbConnection.Close();

        }
        /// <summary>
        /// Klientendaten löschen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoeschenKlienten_Click(object sender, EventArgs e)
        {
            //Zeilenauswahl prüfen
            if (tabelleKlienten.SelectedRows.Count != 1)
            {
                MessageBox.Show("Bitte wählen Sie die Zeile aus, die Sie löschen möchten", "Warnung");
                //Method verlassen
                return;
            }

            //Index der ausgewählten Zeile speichern
            int index = tabelleKlienten.SelectedRows[0].Index;

            //prüfen ob die Zeile über eine ID verfügt
            if (tabelleKlienten.Rows[index].Cells[0].Value == null)
            {
                MessageBox.Show("Bitte tragen Sie eine korrekte Klienten-ID ein", "Warnung");
                //Method verlassen
                return;
            }

            //ID auslesen
            int id = Convert.ToInt32(tabelleKlienten.Rows[index].Cells[0].Value);

            // Verbindung zur DB herstellen
            OleDbConnection dbConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AnwaltskanzleiDB.mdb");
            dbConnection.Open();

            //Adressen-ID des zu löschenden Klienten finden und speichern

            OleDbCommand cmdSelect = new OleDbCommand($"SELECT IDAdresse FROM tblKlienten WHERE IDKlienten = {id}", dbConnection);
            int indexAdresse = Convert.ToInt32(cmdSelect.ExecuteScalar());

            //Abfrage : Klienten und seine Adresse löschen

            string queryDeleteKlienten = $"DELETE * FROM tblKlienten WHERE IDKlienten = {id}";
            string queryDeleteAdresse = $"DELETE * FROM tblAdressen WHERE IDAdresse = {indexAdresse}";

            //Befehl erstellen und ausführen
            OleDbCommand cmdKlienten = new OleDbCommand(queryDeleteKlienten, dbConnection);
            OleDbCommand cmdAdresse = new OleDbCommand(queryDeleteAdresse, dbConnection);

            //Zuerst den Klienten und dann die Adresse löschen
            if (cmdKlienten.ExecuteNonQuery() > 0 && cmdAdresse.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Daten wurden erfolgreich gelöscht", "Info");
                tabelleKlienten.Rows.Clear();
                tabelleMitarbeiter.Rows.Clear();
                tabelleRaum.Rows.Clear();
                AnwaltsKanzleiForm_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Fehler während des Löschvorganges", "Fehler");
            }

            //Verbindung schließen
            dbConnection.Close();
        }

        /// <summary>
        /// Mitarbeiter ändern
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAktualisierenMitarbeiter_Click(object sender, EventArgs e)
        {
            //Zeilenauswahl prüfen
            if (tabelleMitarbeiter.SelectedRows.Count != 1)
            {
                MessageBox.Show("Bitte wählen Sie die Zeile aus, die Sie ändern möchten", "Warnung");
                //Method verlassen
                return;
            }

            //Index der ausgewählten Zeile speichern
            int index = tabelleMitarbeiter.SelectedRows[0].Index;

            //Eingetragene Daten auf Vollständigkeit prüfen
            if (tabelleMitarbeiter.Rows[index].Cells[0].Value == null ||
               tabelleMitarbeiter.Rows[index].Cells[1].Value == null ||
               tabelleMitarbeiter.Rows[index].Cells[3].Value == null ||
               tabelleMitarbeiter.Rows[index].Cells[4].Value == null ||
               tabelleMitarbeiter.Rows[index].Cells[6].Value == null ||
               tabelleMitarbeiter.Rows[index].Cells[7].Value == null ||
               tabelleMitarbeiter.Rows[index].Cells[8].Value == null ||
               tabelleMitarbeiter.Rows[index].Cells[9].Value == null
                )
            {
                MessageBox.Show("Nicht alle Daten wurden angegeben.", "Warnung");
                //Method verlassen
                return;
            }



            try
            {
                //Eingetragene Daten auslesen
                int personalnummer = Convert.ToInt32(tabelleMitarbeiter.Rows[index].Cells[0].Value);
                string anrede = tabelleMitarbeiter.Rows[index].Cells[1].Value.ToString();
                string name = tabelleMitarbeiter.Rows[index].Cells[3].Value.ToString();
                string vorname = tabelleMitarbeiter.Rows[index].Cells[4].Value.ToString();
                int funktion = Convert.ToInt32(tabelleMitarbeiter.Rows[index].Cells[6].Value);
                string strasse = tabelleMitarbeiter.Rows[index].Cells[7].Value.ToString();
                string ort = tabelleMitarbeiter.Rows[index].Cells[8].Value.ToString();
                string plz = tabelleMitarbeiter.Rows[index].Cells[9].Value.ToString();

                // Verbindung zur DB herstellen
                OleDbConnection dbConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AnwaltskanzleiDB.mdb");
                dbConnection.Open();

                //Ändern der Mitarbeiterdaten
                //prüfen ob "Titel" und "Telefon" null sind
                string queryMitarbeiter;
                    if (tabelleMitarbeiter.Rows[index].Cells[2].Value != null && tabelleMitarbeiter.Rows[index].Cells[5].Value != null)
                    {
                        string titel = tabelleMitarbeiter.Rows[index].Cells[2].Value.ToString();
                        string telefon = tabelleMitarbeiter.Rows[index].Cells[5].Value.ToString();

                        queryMitarbeiter = $"UPDATE tblMitarbeiter INNER JOIN tblAdressen ON tblMitarbeiter.IDAdresse = tblAdressen.IDAdresse SET tblMitarbeiter.IDMitarbeiter = {personalnummer}, txtAnrede = '{anrede}', txtTitel = '{titel}', txtName = '{name}', txtVorname = '{vorname}', txtTelefon = '{telefon}', IDFunktion = {funktion}, txtStrasse = '{strasse}', txtOrt = '{ort}', txtPLZ = '{plz}' WHERE tblMitarbeiter.IDMitarbeiter = {personalnummer}";

                    }
                    else if (tabelleMitarbeiter.Rows[index].Cells[2].Value != null && tabelleMitarbeiter.Rows[index].Cells[5].Value == null)
                    {
                        string titel = tabelleMitarbeiter.Rows[index].Cells[2].Value.ToString();


                        queryMitarbeiter = $"UPDATE tblMitarbeiter INNER JOIN tblAdressen ON tblMitarbeiter.IDAdresse = tblAdressen.IDAdresse SET tblMitarbeiter.IDMitarbeiter = {personalnummer}, txtAnrede = '{anrede}', txtTitel = '{titel}', txtName = '{name}', txtVorname = '{vorname}', IDFunktion = {funktion}, txtStrasse = '{strasse}', txtOrt = '{ort}', txtPLZ = '{plz}' WHERE tblMitarbeiter.IDMitarbeiter = {personalnummer}";

                }
                    else if (tabelleMitarbeiter.Rows[index].Cells[2].Value == null && tabelleMitarbeiter.Rows[index].Cells[5].Value != null)
                    {

                        string telefon = tabelleMitarbeiter.Rows[index].Cells[5].Value.ToString();

                        queryMitarbeiter = $"UPDATE tblMitarbeiter INNER JOIN tblAdressen ON tblMitarbeiter.IDAdresse = tblAdressen.IDAdresse SET tblMitarbeiter.IDMitarbeiter = {personalnummer}, txtAnrede = '{anrede}', txtName = '{name}', txtVorname = '{vorname}', txtTelefon = '{telefon}', IDFunktion = {funktion}, txtStrasse = '{strasse}', txtOrt = '{ort}', txtPLZ = '{plz}' WHERE tblMitarbeiter.IDMitarbeiter = {personalnummer}";

                }
                    else
                    {
                        queryMitarbeiter = $"UPDATE tblMitarbeiter (INNER JOIN tblAdressen ON tblMitarbeiter.IDAdresse = tblAdressen.IDAdresse) SET tblMitarbeiter.IDMitarbeiter = {personalnummer}, txtAnrede = '{anrede}', txtName = '{name}', txtVorname = '{vorname}', IDFunktion = {funktion}, txtStrasse = '{strasse}', txtOrt = '{ort}', txtPLZ = '{plz}' WHERE tblMitarbeiter.IDMitarbeiter = {personalnummer}";

                }

                    OleDbCommand cmdMitarbeiter = new OleDbCommand(queryMitarbeiter, dbConnection);
                    if (cmdMitarbeiter.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Daten wurden erfolgreich geändert", "Info");
                    tabelleKlienten.Rows.Clear();
                    tabelleMitarbeiter.Rows.Clear();
                    tabelleRaum.Rows.Clear();
                    AnwaltsKanzleiForm_Load(sender, e);
                }
                    else
                    {
                        MessageBox.Show("Fehler während der Änderung", "Fehler");
                    }

                //Verbindung schließen
                dbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Folgender Fehler ist aufgetreten:\n" +
                String.Concat(ex), "Fehler");
            }
        }
        /// <summary>
        /// Mitarbeiter löschen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoeschenMitarbeiter_Click(object sender, EventArgs e)
        {
            //Zeilenauswahl prüfen
            if (tabelleMitarbeiter.SelectedRows.Count != 1)
            {
                MessageBox.Show("Bitte wählen Sie die Zeile aus, die Sie löschen möchten", "Warnung");
                //Method verlassen
                return;
            }

            //Index der ausgewählten Zeile speichern
            int index = tabelleMitarbeiter.SelectedRows[0].Index;

            //prüfen ob die Zeile über eine ID verfügt
            if (tabelleMitarbeiter.Rows[index].Cells[0].Value == null)
            {
                MessageBox.Show("Bitte tragen Sie eine korrekte Klienten-ID ein", "Warnung");
                //Method verlassen
                return;
            }

            //ID auslesen
            int id = Convert.ToInt32(tabelleMitarbeiter.Rows[index].Cells[0].Value);

            // Verbindung zur DB herstellen
            OleDbConnection dbConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AnwaltskanzleiDB.mdb");
            dbConnection.Open();

            //Adressen-ID des zu löschenden Klienten finden und speichern

            OleDbCommand cmdSelect = new OleDbCommand($"SELECT IDAdresse FROM tblMitarbeiter WHERE IDMitarbeiter = {id}", dbConnection);
            int indexAdresse = Convert.ToInt32(cmdSelect.ExecuteScalar());

            //Abfrage : Klienten und seine Adresse löschen

            string queryDeleteMitarbeiter = $"DELETE * FROM tblMitarbeiter WHERE IDMitarbeiter = {id}";
            string queryDeleteAdresse = $"DELETE * FROM tblAdressen WHERE IDAdresse = {indexAdresse}";

            //Befehl erstellen und ausführen
            OleDbCommand cmdMitarbeiter = new OleDbCommand(queryDeleteMitarbeiter, dbConnection);
            OleDbCommand cmdAdresse = new OleDbCommand(queryDeleteAdresse, dbConnection);

            //Zuerst den Klienten und dann die Adresse löschen
            if (cmdMitarbeiter.ExecuteNonQuery() > 0 && cmdAdresse.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Daten wurden erfolgreich gelöscht", "Info");
                tabelleKlienten.Rows.Clear();
                tabelleMitarbeiter.Rows.Clear();
                tabelleRaum.Rows.Clear();
                AnwaltsKanzleiForm_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Fehler während des Löschvorganges", "Fehler");
            }

            //Verbindung schließen
            dbConnection.Close();
        }
        /// <summary>
        /// Raum ändern
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAktualisierenRaum_Click(object sender, EventArgs e)
        {
            //Zeilenauswahl prüfen
            if (tabelleRaum.SelectedRows.Count != 1)
            {
                MessageBox.Show("Bitte wählen Sie die Zeile aus, die Sie ändern möchten", "Warnung");
                //Method verlassen
                return;
            }

            //Index der ausgewählten Zeile speichern
            int index = tabelleRaum.SelectedRows[0].Index;

            //Eingetragene Daten auf Vollständigkeit prüfen
            if (tabelleRaum.Rows[index].Cells[0].Value == null ||
               tabelleRaum.Rows[index].Cells[1].Value == null ||
               tabelleRaum.Rows[index].Cells[2].Value == null
                )
            {
                MessageBox.Show("Nicht alle Daten wurden angegeben", "Warnung");
                //Method verlassen
                return;
            }

            //Eingetragene Daten auslesen

            try
            {
                //Konvertieren der Raumnummer zu Integer versuchen
                int nummer = Convert.ToInt32(tabelleRaum.Rows[index].Cells[0].Value);

                //Konvertieren der Stzungsart zu String
                string sitzung = tabelleRaum.Rows[index].Cells[1].Value.ToString();

                //Konvertieren der Platzzahl zu Integer versuchen
                int platzzahl = Convert.ToInt32(tabelleRaum.Rows[index].Cells[2].Value);

                // Verbindung zur DB herstellen
                OleDbConnection dbConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AnwaltskanzleiDB.mdb");
                dbConnection.Open();

                //Adresse in die Datenbank eintragen und die letzte ID der eingefügten Adresse ermitteln
                string query = $"UPDATE tblRaeume SET txtSitzungsart = '{sitzung}', ingPlatzzahl = {platzzahl} WHERE IDRaum = {nummer}";


                //Befehl erstellen
                OleDbCommand cmd = new OleDbCommand(query, dbConnection);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Daten wurden erfolgreich geändert", "Info");
                    tabelleKlienten.Rows.Clear();
                    tabelleMitarbeiter.Rows.Clear();
                    tabelleRaum.Rows.Clear();
                    AnwaltsKanzleiForm_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Fehler während der Speicherung", "Fehler");
                }

                //Verbindung schließen
                dbConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Folgender Fehler ist aufgetreten:\n" +
                    String.Concat(ex), "Fehler");
            }
        }
        /// <summary>
        /// Löschen den Raum
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoeschenRaum_Click(object sender, EventArgs e)
        {
            //Zeilenauswahl prüfen
            if (tabelleRaum.SelectedRows.Count != 1)
            {
                MessageBox.Show("Bitte wählen Sie die Zeile aus, die Sie ändern möchten", "Warnung");
                //Method verlassen
                return;
            }

            //Index der ausgewählten Zeile speichern
            int index = tabelleRaum.SelectedRows[0].Index;

            //Eingetragene Daten auf Vollständigkeit prüfen
            if (tabelleRaum.Rows[index].Cells[0].Value == null)
            {
                MessageBox.Show("Nicht alle Daten wurden angegeben", "Warnung");
                //Method verlassen
                return;
            }

            //Eingetragene Daten auslesen

            try
            {
                //Konvertieren der Raumnummer zu Integer versuchen
                int nummer = Convert.ToInt32(tabelleRaum.Rows[index].Cells[0].Value);

                // Verbindung zur DB herstellen
                OleDbConnection dbConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AnwaltskanzleiDB.mdb");
                dbConnection.Open();

                //Adresse in die Datenbank eintragen und die letzte ID der eingefügten Adresse ermitteln
                string query = $"DELETE * FROM tblRaeume WHERE IDRaum = {nummer}";


                //Befehl erstellen
                OleDbCommand cmd = new OleDbCommand(query, dbConnection);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Daten wurden erfolgreich gelöscht", "Info");
                    tabelleKlienten.Rows.Clear();
                    tabelleMitarbeiter.Rows.Clear();
                    tabelleRaum.Rows.Clear();
                    AnwaltsKanzleiForm_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Fehler während der Speicherung", "Fehler");
                }

                //Verbindung schließen
                dbConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Folgender Fehler ist aufgetreten:\n" +
                    String.Concat(ex), "Fehler");
            }
        }

        /// <summary>
        /// die Methode zeigt ein Dialog-Fenster
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnwaltsKanzleiForm_FormClosing(object sender, FormClosingEventArgs e)
        {
         
                var x = MessageBox.Show("Sind Sie sicher, dass Sie das Program beenden möchten?",
                                         "Program schließen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (x == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                }
            
        }

    }
}
