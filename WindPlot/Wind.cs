using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindPlot
{
    public class Wind : IReport
    {
        private DateTime _datetime;
        private double _speed;
        private int _direction;
    
        public int direction
        {
            get
            {
                return _direction;
            }
            set
            {
                _direction = value;
            }
        }

        public double speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
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
            Console.WriteLine("Wind Speed : " +  speed);
            Console.WriteLine("Wind Direction : " +  direction);
            Console.WriteLine("Wind DateTime : " +  datetime.ToString());
        }
    }
}
