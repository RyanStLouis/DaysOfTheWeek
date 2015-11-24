/*
* Created by: Ryan St. Louis
* Created on: 24-Nov-2015
* Created for: Unit #6-02
* This program uses an enum type to return the selected value
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaysOfTheWeek
{
    public partial class frmDaysOfTheWeek : Form
    {
        enum DAYS
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }

        public frmDaysOfTheWeek()
        {
            InitializeComponent();
        }

        private void frmDaysOfTheWeek_Load(object sender, EventArgs e)
        {
            foreach (DAYS singlePlanet in Enum.GetValues(typeof(DAYS)))
            {
                this.lstDays.Items.Add(singlePlanet);
            }
        }

        private void lstDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue;
            int dayNumber;
            DAYS selectedDay;

            selectedValue = Convert.ToString(this.lstDays.SelectedItem);
            selectedDay = (DAYS)Enum.Parse(typeof(DAYS), selectedValue, true);
            dayNumber = (int)(selectedDay);
            MessageBox.Show("The current day is: " + selectedDay + " = " + dayNumber);
        }
    }
}
