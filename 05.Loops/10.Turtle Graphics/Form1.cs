using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace _10.Turtle_Graphics
{
    public partial class FormThurtleGraphics : Form
    {
        public FormThurtleGraphics()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Turtle.ShowTurtle)
            {
                Turtle.ShowTurtle = false;
                this.buttonShowHideTurtle.Text = "Show Turtle";
            }
            else
            {
                Turtle.ShowTurtle = true;
                this.buttonShowHideTurtle.Text = "Hide Turtle";

            }
        }
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Turtle.Rotate(30);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);


        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
        }

        private void buttonHexagon_Click(object sender, EventArgs e)
        {
            Turtle.Rotate(60);
            Turtle.Forward(100);
        }

        private void buttonHexagon_Click_1(object sender, EventArgs e)
        {
            Turtle.Rotate(60);
            Turtle.Forward(120);
        }

        private void buttonHexagon_Click_2(object sender, EventArgs e)
        {
            Turtle.Rotate(60);
            Turtle.Forward(120);
        }
    }
}
