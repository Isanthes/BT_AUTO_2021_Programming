using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Square : Rectangle
    {
        double side;

        public double Side { get => side; set => side = value; }

        public Square(double side)
        {
            this.Side = side;
        }

        public Square()
        {

        }
        public void SetSide(double side)
        {
           this.Side = side;
        }

        public override double GetArea() 
        {
            return Math.Pow(Side, 2);
        }

        public void PrintSquare()
        {
            Console.WriteLine("The square with side {0} has the area {1}", Side, GetArea());
        }

        public override string ToString()
        {
            return "This is a square with side " + Side;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a square !");
        }
    }
}
