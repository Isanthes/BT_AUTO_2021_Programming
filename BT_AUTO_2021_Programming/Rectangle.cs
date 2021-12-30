using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Rectangle
    {
        double leangth;
        double width;

        public void SetSize (double leangth, double width)
        {
            this.leangth = leangth;
            this.width = width;
        }

        public double GetArea()
        {
            return leangth * width;
        } 

        public void PrintRectangle()
        {
            Console.WriteLine("The rectangle with length {0} and wigth {1} has area {2}", leangth, width, GetArea());
        }
    }
}
