using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CalculatorApp
{

    public partial class Form1 : Form
    {
        private double resultValue = 0;
        private string operationPerformed = "";
        private bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        // Handles Number Button Clicks
        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Result.Text == "0" || isOperationPerformed)
                    textBox_Result.Clear();

                isOperationPerformed = false;
                Button button = (Button)sender;
                textBox_Result.Text += button.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handles Operator Buttons (+, -, *, /)
        private void operator_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;

                if (!double.TryParse(textBox_Result.Text, out resultValue))
                {
                    MessageBox.Show("Invalid input. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                operationPerformed = button.Text;
                isOperationPerformed = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Operator Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handles "=" Button Click
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                double secondOperand;
                if (!double.TryParse(textBox_Result.Text, out secondOperand))
                {
                    MessageBox.Show("Invalid input. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                switch (operationPerformed)
                {
                    case "+":
                        resultValue += secondOperand;
                        break;
                    case "-":
                        resultValue -= secondOperand;
                        break;
                    case "*":
                        resultValue *= secondOperand;
                        break;
                    case "/":
                        if (secondOperand == 0)
                        {
                            MessageBox.Show("Cannot divide by zero.", "Math Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        resultValue /= secondOperand;
                        break;
                    default:
                        MessageBox.Show("Please select an operator before pressing '='.", "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }

                textBox_Result.Text = resultValue.ToString();
                isOperationPerformed = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handles "C" Button (Clear)
        private void buttonClear_Click(object sender, EventArgs e)
        {
            try
            {
                textBox_Result.Text = "0";
                resultValue = 0;
                operationPerformed = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Clear Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_Result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
