using System;
using System.Windows.Forms;

namespace TShirtOrderingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Validate Quantity Input
            if (!int.TryParse(txtQuantity.Text.Trim(), out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid number of T-shirts.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ensure a Size is Selected
            if (cmbSize.SelectedItem == null)
            {
                MessageBox.Show("Please select a T-shirt size.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the Selected Size Price
            int pricePerShirt = cmbSize.SelectedItem.ToString() switch
            {
                "Small" => 125,
                "Medium" => 175,
                "Large" => 250,
                _ => 0
            };

            if (pricePerShirt == 0)
            {
                MessageBox.Show("Invalid size selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate Base Price
            double totalPrice = quantity * pricePerShirt;

            // Apply Promo Code Discount (if any)
            if (txtPromoCode.Text.Trim().ToUpper() == "TRUEBLUE")
            {
                totalPrice *= 0.90; // Apply 10% Discount
            }

            // Apply 9% GST
            double gst = totalPrice * 0.09;
            double finalPrice = totalPrice + gst;

            // Display Final Price
            labelResult.Text = $"Total Price (including 9% GST): Rs. {finalPrice:F2}";
        }
    }
}
