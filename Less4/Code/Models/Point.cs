using System;

namespace Code.Models
{
    class Point
    {
        public int X {get; set;}
        private int y;

        public double Distance
        {
            get
            {
                return Math.Sqrt(X * X + y * y);
            }
        }       
        
    }
}