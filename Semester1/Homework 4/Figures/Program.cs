using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


abstract class Figure
{
    
    public virtual double GetPerimetr()
    {
        return 0;
    }

    public virtual double GetSquare()
    {
        return 0;
    }
}

class Triangle : Figure
{
    double a, b, c;
    public Triangle(double a1, double b1, double c1)
    {
        a = a1;   b = b1;   c = c1;
    }
    public override double GetPerimetr()
    {
        return a + b + c;
    }
    public override double GetSquare()
    {
        double angleA = Math.Round((Math.Acos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c)) * 180) / Math.PI, 2);
        return Math.Round((Math.Sin(angleA * Math.PI / 180) * b * c) / 2, 2);
    }
}

class Circle : Figure
{
    double r;
    public Circle(double r1)
    {
        r = r1;
    }
    public override double GetPerimetr()
    {
        return Math.Round(2*r*Math.PI,2);
    }
    public override double GetSquare()
    {
        return Math.Round(r * r * Math.PI,2);
    }
}

class Rectangle : Figure
{
    double a, b;
    public Rectangle(double a1, double b1)
    {
        a = a1;   b = b1;
    }
    public override double GetPerimetr()
    {
        return 2*(a + b);
    }
    public override double GetSquare()
    {
        return a * b;
    }
}


class Square : Figure
{
    double a;
    public Square(double a1)
    {
        a = a1;
    }
    public override double GetPerimetr()
    {
        return 4*a;
    }
    public override double GetSquare()
    {
        return a * a;
    }

}

class Rhomb : Figure
{
    double a, angle;
    public Rhomb(double a1, double an)
    {
        a = a1; angle = an;
    }
    public override double GetPerimetr()
    {
        return 4*a;
    }
    public override double GetSquare()
    {
        return Math.Round(a * a * Math.Sin(angle*Math.PI/180), 2);
    }
}

namespace Figures
{
    
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Figures());
        }
    }
}
