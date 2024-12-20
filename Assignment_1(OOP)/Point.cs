using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_OOP_
{
    internal struct Point
    {
        #region Properties
        public int X;
        public int Y;
        #endregion
        #region Constructor
        public Point(int _X,int _Y)
        {
            X= _X;
            Y= _Y;
        }
        #endregion
        #region Methods
        public void Distance(Point p1, Point P2)
        {
            Console.WriteLine($"The Distance Between 2Points Is ({P2.X-p1.X},{P2.Y-p1.Y})");
        }
        #endregion
    }
}
