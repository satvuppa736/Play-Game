///This program was created by Satvir Uppal 
///on September 8th 2016
///Purpose: To complete the formative assignment
///

// changes comment for testing Github

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Play_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();          

        }

        private void playGameButton_Click(object sender, EventArgs e)
        {
            playGameButton.Visible = false;
            startingGameLabel.BackColor = Color.Transparent;
            startingGameLabel.ForeColor = Color.White;

            SoundPlayer player = new SoundPlayer(Properties.Resources.beep1);
            player.Play();

            Refresh();
            Thread.Sleep(1000);

            startingGameLabel.Text = "Starting in 2...";
            new SoundPlayer(Properties.Resources.beep1);
            player.Play();

            Refresh();
            Thread.Sleep(1000);

            new SoundPlayer(Properties.Resources.beep1);
            player.Play();
            startingGameLabel.Text = "Starting in 1...";

            Refresh();
            Thread.Sleep(1300);

            player = new SoundPlayer(Properties.Resources.airHorn);
            player.Play();
            BackColor = Color.DarkBlue;
            startingGameLabel.Visible = false;

//Setup for Graphics & Brushes & Pens
            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Blue);
            Graphics fg = this.CreateGraphics();

//Creates & fills an Ellipse
            formGraphics.DrawEllipse(drawPen, 140, 100, 200, 150);
            formGraphics.FillEllipse(drawBrush, 140, 100, 200, 150);

//Draws an "S" larger than other text
            Font drawFont = new Font("Sitka Text", 70, FontStyle.Bold);
            SolidBrush drawText = new SolidBrush(Color.Red);
            fg.DrawString("S", drawFont, drawText, 145, 115);

//Draws a smaller "ATVIR" beside the "S"
            drawFont = new Font("Dejavu Serif", 30, FontStyle.Regular);
            drawText = new SolidBrush(Color.Red);
            fg.DrawString("ATVIR", drawFont, drawText, 203, 150);

//Draws "Uppal Inc." turned 270 degrees & to the right of the Ellipse 
            drawFont = new Font("Courier Serif", 9, FontStyle.Regular);
            drawText = new SolidBrush(Color.Black);
            fg.TranslateTransform(350, 200); 
            fg.RotateTransform(270); 
            fg.DrawString("Uppal Inc.", drawFont, drawText, new Rectangle()); 
            fg.ResetTransform();

            Thread.Sleep(2000);

//Makes the entire screen black for a background for PacMan animation
            formGraphics.Clear(Color.Black);

            drawBrush = new SolidBrush(Color.Blue);
            drawPen = new Pen(Color.Blue);

            formGraphics.DrawRectangle(drawPen, 10, 80, 450, 50);
            formGraphics.FillRectangle(drawBrush, 10, 80, 450, 50);
            formGraphics.DrawRectangle(drawPen, 10, 210, 270, 50);
            formGraphics.FillRectangle(drawBrush, 10, 210, 270, 50);
            formGraphics.DrawRectangle(drawPen, 440, 130, 50, 450);
            formGraphics.FillRectangle(drawBrush, 440, 130, 50, 450);

        }
    }
}