using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindPlot
{
    public class StationData : IReport
    {
        public Wind wind = new Wind();
        public DateTime datetime
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
        public Environment environment = new Environment();

        public void Report()
        {
            wind.Report();
            environment.Report();
        }
    }
}
