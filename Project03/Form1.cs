using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project03
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Exit Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close out of program
            this.Close();

        }

        /// <summary>
        /// About Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Provides a messagebox displaying programmers name and class
            MessageBox.Show("Matthew Vaughan\nCS1400 Section 003\nProject #2");
        }

        /// <summary>
        /// Calculation Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e)
        {
            //Declare a constant
            const double PERCENT = 0.25;
            const int HOURS_MIN = 60;
            const int HUNDRED = 100;

            //Store info of start and old end times
            int startTime = int.Parse(txtStart.Text);
            int oldEnd = int.Parse(txtOldEnd.Text);

            //Convert start time hours to minutes
            int hourStart = startTime / HUNDRED;
            int startHoursToMin = hourStart * HOURS_MIN;

            //Find start minutes and add on hours minutes
            int minStart = startTime % HUNDRED;
            int totalMinStart = startHoursToMin + minStart;

            //Convert Old hours to min
            int hourOld = oldEnd / HUNDRED;
            int oldHoursToMin = hourOld * HOURS_MIN;

            //Find old minutes and add on the hours to minutes
            int minOld = oldEnd % HUNDRED;
            int totalMinOld = oldHoursToMin + minOld;

            //Subtract the total min of the start time from the total min of the old end time to find old ETA
            int oldETA = totalMinOld - totalMinStart;

            //Find the new ETA by multiplying the old ETA by PERCENT and adding it to the old ETA
            int newETA = (int)(oldETA * PERCENT) + totalMinOld;

            //Take the new arrival and convert it back into military time and add the old minutes and hours on 
            int hourNew = newETA / HOURS_MIN;
            int minNew = newETA % HOURS_MIN;

            //Display the new ETA in the new arrival text box
            string newestArrival = ($"{hourNew:00}{minNew:00}");
            txtNewEnd.Text = newestArrival;

        }
    }
}
