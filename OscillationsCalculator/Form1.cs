namespace OscillationsCalculator
{
    using System;
    using System.Net.Security;
    using System.Windows.Forms;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComboBoxItems();
            InitializePanels();
            InitializeInputHandlers();
        }

        private void InitializeComboBoxItems()
        {
            comboBox2.Items.Add("Simple Harmonic Oscillations");
            comboBox2.Items.Add("Period");
            comboBox2.Items.Add("Frequency");
            comboBox2.Items.Add("Amplitude");
        }

        private void InitializeInputHandlers()
        {
            force.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            springconstant.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            displacement.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            freq.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            time.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            energy.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            springconst.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            amp.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            submit.Click += new EventHandler(simpleHarmonic);
            submit2.Click += new EventHandler(periodCalculation);
            submit3.Click += new EventHandler(FrequencyCalculation);
            submit4.Click += new EventHandler(AmplitudeCalculation);
            close1.Click += new EventHandler(Close1_Click);
            close2.Click += new EventHandler(Close1_Click);
            close3.Click += new EventHandler(Close1_Click);
            close4.Click += new EventHandler(Close1_Click);
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control characters (like backspace) and digits
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == '.')
            {
                // Allow one decimal point
                if (e.KeyChar == '.' && ((sender as TextBox).Text.Contains(".")))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Close1_Click(object sender, EventArgs e)
        {
            try
            {
                // Close the currently visible panel
                if (panel2.Visible)
                {
                    panel2.Visible = false;
                }
                else if (panel3.Visible)
                {
                    panel3.Visible = false;
                }
                else if (panel4.Visible)
                {
                    panel4.Visible = false;
                }
                else if (panel5.Visible)
                {
                    panel5.Visible = false;
                }
            }
            catch (Exception ex)
            {
                // Log or display the exception
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializePanels()
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hide all panels first
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;

            // Show the selected panel
            string selectedItem = comboBox2.SelectedItem.ToString();
            switch (selectedItem)
            {
                case "Simple Harmonic Oscillations":
                    panel2.Visible = true;
                    break;
                case "Period":
                    panel3.Visible = true;
                    break;
                case "Frequency":
                    panel4.Visible = true;
                    break;
                case "Amplitude":
                    panel5.Visible = true;
                    break;
            }
        }

        private void simpleHarmonic(object sender, EventArgs e)
        {
            double forceValue, springConstant, displacementValue;

            bool isForceValid = double.TryParse(force.Text, out forceValue);
            bool isSpringConstantValid = double.TryParse(springconstant.Text, out springConstant);
            bool isDisplacementValid = double.TryParse(displacement.Text, out displacementValue);

            if (isSpringConstantValid && isDisplacementValid && !isForceValid)
            {
                // Calculate force: F = -k * x
                forceValue = -springConstant * displacementValue;
                answer.Text = $"Force (F) = {Math.Round(forceValue, 2)} N";
            }
            else if (isForceValid && isDisplacementValid && !isSpringConstantValid)
            {
                // Calculate spring constant: k = -F / x
                springConstant = -forceValue / displacementValue;
                answer.Text = $"Spring Constant (k) = {Math.Round(springConstant, 2)} N/m";
            }
            else if (isForceValid && isSpringConstantValid && !isDisplacementValid)
            {
                // Calculate displacement: x = -F / k
                displacementValue = -forceValue / springConstant;
                answer.Text = $"Displacement (x) = {Math.Round(displacementValue, 2)} m";
            }
            else
            {
                answer.Text = "Please enter exactly two values.";
            }
        }

        private void periodCalculation(object sender, EventArgs e)
        {
            double frequency, period;
            bool isFrequencyValid = double.TryParse(freq.Text, out frequency);

            if (isFrequencyValid && frequency != 0)
            {
                period = 1 / frequency;
                periodAns.Text = $"Period = {Math.Round(period, 2)} s";
            }
            else
            {
                periodAns.Text = "Please enter a valid non-zero frequency.";
            }
        }

        private void FrequencyCalculation(object sender, EventArgs e)
        {
            double frequency, period;
            bool isPeriodValid = double.TryParse(time.Text, out period);

            if (isPeriodValid && period != 0)
            {
                frequency = 1 / period;
                freqAns.Text = $"Frequency = {Math.Round(frequency, 2)} hz";
            }
            else
            {
                periodAns.Text = "Please enter a valid non-zero frequency.";
            }
        }
        private void AmplitudeCalculation(object sender, EventArgs e)
        {
            double springConstant, mechEnergy, amplitude;
            bool isSpringConstValid = double.TryParse(springconst.Text, out springConstant);
            bool isMechEnergyValid = double.TryParse(energy.Text, out mechEnergy);
            bool isAmpliValid = double.TryParse(amp.Text, out amplitude);

            if(isSpringConstValid && isAmpliValid && !isMechEnergyValid)
            {
                mechEnergy = 0.5 * springConstant * Math.Pow(amplitude, 2);

                ampAns.Text = $"Total Mechanical Energy = {Math.Round(mechEnergy, 2)} J";
            }
            else if (isMechEnergyValid && isAmpliValid && !isSpringConstValid)
            {
                springConstant = (2 * mechEnergy) / Math.Pow(amplitude, 2);

                ampAns.Text = $"Spring Constant = {Math.Round(springConstant, 2)} N/m";
            }
            else if (isMechEnergyValid && isSpringConstValid && !isAmpliValid)
            {
                amplitude = Math.Sqrt((2 * mechEnergy) / springConstant);

                ampAns.Text = $"Amplitude = {Math.Round(amplitude, 2)} m";
            }
            else
            {
                ampAns.Text = "Please enter exactly two values.";
            }
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void displacement_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click_2(object sender, EventArgs e)
        {

        }

        private void close1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {

        }
    }
}
