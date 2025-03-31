using System;
using System.Windows.Forms;

namespace HospitalOPD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text.Trim();
                string ageText = textBoxAge.Text.Trim();
                string gender = comboBoxGender.SelectedItem?.ToString();
                string contact = textBoxContact.Text.Trim();
                string department = comboBoxDepartment.SelectedItem?.ToString();

                // Validation
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(ageText) || string.IsNullOrEmpty(gender) ||
                    string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(department))
                {
                    MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(ageText, out int age) || age <= 0 || age > 120)
                {
                    MessageBox.Show("Please enter a valid age (1-120).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!long.TryParse(contact, out _) || contact.Length != 10)
                {
                    MessageBox.Show("Please enter a valid 10-digit contact number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Successful Registration
                MessageBox.Show($"Patient {name} registered successfully in {department} department.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxAge.Clear();
            comboBoxGender.SelectedIndex = -1;
            textBoxContact.Clear();
            comboBoxDepartment.SelectedIndex = -1;
        }
    }
}
