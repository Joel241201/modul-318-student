using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace SwissTransportGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Transport Objekt erstellen
        Transport t = new Transport();
        // Methode um Dropdown Menu zu Öffnen und Vorschläge anzeigen
        public void stationSuche(string StationsName, ListBox listBoxName)
        {
            listBoxName.Items.Clear();
            Stations myStations = t.GetStations(StationsName);
            foreach (Station station in myStations.StationList)
            {
                try
                {
                    listBoxName.Items.Add(station.Name);
                }
                catch
                {
                    MessageBox.Show("Station sind Ungültig, bitte eine andere Station eingeben." +
                        MessageBoxButtons.OK);
                }  
            }
        }

        //Verbindungen anzeigen lassen
        private void Verbindung(ListView listViewName)
        {
            listViewAusgabe.Items.Clear();
            Connections verbindung = t.GetConnections(textBoxVon.Text, textBoxNach.Text);
            
            foreach (Connection c in verbindung.ConnectionList)
            {
                DateTime Departure = DateTime.Parse(c.From.Departure);
                DateTime Arrival = DateTime.Parse(c.To.Arrival);
                try
                {
                    ListViewItem item1 = new ListViewItem();
                    listViewAusgabe.Items.Add(c.From.Station.Name);
                    listViewAusgabe.Items.Add(c.To.Station.Name);
                    item1.Text = Departure.ToShortTimeString();
                    listViewName.Items.Add(item1);
                }
                catch
                {
                    MessageBox.Show("Es gibt keine Verbindungen zwischen diesen Stationen");
                }
            }
        }

        private void textBoxVon_TextChanged(object sender, EventArgs e)
        {
            stationSuche(textBoxVon.Text, listBoxVon);
        }

        private void textBoxNach_TextChanged(object sender, EventArgs e)
        {
            stationSuche(textBoxNach.Text, listBoxNach);
        }

        private void listBoxVon_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxVon.Text = listBoxVon.SelectedItems[0].ToString();
                listBoxVon.Items.Clear();
            }
            catch
            {
                MessageBox.Show("Wählen sie bitte eine Station aus:");
            }
        }

        //in der Listbox doppelclick um Station auszuwählen
        private void listBoxNach_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxNach.Text = listBoxNach.SelectedItems[0].ToString();
                listBoxNach.Items.Clear();
            }
            catch
            {
                MessageBox.Show("Wählen sie bitte eine Station aus:");
            }
        }

        private void btnVerbindung_Click(object sender, EventArgs e)
        {
            Verbindung(listViewAusgabe);
        }

        private void listViewAusgabe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
