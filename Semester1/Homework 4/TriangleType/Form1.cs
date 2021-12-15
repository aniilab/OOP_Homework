using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleType
{
    public partial class Form1 : Form
    {
        Triangle tri;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a1 = Convert.ToDouble(sideAbox.Text);
                double b1 = Convert.ToDouble(sideBbox.Text);
                double anglec1 = Convert.ToDouble(angleCbox.Text);
                double c1 = Math.Round(Math.Sqrt(a1 * a1 + b1 * b1 - 2 * a1 * b1 * Math.Cos(anglec1 * Math.PI / 180)),2);
                if ((a1 + b1 > c1 && a1 + c1 > b1 && b1 + c1 > a1) &&
                            (a1 > 0 && b1 > 0 && anglec1 > 0 && anglec1 < 180))
                {
                    SuccessLabel.Text = "Success!";
                    if (anglec1 == 90 || a1 * a1 == b1 * b1 + c1 * c1 ||
                                         b1 * b1 == a1 * a1 + c1 * c1 ||
                                         c1 * c1 == a1 * a1 + b1 * b1)
                    {
                        tri = new RightTriangle(a1, b1, anglec1);
                        label6.Text = "right";
                    }
                    else if ((a1 == b1 && a1 != c1) || (a1 == c1 && a1 != b1) || (b1 == c1 && b1 != a1))
                    {
                        tri = new IsoscelesTriangle(a1, b1, anglec1);
                        label6.Text = "isosceles";
                    }
                    else
                    {
                        label6.Text = "other";
                    }
                }
                else
                {
                    MessageBox.Show("Wrong numbers! It is impossible to create a triangle with these sides!");
                }
            }
            catch
            {
                MessageBox.Show("Wrong data");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double p = tri.CalculatePerimetr();
                if (p > 0)
                {
                    PerimetrLabel.Text = Convert.ToString(p) + " cm";
                }
                else
                {
                    MessageBox.Show("Enter measurements first!");
                }
            }
            catch
            {
                MessageBox.Show("ERROR: perimetr only for right or isosceles triangles!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double s = tri.CalculateSquare();
                if (s > 0)
                {
                    SquareLabel.Text = Convert.ToString(s) + " square cm";
                }
                else
                {
                    MessageBox.Show("Enter measurements first!");
                }
            }
            catch
            {
                MessageBox.Show("ERROR: square only for right or isosceles triangles!");
            }
        }
    }
}
