using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTimer
{
    public partial class Form1 : Form
    {
        private const String POMODORO = "Pomodoro"; // Pomodoro text for the label
        private const String BREAK = "Break"; // Break text for the label
        private const int MINUTES = 25;  // amount of time for a pomodoro
        private const int BREAK_MINUTES = 5; // amount of time for a break;
        private int time; // how many seconds are left in the current pomodoro or break
        private bool isRunning, isBreakTime; // keep track of whether the timer is running and whether we're on a break
        
        public Form1()
        {
            InitializeComponent();
            time = MINUTES * 60; // convert to seconds
            isRunning = false;
            isBreakTime = false;
            UpdateTimeLabel();
        }

        /// <summary>
        /// Updates the timer label to display the current time.
        /// Uses the StringBuilder class to create a representation of how much time is left on the timer.
        /// </summary>
        private void UpdateTimeLabel()
        {
            StringBuilder sb = new StringBuilder();
            int seconds = time % 60;
            sb.Append(time / 60).Append(':');

            if (seconds >= 10)
            {
                sb.Append(seconds);
            } else if (seconds > 0)
            {
                sb.Append('0').Append(seconds); // add a 0 in front of seconds if between 0 and 10
            } else
            {
                sb.Append(seconds).Append('0'); // add an extra 0 if there are 0 seconds
            }
            timerLabel.Text = sb.ToString();
        }

        /// <summary>
        /// Handles click events from the Start/Pause button.
        /// Starts or stops the timer and updates the button's text to reflect its state.
        /// </summary>
        /// <param name="sender">Contains a reference to the object that raised the event</param>
        /// <param name="e">Event data</param>
        private void Button_Click(object sender, EventArgs e)
        {
            isRunning = !isRunning;

            if (isRunning)
            {
                timer1.Start();
                startBtn.Text = "Pause";
            } else
            {
                timer1.Stop();
                startBtn.Text = "Start";
            }
            
        }

        /// <summary>
        /// Handles the timer tick event which fires every second.
        /// Each time the timer ticks, time is decremented.
        /// If time reaches 0, we check to see if we're finishing a pomodoro or a break and reset the timer accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time--;
            } else
            {
                System.Media.SystemSounds.Beep.Play();

                if (!isBreakTime)
                {
                    time = BREAK_MINUTES * 60; // set to 5 minute break (in seconds)
                    pomodoro.Text = BREAK;
                } else
                {
                    time = MINUTES * 60; // reset to original time
                    pomodoro.Text = POMODORO;
                }
                isBreakTime = !isBreakTime;
            }
            UpdateTimeLabel();
        }
    }
}
