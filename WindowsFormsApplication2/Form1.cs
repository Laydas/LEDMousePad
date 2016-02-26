using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        double redMax;
        double greenMax;
        double blueMax;
        System.Drawing.SolidBrush currentColor;
        System.Drawing.SolidBrush defaultColor;
        System.Drawing.Color solidColor;
        public Form1()
        {
            InitializeComponent();
            redMax = Convert.ToInt32(labelValRed.Text);
            greenMax = Convert.ToInt32(labelValGreen.Text);
            blueMax = Convert.ToInt32(labelValBlue.Text);
            int red = Convert.ToInt32(redMax);
            int green = Convert.ToInt32(greenMax);
            int blue = Convert.ToInt32(blueMax);
            solidColor = Color.FromArgb(255, red, green, blue);
            currentColor = new System.Drawing.SolidBrush(solidColor);
            defaultColor = new System.Drawing.SolidBrush(Color.FromArgb(255,0,0,0));
            buttonColor.BackColor = solidColor;
        }

        private void comboEffects_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;

            textEffects.Text = senderComboBox.SelectedItem.ToString();
            if (senderComboBox.SelectedItem.ToString() == "Rainbow")
            {
                trackBreath.Visible = false;
                DisableBreath();
                labelPulseSpeed.Visible = false;
            }
            else if (senderComboBox.SelectedItem.ToString() == "Breathing")
            {
                labelPulseSpeed.Visible = true;
                trackBreath.Visible = true;
                trackBreath.Value = 25;
                InitializeTimer();
            }
            else if (senderComboBox.SelectedItem.ToString() == "None")
            {
                trackBreath.Visible = false;
                DisableBreath();
                labelPulseSpeed.Visible = false;
            }
        }

        private void trackBreath_Scroll(object sender, EventArgs e)
        {
            Timer1.Interval = trackBreath.Value;
        }

        private int counter;
        private bool goingUp = true;


        private void InitializeTimer()
        {
            counter = 0;
            Timer1.Interval = trackBreath.Value;
            Timer1.Enabled = true;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
        }

        private void Timer1_Tick(object sender, System.EventArgs e)
        {

            if (goingUp == true)
            {
                counter++;
                if (counter > 100)
                {
                    counter = 100;
                    goingUp = false;
                }
            }
            else
            {
                counter--;
                if (counter < 1)
                {
                    counter = 1;
                    goingUp = true;
                }
            }
            int red = Convert.ToInt32(counter * (redMax / 100));
            int green = Convert.ToInt32(counter * (greenMax / 100));
            int blue = Convert.ToInt32(counter * (blueMax / 100));
            labelValRed.Text = red.ToString();
            labelValGreen.Text = green.ToString();
            labelValBlue.Text = blue.ToString();
        }

        private void DisableBreath()
        {
            Timer1.Enabled = false;
            labelValRed.Text = redMax.ToString();
            labelValGreen.Text = greenMax.ToString();
            labelValBlue.Text = blueMax.ToString();

        }

        System.Drawing.Graphics formGraphics;
        private void buttonColor_Click(object sender, EventArgs e)
        {
            
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(currentColor, new Rectangle(0, 0, 200, 300));
            
        }
    }
}
