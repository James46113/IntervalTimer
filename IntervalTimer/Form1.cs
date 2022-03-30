﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntervalTimer
{
    public partial class Form1 : Form
    {
        float countdown = 0f;
        float tempCount = 0f;
        List<float> counts = new List<float>();
        int ind = 0;
        public Point MouseDownLocation;
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                startButton.Text = "Start";
            }
            else
            {
                countdown = counts[ind];
                //counts.Remove(countdown);
                Console.WriteLine(countdown);
                timer1.Enabled = true;
                startButton.Text = "Stop";
                countsBox.Items.RemoveAt(0);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countdown -= 1;

            string secs = Math.Floor(countdown % 60).ToString();

            if ((Math.Floor(countdown % 60)).ToString().Length == 1)
            {
                secs = "0" + Math.Floor(countdown % 60).ToString();
            }

            label1.Text = Math.Floor(countdown / 60).ToString() + ":" + secs;
            if (countdown == 0f)
            {
                foreach (int ting in counts)
                {
                    Console.WriteLine(ting);
                }
                Console.WriteLine(counts.Count);
                if (counts.Count > 0)
                {
                    try
                    {
                        countdown = counts[ind];
                        countsBox.Items.RemoveAt(0);
                    }
                    catch (Exception)
                    {
                        timer1.Enabled = false;
                    }
                }
                //timer1.Enabled = false;
                //startButton.Text = "Start";
            }
            Console.WriteLine(Math.Floor(countdown / 60).ToString() + ":" + secs);

        }

        private void add60_Click(object sender, EventArgs e)
        {
            if (tempCount + 300 <= 3540)
            {
                tempCount += 300;
            }
            else
            {
                tempCount += 3600 - tempCount;
            }

            string secs = Math.Floor(tempCount % 60).ToString();

            if ((Math.Floor(tempCount % 60)).ToString().Length == 1)
            {
                secs = "0" + Math.Floor(tempCount % 60).ToString();
            }

            tempTime.Text = Math.Floor(tempCount / 60).ToString() + ":" + secs;
            Console.WriteLine(tempTime);

        }

        private void add30_Click(object sender, EventArgs e)
        {
            if (tempCount + 120 <= 3540)
            {
                tempCount += 120;
            }
            else
            {
                tempCount += 3600 - tempCount;

            }
            string secs = Math.Floor(tempCount % 60).ToString();

            if ((Math.Floor(tempCount % 60)).ToString().Length == 1)
            {
                secs = "0" + Math.Floor(tempCount % 60).ToString();
            }

            tempTime.Text = Math.Floor(tempCount / 60).ToString() + ":" + secs;
            Console.WriteLine(tempCount);

        }

        private void add10_Click(object sender, EventArgs e)
        {
            if (tempCount + 30 <= 3540)
            {
                tempCount += 30;
            }
            else
            {
                tempCount += 3600 - tempCount;
            }

            string secs = Math.Floor(tempCount % 60).ToString();

            if ((Math.Floor(tempCount % 60)).ToString().Length == 1)
            {
                secs = "0" + Math.Floor(tempCount % 60).ToString();
            }
            tempTime.Text = Math.Floor(tempCount / 60).ToString() + ":" + secs;
            Console.WriteLine(tempCount);

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            countdown = 0;
            label1.Text = Math.Round(countdown, 1).ToString() + ":00";
            startButton.Text = "Start";
        }

        private void Mouse_Down(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void Mouse_Move(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }

        private void TimerForm_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_Down(e);
        }

        private void TimerForm_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse_Move(e);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_Down(e);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse_Move(e);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_Down(e);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {

        }

        private void resetAllButton_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            counts.Add(tempCount);
            foreach (int ting in counts)
            {
                Console.WriteLine(ting);
            }
            if ((Math.Floor(tempCount % 60)).ToString().Length == 1)
            {
                countsBox.Items.Add(Math.Floor(tempCount / 60).ToString() + ":" + "0" + Math.Floor(tempCount % 60).ToString());
            }
            else
            {
                countsBox.Items.Add(Math.Floor(tempCount / 60).ToString() + ":" + Math.Floor(tempCount % 60).ToString());
            }
            tempCount = 0;
            tempTime.Text = "";
        }
    }
}
