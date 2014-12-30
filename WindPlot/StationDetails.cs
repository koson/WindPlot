using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindPlot
{
    public class StationDetails : IReport
    {
        public GPS gps = new GPS();
        
        public void Report()
        {

            gps.Report();
        }
    }
}
