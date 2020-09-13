using AnwaltsKanzleiLibrary;
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

namespace AnwaltsKanzleiUI
{
    public partial class Termine : Form
    {

        private Aktenzeichen az = new Aktenzeichen();
        private string datum;
        private Dictionary<string, Aktenzeichen> alle = new Dictionary<string, Aktenzeichen>();

        public Termine(Aktenzeichen az, string datum, Dictionary<string, Aktenzeichen> alle)
        {
            this.az.Id = az.Id;
            this.az.Klient = az.Klient;
            this.az.Mitarbeiter = az.Mitarbeiter;
            this.datum = datum;
            this.alle = alle.ToDictionary(entry => entry.Key, entry => entry.Value);


            InitializeComponent();
            setTermindaten(az, datum);
            fillTables(az, datum, alle);
            pruefeBedingungen(datum);
        }

        private void buttonAllesSchließen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Ändert den Platzhalter-Text im Fenster durch die ausgewählten Daten
        /// </summary>
        /// <param name="az"></param>
        /// <param name="datum"></param>
        private void setTermindaten(Aktenzeichen az, string datum)
        {
            labelPlatzhalter.Text = $"Aktenzeichen:\nKlient:\nMitarbeiter:\nDatum:";
            labelPlatzhalterDaten.Text = $"{az.Id}\n{az.Klient.Anrede} {az.Klient.Name}, {az.Klient.Vorname}\n{az.Mitarbeiter.Anrede} {az.Mitarbeiter.Titel} {az.Mitarbeiter.Name}, {az.Mitarbeiter.Vorname}\n{datum}"; ;

            labelTermine.Text = $"Termine - {az.Mitarbeiter.Titel} {az.Mitarbeiter.Vorname} {az.Mitarbeiter.Name}";
        }

