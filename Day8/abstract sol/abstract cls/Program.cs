using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_cls
{
    internal class Program
    {
        static void Main(string[] args)
        {
        public int Dimension;
        public abstract double Area()
        public abstract double perimeter()
        }
    }
    class square : Program
    {
        public override double Area()
        {
            return Dimension * Dimension;
        }
        public override double perimeter()
        {
            return 4 * Dimension;
        }
    }
    class Circle : Program
    {
        public override double Area()
        {
            return Math.PI * Dimension * Dimension;
        }
        public override double perimeter()
        {
            return (2 * Dimension) * Dimension;
        }
    }
    
class program

{
    static void Main(string[] args)
    {
        program fig = new square();
        fig.Dimension = 10;
        Console.WriteLine(fig.Area);
        Console.WriteLine(fig.Perimeter);
    }
}
}