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
        /// <summary>
        /// Methode um Dropdown Menu zu Öffenen mit click
        /// </summary>
        /// <param name="Stationsname"></param>
        private void stationVon(string Stationsname)
        {
            
            Transport t = new Transport();
            Stations myStations = t.GetStations(Stationsname);
            foreach(Station station in myStations.StationList)
            {
                comboBoxVon.Items.Add(station.Name);
            }
        }
        /// <summary>
        /// Methode um Dropdown Menu zu Öffnen mit click
        /// </summary>
        /// <param name="Stationsname"></param>
        private void stationNach(string Stationsname)
        {
            Transport t = new Transport();
            Stations myStations = t.GetStations(Stationsname);
            foreach (Station station in myStations.StationList)
            {
                comboBoxNach.Items.Add(station.Name);
            }
        }

        private void btnVerbindung_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxVon_KeyDown(object sender, KeyEventArgs e)
        {
            comboBoxVon.DropDown = true;
            stationVon(comboBoxVon.Text);
        }

        private void comboBoxNach_KeyDown(object sender, KeyEventArgs e)
        {
            comboBoxNach.DropDown = true;
            stationNach(comboBoxNach.Text);
        }

        private void comboBoxVon_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


    }
}
