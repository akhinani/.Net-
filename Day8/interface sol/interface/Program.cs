using @interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    interface IFigure
    {
        int Dimension { get; set; }
        double Area();
        double perimeter();
    }
    class circle : IFigure
    {
        private int _Radius;
        public int Dimension
        {
            get { return _Radius; }
            set { _Radius = value; }
        }
        public double Area()
        {
            return Math.PI * _Radius * _Radius;
        }
        public double perimeter()
        {
            return 2 * Math.PI * _Radius;
        }
    }
    class Square : IFigure
    {
        private int side;
        public int Dimension
        {
            get { return side; }
            set { side = value; }
        }
        public double Area()
        {
            return side * side;
        }
        public double perimeter()
        {
            return 4 * side;
        }
    }
    class program
    {
        static void main(string[] args)
        {
            IFigure fig = null;
            Console.WriteL 

        }
    }
}
