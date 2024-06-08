using System;
using System.Windows.Forms;

namespace DPM_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Retrieve input values
            if (!int.TryParse(minutesTextBox.Text, out int minutes))
            {
                MessageBox.Show("Please enter a valid number for minutes.");
                return;
            }

            if (!int.TryParse(secondsTextBox.Text, out int seconds))
            {
                MessageBox.Show("Please enter a valid number for seconds.");
                return;
            }

            if (!decimal.TryParse(damageTextBox.Text, out decimal totalDamage))
            {
                MessageBox.Show("Please enter a valid number for damage.");
                return;
            }

            if (!decimal.TryParse(guardedDamageTextBox.Text, out decimal guardedDamage))
            {
                MessageBox.Show("Please enter a valid number for guarded damage.");
                return;
            }

            // Calculate total time in minutes
            decimal totalTimeInMinutes = minutes + (seconds / 60m);

            // Validate time
            if (totalTimeInMinutes <= 0)
            {
                MessageBox.Show("Total time must be greater than zero.");
                return;
            }

            // Calculate damage per minute
            decimal damagePerMinute = totalDamage / totalTimeInMinutes;

            // Calculate guarded damage percentage
            decimal guardedPercentage = (guardedDamage / totalDamage) * 100;

            // Display result with formatted numbers
            resultLabel.Text = $"Damage per minute: {damagePerMinute:N2}";
            guardedPercentageLabel.Text = $"Guarded Damage: {guardedPercentage:N2}%";
            damageTextBox.Text = totalDamage.ToString("N0");
            guardedDamageTextBox.Text = guardedDamage.ToString("N0");
        }
    }
}
