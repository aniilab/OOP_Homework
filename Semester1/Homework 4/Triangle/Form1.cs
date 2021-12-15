using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class Form1 : Form
    {
        TriangleClass tri = new TriangleClass();
        ETriangle etri = new ETriangle();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a1 = Convert.ToDouble(textBox1.Text);
                double b1 = Convert.ToDouble(textBox2.Text);
                double c1 = Convert.ToDouble(textBox3.Text);
                if ((a1 + b1 > c1 && a1 + c1 > b1 && b1 + c1 > a1)&&
                    (a1>0||b1>0||c1>0))
                {
                    tri.SetSides(a1, b1, c1);
                    if (tri.IsEqual())
                    {
                        etri.SetSides(a1, b1, c1);
                    }
                    label9.Text = "Success!";
                }
                else
                {
                    MessageBox.Show("Wrong numbers! It is impossible to create a triangle with these sides!");
                }
            }
            catch
            {
                MessageBox.Show("Wrong data!");
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tri.GetPerimetr() > 0)
            {
                label10.Text = Convert.ToString(tri.GetPerimetr()) + " cm";
            }
            else
            {
                MessageBox.Show("Enter measurements first!");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tri.GetPerimetr() > 0)
            {
                tri.CalculateAngles();
                label11.Text = "Angle A: " + Convert.ToString(tri.angleA) +
                         "\nAngle B: " + Convert.ToString(tri.angleB) +
                         "\nAngle C: " + Convert.ToString(tri.angleC);
            }
            else
            {
                MessageBox.Show("Enter measurements first!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tri.GetPerimetr() > 0)
            {
                if (tri.IsEqual())
                {
                    label12.Text = "Yes!";
                    
                    label13.Text = "Square: " + etri.CalculateSquare();
                }
                else { label12.Text = "No!"; }
            }
            else
            {
                MessageBox.Show("Enter measurements first!");
            }
        }
    }
}
