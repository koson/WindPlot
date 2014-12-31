using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindPlot
{
    public class Environment : IReport
    {
        double _temperature;
        double _humidity;
        DateTime _datetime;
        public double Temperature
        {
            get
            {
                return _temperature;
            }
            set
            {
                _temperature = value;
            }
        }

        public double Humidity
        {
            get
            {
                return _humidity;
            }
            set
            {
                _humidity = value;
            }
        }

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

        public void Report()
        {
            Console.WriteLine("Environment Temperature : " +  Temperature);
            Console.WriteLine("Environment Humidity : " +  Humidity);

        }

        internal void updateForm(Form1 form1)
        {
            form1.updateTemperature(Temperature.ToString());
            form1.updateHumidity(Humidity.ToString());
        }
    }
}
