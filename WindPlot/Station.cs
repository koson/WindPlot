using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindPlot
{
    public class Station
    {
        private DateTime _datetime;
        private string _name;
        private string _id;

        /// <summary>
        /// Properties
        /// </summary>
        public DateTime datetime
        {
            get
            {
                return _datetime;
            }
            set
            {
                _datetime = value;
            }
        }

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        /// <summary>
        /// aggregated data
        /// </summary>
        public List <StationData>  stationData = new  List <StationData> ();
        public StationDetails stationDetails = new StationDetails();

        /// <summary>
        /// Helper methods
        /// </summary>
        public void Report()
        {
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Name : " + name);
            stationDetails.Report();
            stationData.ForEach(report);
        }

        private static void report(StationData s)
        {
            s.Report();
        }
        //public void ReportData()
        //{
        //    stationData.Report();
        //}
    }
}
