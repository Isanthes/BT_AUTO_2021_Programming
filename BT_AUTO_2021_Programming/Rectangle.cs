using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Rectangle : Shape
    {
        double leangth;
        double width;

        public Rectangle (double leangth, double width)
        {
            this.leangth = leangth;
            this.width = width;
        }
        public Rectangle()
        {

        }

        public double GetLength()
        {
            return leangth;
        }

        public void SetLength(double leangth)
        {
            if (leangth > 0)
            { 
                this.leangth = leangth; 
            }
            else
            {
                Console.WriteLine("You cannot set length to a negative number !!!");
            }
        }


        public void SetSize (double leangth, double width)
        {
            this.leangth = leangth;
            this.width = width;
        }

        public virtual double GetArea()
        {
            return leangth * width;
        } 

        public virtual double GetPerimeter()
        {
            return 2 * (leangth + width);
        }
        public virtual double GetDiagonal()
        {
            return Math.Sqrt(Math.Pow(width, 2) + Math.Pow(leangth, 2));
        }

        public void PrintRectangle()
        {
            Console.WriteLine("The rectangle with length {0} and wigth {1} has area {2}", leangth, width, GetArea());
            Console.WriteLine("Area is {0} Perimeter is {1} Diagonal is {2}", GetArea(), GetPerimeter(), GetDiagonal());
        }

        public override string ToString()
        {
            return "This is a rectangle with " + width + " width and " + leangth + " leangth !!";
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle!");
        }
    }
}
