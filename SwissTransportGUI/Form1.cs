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
        public void stationSearch(string StationsName, ListBox listBoxName)
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
        private void Connections(ListView listViewName)
        {
            listViewOutput.Items.Clear();
            Connections connection = t.GetConnections(textBoxFrom.Text, textBoxTo.Text);
            
            foreach (Connection c in connection.ConnectionList)
            {
                DateTime Departure = DateTime.Parse(c.From.Departure);
                DateTime Arrival = DateTime.Parse(c.To.Arrival);
                try
                {
                    ListViewItem item1 = new ListViewItem();
                    item1.Text = c.From.Station.Name;
                    item1.SubItems.Add(c.To.Station.Name);
                    item1.SubItems.Add(Departure.ToShortTimeString());
                    listViewName.Items.Add(item1);
                }
                catch
                {
                    MessageBox.Show("Es gibt keine Verbindungen zwischen diesen Stationen");
                }
            }
        }

        private void textBoxFrom_TextChanged(object sender, EventArgs e)
        {
            stationSearch(textBoxFrom.Text, listBoxFrom);
        }

        private void textBoxTo_TextChanged(object sender, EventArgs e)
        {
            stationSearch(textBoxTo.Text, listBoxTo);
        }

        private void listBoxFrom_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxFrom.Text = listBoxFrom.SelectedItems[0].ToString();
                listBoxFrom.Items.Clear();
            }
            catch
            {
                MessageBox.Show("Wählen sie bitte eine Station aus:");
            }
        }

        //in der Listbox doppelclick um Station auszuwählen
        private void listBoxTo_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxTo.Text = listBoxTo.SelectedItems[0].ToString();
                listBoxTo.Items.Clear();
            }
            catch
            {
                MessageBox.Show("Wählen sie bitte eine Station aus:");
            }
        }

        private void btnconnection_Click(object sender, EventArgs e)
        {
            Connections(listViewOutput);
        }

        private void listViewOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSign_TextChanged(object sender, EventArgs e)
        {
            stationSearch(textBoxSign.Text, listBoxSign);
        }

        private void listBoxSign_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxSign.Text = listBoxTo.SelectedItems[0].ToString();
                listBoxTo.Items.Clear();
            }
            catch
            {
                MessageBox.Show("Wählen sie bitte eine Station aus:");
            }
        }
    }
}
