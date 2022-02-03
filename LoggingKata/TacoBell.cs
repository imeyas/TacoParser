using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingKata
{
    public class TacoBell : ITrackable
    {
        private double parseToDoubleLat;
        private double parseToDoubleLon;

        public string Name { get; set; }
        public Point Location { get; set; }

        public TacoBell()
        {
            
        }

    
    }
}
