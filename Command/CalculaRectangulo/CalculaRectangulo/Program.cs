﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaRectangulo
{
    /*
     *   C# Program to Display Cost of a Rectangle Plot Using Inheritance
     *   */

    class Rectangle
    {
        protected double length;
        protected double width;
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }

    class Tabletop : Rectangle
    {
        private double cost;
        public Tabletop(double l, double w)
            : base(l, w)
        { }

        public double costcal(double precio)
        {
            double cost;
            cost = GetArea() * precio;
            return cost;
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine("Cost: {0}", costcal());
        }

    }

    class CalRectangle

    {

        static void Main(string[] args)

        {

            Tabletop t = new Tabletop(7.5, 8.03);

            t.Display();

            Console.ReadLine();

        }
    }
}
