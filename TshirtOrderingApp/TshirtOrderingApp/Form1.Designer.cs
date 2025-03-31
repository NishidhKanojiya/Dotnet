namespace TShirtOrderingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelQuantity = new Label();
            txtQuantity = new TextBox();
            labelSize = new Label();
            cmbSize = new ComboBox();
            labelPromo = new Label();
            txtPromoCode = new TextBox();
            btnCalculate = new Button();
            labelResult = new Label();
            SuspendLayout();

            // Label Quantity
            labelQuantity.AutoSize = true;
            labelQuantity.Font = new Font("Segoe UI", 12F);
            labelQuantity.Location = new Point(481, 145);
            labelQuantity.Text = "Enter Quantity:";

            // TextBox Quantity
            txtQuantity.Location = new Point(694, 146);
            txtQuantity.Size = new Size(315, 31);

            // Label Size
            labelSize.AutoSize = true;
            labelSize.Font = new Font("Segoe UI", 12F);
            labelSize.Location = new Point(442, 223);
            labelSize.Text = "Select T-Shirt Size:";

            // ComboBox Size
            cmbSize.FormattingEnabled = true;
            cmbSize.Items.AddRange(new object[] { "Small", "Medium", "Large" });
            cmbSize.Location = new Point(694, 226);
            cmbSize.Size = new Size(182, 33);
            cmbSize.SelectedIndexChanged += cmbSize_SelectedIndexChanged;

            // Label Promo
            labelPromo.AutoSize = true;
            labelPromo.Font = new Font("Segoe UI", 12F);
            labelPromo.Location = new Point(440, 302);
            labelPromo.Text = "Enter Promo Code:";

            // TextBox Promo Code
            txtPromoCode.Location = new Point(694, 305);
            txtPromoCode.Size = new Size(201, 31);

            // Button Calculate
            btnCalculate.Location = new Point(554, 372);
            btnCalculate.Size = new Size(265, 34);
            btnCalculate.Text = "Calculate Price";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click; // FIXED: Linked button click event.

            // Label Result (Fixing Display Issue)
            labelResult.AutoSize = false; // Fix to prevent disappearing text.
            labelResult.Location = new Point(621, 464);
            labelResult.Size = new Size(400, 50); // Increased size to ensure text fits.
            labelResult.Text = "Final Price: Rs. 0"; // Default text to make it visible.

            // Form Settings
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 769);
            Controls.Add(labelResult);
            Controls.Add(btnCalculate);
            Controls.Add(txtPromoCode);
            Controls.Add(labelPromo);
            Controls.Add(cmbSize);
            Controls.Add(labelSize);
            Controls.Add(txtQuantity);
            Controls.Add(labelQuantity);
            Name = "Form1";
            Text = "T-Shirt Ordering App";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label labelQuantity;
        private TextBox txtQuantity;
        private Label labelSize;
        private ComboBox cmbSize;
        private Label labelPromo;
        private TextBox txtPromoCode;
        private Button btnCalculate;
        private Label labelResult;

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            // You can add some logic here if needed
        }

        private void cmbSize_Click(object sender, EventArgs e)
        {
            // Optional: Handle click event separately
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: Add logic for Form Load
        }
    }
}
