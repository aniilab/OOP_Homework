using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


abstract class Triangle
{
    protected double a=0, b=0, angleC=0;

    public virtual double CalculateSquare()
    {
        return 0;
    }
    public virtual double CalculatePerimetr()
    {
        return 0;
    }
}

class RightTriangle : Triangle
{

    public RightTriangle(double a1, double b1, double c1)
    {
        a = a1;   b = b1;   angleC = c1;
    }
    public override double CalculateSquare()
    {
        if (angleC == 90)
        {
            return Math.Round(0.5 * a * b,2);
        }
        else
        {
            double c = Math.Sqrt(Math.Pow(Math.Max(a, b), 2) - Math.Pow(Math.Min(a, b), 2));
            return Math.Round(0.5 * Math.Min(a, b) * c, 2);
        }
    }
    public override double CalculatePerimetr()
    {
        double c = Math.Sqrt(Math.Pow(Math.Max(a, b), 2) - Math.Pow(Math.Min(a, b), 2));
        return Math.Round(a + b + c, 2);
    }
}

class IsoscelesTriangle : Triangle
{
    public IsoscelesTriangle(double a1, double b1, double c1)
    {
        a = a1; b = b1; angleC = c1;
    }
    public override double CalculateSquare()
    {
        if (a == b)
        {
            return Math.Round(0.5 * a * a * Math.Sin(angleC * Math.PI / 180), 2);
        }
        else return Math.Round(0.5 * a * b * Math.Sin(angleC * Math.PI / 180), 2);
    }
    public override double CalculatePerimetr()
    {
        double c = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(angleC * Math.PI / 180));
        if (a == b)
        {
            return Math.Round(2 * a + c, 2);
        }
        else if (a == c)
        {
            return Math.Round(2 * a + b, 2);
        }
        else return Math.Round(2 * b + a, 2);
    }
}
namespace TriangleType
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
            Application.Run(new Form1());
        }
    }
}
