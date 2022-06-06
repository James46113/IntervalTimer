using System;
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
                if (countdown <= 0f & counts.Count > 0)
                {
                    countdown = counts[ind];
                    counts.Remove(countdown);
                    countsBox.Items.RemoveAt(0);
                }
                //counts.Remove(countdown);
                //Console.WriteLine(countdown);
                timer1.Enabled = true;
                startButton.Text = "Stop";
                label1.Text = label1.Text = Math.Floor(countdown / 60).ToString("00") + ":" + Math.Floor(countdown % 60).ToString("00");
            }

        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            string secs = Math.Floor(countdown % 60).ToString("00");

            //if ((Math.Floor(countdown % 60)).ToString().Length == 1)
            //{
            //    secs = "0" + Math.Floor(countdown % 60).ToString();
            //}

            label1.Text = Math.Floor(countdown / 60).ToString("00") + ":" + secs;
            if (countdown <= 0f)
            {
                foreach (int ting in counts)
                {
                    //Console.WriteLine(ting);
                }
                //Console.WriteLine(counts.Count);
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
                timer1.Enabled = false;
                startButton.Text = "Start";
            }
            else 
            {
                countdown -= 1;
            }
            //Console.WriteLine(Math.Floor(countdown / 60).ToString() + ":" + secs);

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
            //Console.WriteLine(tempTime);

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
            //Console.WriteLine(tempCount);

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
            //Console.WriteLine(tempCount);

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
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

        private void next()
        {
            if (counts.Count > 0)
            {
                countdown = counts[ind];
                counts.Remove(countdown);
                countsBox.Items.RemoveAt(0);
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
            tempCount = 0;
            tempTime.Text = "0:00";
            countsBox.Items.Clear();
            counts.Clear();
        }

        private void resetAllButton_Click(object sender, EventArgs e)
        {
            counts.Clear();
            countsBox.Items.Clear();
            label1.Text = "0:00";
            timer1.Enabled = false;
            startButton.Text = "Start";
            countdown = 0f;
            tempCount = 0f;
            tempTime.Text = "0:00";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (tempCount > 0)
            {
                counts.Add(tempCount);
                foreach (int ting in counts)
                {
                    //Console.WriteLine(ting);
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
                tempTime.Text = "0:00";
            }
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            if (counts.Count > 0)
            {
                try
                {
                    foreach (int item in counts)
                    {
                        //Console.WriteLine(item);
                    }
                    countdown = counts[ind];
                    //Console.WriteLine(countdown);
                    countsBox.Items.RemoveAt(0);
                }
                catch (Exception)
                {
                    timer1.Enabled = false;
                    countdown = 0;
                    label1.Text = "0:00";
                }
            }
        }
    }
}
