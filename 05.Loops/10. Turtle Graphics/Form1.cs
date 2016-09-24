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

namespace _10.Turtle_Graphics
{
    public partial class FormTurtleGraphics : Form
    {
        public FormTurtleGraphics()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 100;
            for (int i = 0; i < 10; i++)
            {
                Turtle.Forward(i * 10);
                Turtle.Rotate(80);
            }
        }
        
        private void buttonReset_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
        }

        private void buttonShowHideTurtle_Click(object sender, EventArgs e)
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

        private void buttonHexagon_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 100;
            for (int i = 0; i < 6; i++)
            {
                Turtle.Rotate(60);
                Turtle.Forward(100);
            }
        }

        private void buttonStar_Click(object sender, EventArgs e)
        {
            Turtle.PenColor = Color.Green;
            Turtle.Delay = 100;
            for (int i = 0; i < 5; i++)
            {
                Turtle.Forward(200);
                Turtle.Rotate(144);
            }
        }

        private void buttonSpiral_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 100;
            for (int i = 0; i < 20; i++)
            {
                Turtle.Forward(i * 10);
                Turtle.Rotate(60);
            }
        }
    }
}

