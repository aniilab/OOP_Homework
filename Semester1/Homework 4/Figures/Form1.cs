using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    public partial class Figures : Form
    {
        Figure figure1;
        string type;
        public Figures()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            type = typeL.Text = "triangle";
            M1.Text = "A: ";
            M2.Text = "B: ";
            M3.Text = "C: ";

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            type = typeL.Text = "circle";
            M1.Text = "Radius:";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            type = typeL.Text = "rectangle";
            M1.Text = "A: ";
            M2.Text = "B: ";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            type = typeL.Text = "square";
            M1.Text = "A: ";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            type = typeL.Text = "rhomb";
            M1.Text = "A: ";
            M2.Text = "Angle A: ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (type == "rhomb")
                {
                    double a1 = Convert.ToDouble(textBox1.Text);
                    double an = Convert.ToDouble(textBox2.Text);
                    
                    if (an == 90)
                    {
                        MessageBox.Show("It is a square!");
                    }
                    else if (an < 180 && an > 0&& a1 > 0)
                    {
                        figure1 = new Rhomb(a1, an);
                    }
                    else
                    {
                        MessageBox.Show("Wrong data!");
                    }
                }
                else if (type == "triangle")
                {
                    double a1 = Convert.ToDouble(textBox1.Text);
                    double b1 = Convert.ToDouble(textBox2.Text);
                    double c1 = Convert.ToDouble(textBox3.Text);
                    if ((a1 + b1 > c1 && a1 + c1 > b1 && b1 + c1 > a1) &&
                        (a1 > 0 || b1 > 0 || c1 > 0))
                    {
                        figure1 = new Triangle(a1, b1, c1);
                    }
                    else
                    {
                        MessageBox.Show("Wrong numbers! It is impossible to create a triangle with these sides!");
                    }
                }
                else if (type == "circle")
                {
                    double r1 = Convert.ToDouble(textBox1.Text);
                    if (r1 > 0)
                    {
                        figure1 = new Circle(r1);
                    }
                    else
                    {
                        MessageBox.Show("Wrong data!");
                    }

                }
                else if (type == "rectangle")
                {
                    double a1 = Convert.ToDouble(textBox1.Text);
                    double b1 = Convert.ToDouble(textBox2.Text);
                    if (a1 == b1)
                    {
                        MessageBox.Show("It is a square!");
                    }
                    else if (a1 > 0 && b1 > 0)
                    {
                        figure1 = new Rectangle(a1, b1);
                    }
                    else
                    {
                        MessageBox.Show("Wrong data!");
                    }
                }
                else if (type == "square")
                {
                    double a1 = Convert.ToDouble(textBox1.Text);
                    if (a1 > 0)
                    {
                        figure1 = new Square(a1);
                    }
                    else
                    {
                        MessageBox.Show("Wrong data!");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Choose a figure first!");
                }
            }
            catch
            {
                MessageBox.Show("Wrong data!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (figure1.GetPerimetr() == 0)
                {
                    MessageBox.Show("Enter measurements first!");
                }
                else
                {
                    label7.Text = Convert.ToString(figure1.GetPerimetr()) + " cm";
                }
            }
            catch
            {
                MessageBox.Show("Choose a figure first!");
            }
            
            
        }

        private void Figures_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (figure1.GetSquare() == 0)
                {
                    MessageBox.Show("Enter measurements first!");
                }
                else
                {
                    label8.Text = Convert.ToString(figure1.GetSquare());
                }
            }
            catch
            {
                MessageBox.Show("Choose a figure first!");
            }
           
            
        }
    }
}
