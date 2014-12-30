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
            Station BL = new Station() { name = "BL", id = "006"};
            StationData SD = new StationData() ;
            Wind WN = new Wind();
            WN.direction = 2;
            WN.speed = 1.2;
            SD.wind = WN;
            BL.stationData.Add(SD);
          
            BL.datetime = DateTime.Now;

            BL.Report();
        }

        //private static void Print(StationData s)
        //{
        //    s.Report();
        //}
    }
}
