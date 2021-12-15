using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

class TriangleClass
{
    internal double a, b, c;
    public double angleA, angleB, angleC;
    public void SetSides(double a1, double b1, double c1)
    {
        a = a1;   b = b1; c = c1;
        
    }

    public double GetPerimetr()
    {
        return a + b + c;
    }

    public void CalculateAngles()
    {
        if (a == b && a == c)
        {
            angleA = angleB = angleC = 60;
        }
        else
        {
            angleA = Math.Round((Math.Acos((Math.Pow(b,2) + Math.Pow(c,2) - Math.Pow(a,2)) / (2 * b * c))*180)/Math.PI, 2);
            angleB = Math.Round((Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c))*180)/Math.PI, 2);
            angleC = Math.Round((Math.Acos((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b))*180)/Math.PI, 2);
        }

    }

    public bool IsEqual()
    {
        if (a == b && a == c )
        {
            return true;
        }
        else return false;
    }


}

internal class ETriangle : TriangleClass
{
    double square;

    public double CalculateSquare()
    {
        square = (Math.Pow(3, 1 / 3) / 4) * Math.Pow(a, 2);
        return square;
    }
}
namespace Triangle
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
