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
        // Vorschläge anzeigen
        private void stationSearch(string StationsName, ListBox listBoxName)
        {
            listBoxName.Items.Clear();
            Stations myStations = t.GetStations(StationsName);
            foreach (Station station in myStations.StationList)
            {
                try
                {
                    if (station.Id != null)
                    {
                        listBoxName.Items.Add(station.Name);
                    }
                }
                catch
                {
                    MessageBox.Show("Geben sie bitte ein gültige Staion ein.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }  
            }
        }

        //Verbindungen anzeigen lassen
        private void connections(ListView listViewName)
        {
            listViewName.Items.Clear();
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
                    MessageBox.Show("Geben sie bitte ein gültige Staion ein.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //click auf Element in listBox um es auszuwählen
        private void fillOnClick(TextBox textBoxName, ListBox listBoxName)
        {
            if(listBoxName.SelectedItems !=null && listBoxName.SelectedItems.Count >0)
            {
                textBoxName.Text = listBoxName.SelectedItems[0].ToString();
            }
            
        }
        //autoFill Methode
        private void autoFill(KeyEventArgs e, TextBox textBoxName, ListBox listBoxName)
        {
            try
            {
                if (e.KeyCode == Keys.Up)
                {
                    listBoxName.SelectedIndex--;
                }
                else if (e.KeyCode == Keys.Down)
                {
                    listBoxName.SelectedIndex++;
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    textBoxName.Text = listBoxName.SelectedItems[0].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Sie haben eine ungültige Taste gedrückt.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //stationBoard methode
        private void stationBoard(string stationName, ListView listViewName)
        {
            listViewName.Items.Clear();

            Station station = t.GetStations(stationName).StationList.First();
            StationBoardRoot stationBoardRoot = t.GetStationBoard(stationName, station.Id);

            foreach (StationBoard stationBoard in stationBoardRoot.Entries)
            {
                try
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = stationBoard.Name;
                    listViewItem.SubItems.Add(stationBoard.To);
                    listViewItem.SubItems.Add(stationBoard.Stop.Departure.ToShortTimeString());
                    listViewItem.SubItems.Add(stationBoard.Operator);
                    listViewName.Items.Add(listViewItem);
                }
                catch
                {
                    MessageBox.Show("Die Abfahrtstafel konnte nicht angezeigt werden.", "Caption", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }
        //Google maps ausgewälte Station anzeigen lassen
        private void createGoogleMaps(string stationName)
        {
            Station stations = t.GetStations(stationName).StationList.First();
            string xcoordinate = stations.Coordinate.XCoordinate.ToString();
            string ycoordinate = stations.Coordinate.YCoordinate.ToString();
            webBrowser1.Url = new System.Uri("https://www.google.com/maps?q=" + xcoordinate.Replace(",",".") + "," + ycoordinate.Replace(",","."), System.UriKind.Absolute);
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
            fillOnClick(textBoxFrom, listBoxFrom);
        }

        private void listBoxTo_Click(object sender, EventArgs e)
        {
            fillOnClick(textBoxTo, listBoxTo);
        }

        private void btnconnection_Click(object sender, EventArgs e)
        {
            try
            {
                connections(listViewOutput);
            }
            catch
            {
                MessageBox.Show("Geben sie bitte ein gültige Staion ein.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxSign_TextChanged(object sender, EventArgs e)
        {
            stationSearch(textBoxSign.Text, listBoxSign);
        }

        private void listBoxSign_Click(object sender, EventArgs e)
        {
            fillOnClick(textBoxSign, listBoxSign);
        }

        private void btnSignOutput_Click(object sender, EventArgs e)
        {
            try
            {
                stationBoard(textBoxSign.Text, listViewSign);
            }
            catch
            {
                MessageBox.Show("Geben sie bitte ein gültige Staion ein.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxFrom_KeyDown(object sender, KeyEventArgs e)
        {
            autoFill(e, textBoxFrom, listBoxFrom);
        }

        private void textBoxTo_KeyDown(object sender, KeyEventArgs e)
        {
            autoFill(e, textBoxTo, listBoxTo);
        }

        private void textBoxSign_KeyDown(object sender, KeyEventArgs e)
        {
            autoFill(e, textBoxSign, listBoxSign);
        }

        private void btnMaps_Click(object sender, EventArgs e)
        {
            try
            {
                createGoogleMaps(textBoxMaps.Text);
            }
            catch
            {
                MessageBox.Show("Geben sie bitte eine gültige Station ein.");
            }
        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textBoxSign.Text = webBrowser1.Url.ToString();
        }

        private void textBoxMaps_KeyDown(object sender, KeyEventArgs e)
        {
            autoFill(e, textBoxMaps, listBoxMaps);
        }

        private void textBoxMaps_TextChanged(object sender, EventArgs e)
        {
            stationSearch(textBoxMaps.Text, listBoxMaps);
        }

        private void listBoxMaps_Click(object sender, EventArgs e)
        {
            fillOnClick(textBoxMaps, listBoxMaps);
        }
    }
}
