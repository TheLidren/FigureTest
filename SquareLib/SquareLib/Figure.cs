using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLib
{
    public class Figure
    {
        protected double area;
        protected string? s;
        public virtual void Area()
        {
            Console.WriteLine($"Area");
        }
    }
    public class Triangle : Figure
    {
        private int a, b, c;
        public Triangle(int a, int b, int c) 
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }  
        public override void Area()
        {
            if (Math.Pow(a, 2) == Math.Pow(b + c, 2) || Math.Pow(b, 2) == Math.Pow(a + c, 2) || Math.Pow(c, 2) == Math.Pow(b + a, 2))
                Console.WriteLine("Right triangle");
            int p = (a + b + c) / 2;
            area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Area of triangle = {area:F3}");
        }
    }
    public class Circle : Figure
    {
        public override void Area()
        {
            Console.Write("Enter r = ");
            s = Console.ReadLine();
            if (!int.TryParse(s, out int r))
                throw new Exception("U enter incorrectly number");
            area = Math.PI * r;
            Console.WriteLine($"Area of circle = {area:F2}");
        }
    }
    public class Square : Figure
    {
        public override void Area()
        {
            Console.Write("Enter a = ");
            s = Console.ReadLine();
            if (!int.TryParse(s, out int a))
                throw new Exception("U enter incorrectly number");
            area = Math.Pow(a, 2);
            Console.WriteLine($"Area of circle = {area}");
        }
    }


}
