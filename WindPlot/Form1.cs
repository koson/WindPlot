using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindPlot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Station BL = new Station() { name = "Ban Lang", id = "006"};
            StationData SD = new StationData() ;
            Wind WN = new Wind();
            GPS gps = new GPS();
            Environment env = new Environment();
            WN.direction = 2;
            WN.speed = 1.2;
            SD.wind = WN;
            gps.Latitude = 12.3456;
            gps.Longitude = 56.7890;
            BL.stationData.Add(SD);
          
            BL.datetime = DateTime.Now;

            BL.Report();

            BL.updateForm(this);
            gps.updateForm(this);
            WN.updateForm(this);
            env.updateForm(this);


        }

        private void StationID_TextChanged(object sender, EventArgs e)
        {

        }

        public void updateID(string idText)
        {
            this.StationID.Text = idText;
        
        }

        public void Method()
        {
            throw new System.NotImplementedException();
        }

        internal void updateStationName(string p)
        {
            this.StationName.Text = p;       
        }
 
        internal void updateLatitude(string p)
        {
            this.TBLatitude.Text = p;
        }

        internal void updateLongitude(string p)
        {
            this.TBLongitude.Text = p;
        }

        internal void updateWindSpeed(string p)
        {
            this.TBWindSpeed.Text = p;
        }

        internal void updateWindDirection(string p)
        {
            this.TBWinDir.Text = p;
        }

        internal void updateWindDateTime(string p)
        {
            this.TBWindDateTime.Text = p;  
        }

        internal void updateTemperature(string p)
        {
            this.TBEnvTemp.Text = p;
        }

        internal void updateHumidity(string p)
        {
            this.TBEnvHumid.Text = p;
        }
    }
}