        /// <summary>
        /// Termine und Räume anhand der ausgewählten Daten in den Tabellen "Termine" und "Räume" füllen
        /// </summary>
        private void fillTables(Aktenzeichen az, string datum, Dictionary<string, Aktenzeichen> alle)
        {

            try
            {
                //Verbindung zur DB herstellen
                OleDbConnection dbConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AnwaltskanzleiDB.mdb");
                dbConnection.Open();

                //Query machen und Daten holen
                //var splitDate = datum.Split(' ')[0];
                string queryTermine = $"SELECT * FROM tblTermine INNER JOIN tblRaeume ON tblTermine.IDRaum = tblRaeume.IDRaum WHERE (tblTermine.IDMitarbeiter = {az.Mitarbeiter.Personalnummer} AND tblTermine.datTag = #{datum}#) ORDER BY datVon";
                string queryRaumbelegung = $"SELECT * FROM tblTermine INNER JOIN tblRaeume ON tblTermine.IDRaum = tblRaeume.IDRaum WHERE (datTag = #{datum}#) ORDER BY datVon";

                //Tabellen DataGridView füllen
                OleDbCommand dbCommandTermine = new OleDbCommand(queryTermine, dbConnection);
                OleDbCommand dbCommandRaumbelegung = new OleDbCommand(queryRaumbelegung, dbConnection);

                //Daten auslesen
                OleDbDataReader dbReaderTermine = dbCommandTermine.ExecuteReader();
                OleDbDataReader dbReaderRaumbelegung = dbCommandRaumbelegung.ExecuteReader();

                try
                {
                    //Prüfen ob die Daten ausgelesen wurden
                    //if (dbReaderTermine.HasRows == false)
                    //{
                    //    MessageBox.Show("Keine Termine wurden für das ausgewählte Datum gefunden", "Info");
                    //}

                    //if (dbReaderRaumbelegung.HasRows == false)
                    //{
                    //    MessageBox.Show("Am ausgewählten Tag sind alle Räume frei", "Info");
                    //}

                    //Tabelle Termine füllen
                    tabelleTermine.Columns[0].DefaultCellStyle.Format = "HH:mm";
                    tabelleTermine.Columns[1].DefaultCellStyle.Format = "HH:mm";
                    while (dbReaderTermine.Read())
                    {
                        //Daten in der Tabelle Termine schreiben ausgeben
                        tabelleTermine.Rows.Add(dbReaderTermine["datVon"], dbReaderTermine["datBis"], dbReaderTermine["IDAktenzeichen"], alle[(dbReaderTermine["IDAktenzeichen"].ToString())].Klient.Name, dbReaderTermine["tblTermine.IDRaum"]);

                    }



                    //Tabelle Raumbelegung füllen
                    tabelleRaumbelegung.Columns[0].DefaultCellStyle.Format = "HH:mm";
                    tabelleRaumbelegung.Columns[1].DefaultCellStyle.Format = "HH:mm";
                    while (dbReaderRaumbelegung.Read())
                    {
                        //Daten in der Tabelle Termine schreiben ausgeben
                        tabelleRaumbelegung.Rows.Add(dbReaderRaumbelegung["datVon"], dbReaderRaumbelegung["datBis"], dbReaderRaumbelegung["tblTermine.IDRaum"], dbReaderRaumbelegung["txtSitzungsart"], dbReaderRaumbelegung["ingPlatzzahl"]);

                    }



                }
                catch
                {

                    MessageBox.Show("Bei Ihrer Abfrage ist ein Fehler aufgetreten", "Fehler");
                    
                }

                //Verbindung schließen
                dbReaderRaumbelegung.Close();
                dbReaderTermine.Close();
                dbConnection.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
        private void pruefeBedingungen(string datum)
        {
            
            string von = dateTimeVon.Value.ToString("HH:mm");
            string bis = dateTimeBis.Value.ToString("HH:mm");

            //MessageBox.Show(von, bis);

            //
            OleDbConnection dbConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AnwaltskanzleiDB.mdb");
            dbConnection.Open();

            OleDbDataAdapter adapterRaum = new OleDbDataAdapter($"SELECT IDRaum FROM tblRaeume WHERE IDRaum NOT IN " +
                                                                      $"(SELECT IDRaum FROM tblTermine WHERE ((datVon <= #{von}#)  AND (datBis >= #{von}#) AND (datTag = #{datum}#)) " +
                                                                      $"OR ((datVon  < #{bis}#) AND (datBis >= #{bis}#) AND (datTag = #{datum}#)) " +
                                                                      $"OR ((#{von}# <= datVon) AND (#{bis}# >= datVon) AND (datTag = #{datum}#)))", dbConnection);

            //OleDbDataAdapter adapterRaum = new OleDbDataAdapter($"SELECT IDRaum FROM tblRaeume WHERE IDRaum NOT IN (SELECT IDRaum FROM tblTermine WHERE datTag = #{datum}#)", dbConnection);
            
            
            DataSet ds = new DataSet();
            adapterRaum.Fill(ds);
            comboBoxRaum.DataSource = ds.Tables[0];
            comboBoxRaum.DisplayMember = "IDRaum";
            comboBoxRaum.ValueMember = "IDRaum";

            dbConnection.Close();
        }
        /// <summary>
        /// Validieren der ausgewählten Uhrzeit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimeVon_ValueChanged(object sender, EventArgs e)
        {
            //die Bis-Zeit darf nicht vor der Von-Zeit liegen
            if(dateTimeVon.Value > dateTimeBis.Value)
            {
                dateTimeBis.Value = dateTimeVon.Value;
            }

            //MessageBox.Show(datum);
            pruefeBedingungen(datum);
        }
        
        
        /// <summary>
        /// Termin des Mitarbeiters validieren und speichern
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            string von = dateTimeVon.Value.ToString("HH:mm");
            string bis = dateTimeBis.Value.ToString("HH:mm");
            int raum = Convert.ToInt32(comboBoxRaum.SelectedValue);
            int id = az.Mitarbeiter.Personalnummer;

            //MessageBox.Show(von, bis);

            //Der Raum ist bereits für den Zeitraum validiert worden. Es bleibt nur die Überschneidungen mmit den bestehenden Terminen zu überprüfen
            OleDbConnection dbConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AnwaltskanzleiDB.mdb");
            dbConnection.Open();

            OleDbCommand cmd = new OleDbCommand($"SELECT Count(*) FROM tblTermine WHERE IDMitarbeiter IN " +
                                                                      $"(SELECT IDMitarbeiter FROM tblTermine WHERE ((datVon <= #{von}#)  AND (datBis >= #{von}#) AND (datTag = #{datum}#) AND (IDMitarbeiter = {id})) " +
                                                                      $"OR ((datVon  < #{bis}#) AND (datBis >= #{bis}#) AND (datTag = #{datum}#) AND (IDMitarbeiter = {id})) " +
                                                                      $"OR ((#{von}# <= datVon) AND (#{bis}# >= datVon) AND (datTag = #{datum}#) AND (IDMitarbeiter = {id})))", dbConnection);
            
            // User benachrichtigen ob der Termin gebucht werden kann
            int count = (int)cmd.ExecuteScalar();
            //MessageBox.Show(count.ToString(), id.ToString());
            if (count > 0)
            {
                MessageBox.Show($"{az.Mitarbeiter.Vorname} {az.Mitarbeiter.Name} hat bereits einen Termin in diesem Zeitfenster. Bitte wählen Sie eine andere Uhrzeit aus.", "Dieser Zetraum steht leider nicht zur Verfügung");
            }
            else
            {
                //Termin hinzufügen
                string query = $"INSERT INTO tblTermine (datTag, datVon, datBis, IDMitarbeiter, IDAktenzeichen, IDRaum)" +
                    $" VALUES (#{datum}#, #{von}#, #{bis}#, {id}, '{az.Id}', {raum})";

                OleDbCommand insert = new OleDbCommand(query, dbConnection);

                if(insert.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Termin wurde erfolgreich eingetragen", "Info");
                    tabelleTermine.Rows.Clear();
                    tabelleRaumbelegung.Rows.Clear();
                    fillTables(az, datum, alle);
                }
                else
                {
                    MessageBox.Show("Fehler während der Speicherung", "Fehler");
                }
            }

            dbConnection.Close();
        }
    }

    
}
