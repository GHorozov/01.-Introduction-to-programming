using Nakov.TurtleGraphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15.SpiralTriangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Turtle.PenColor = Color.Red;
            for (int i = 0; i < 25; i++)
            {
                Turtle.Forward(i * 10);
                Turtle.Rotate(120);
                Turtle.Forward(i * 10);
                Turtle.Rotate(120);
            }
            Turtle.Rotate(120);
            for (int i = 0; i < 25; i++)
            {
                Turtle.Forward(i * 10);
                Turtle.Rotate(120);
                Turtle.Forward(i * 10);
                Turtle.Rotate(120);
            }
            Turtle.Forward(250);
            for (int i = 0; i < 25; i++)
            {
                Turtle.Forward(i * 10);
                Turtle.Rotate(120);
                Turtle.Forward(i * 10);
                Turtle.Rotate(120);
            }
        }
    }
}
