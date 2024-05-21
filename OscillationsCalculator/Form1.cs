namespace OscillationsCalculator
{
    using System;
    using System.Windows.Forms;

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
            submit.Click += new EventHandler(buttonCalculate_Click);
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

        private void InitializePanels()
        {
            // Initially hide all panels
            panel2.Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hide all panels first
            panel2.Visible = false;

            // Show the selected panel
            string selectedItem = comboBox2.SelectedItem.ToString();
            switch (selectedItem)
            {
                case "Simple Harmonic Oscillations":
                    panel2.Visible = true;
                    break;
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void displacement_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
