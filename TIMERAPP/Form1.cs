using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIMERAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //write C# codes to display the time on "timer" label
            int currentTime = Convert.ToInt32(timer_elapsed.Text);
            //invremtnt the current time
            currentTime ++;
            //display new time
            timer_elapsed.Text = currentTime.ToString();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            //Kick off the time
            timer_elapsed.Text = "0";
            //start the timer
            gameTimer.Enabled = true;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            //stop the timer
            gameTimer.Enabled = false;
        }
    }
}
