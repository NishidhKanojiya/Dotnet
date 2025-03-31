using System;
using System.Windows.Forms;

namespace RailwayReservationApp
{
    public partial class Form1 : Form
    {
        // Declare UI Controls
        private Label lblName, lblAge, lblGender, lblFrom, lblTo, lblDate, lblClass, lblSeats, lblPayment;
        private TextBox txtName;
        private NumericUpDown numAge, numSeats;
        private ComboBox cmbGender, cmbFrom, cmbTo, cmbClass, cmbPayment;
        private DateTimePicker dtpJourneyDate;
        private Button btnBook, btnReset, btnExit;

        public Form1()
        {
            // Initialize Form Properties
            this.Text = "Railway Reservation";
            this.Size = new System.Drawing.Size(400, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Initialize UI Components
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Name Label & TextBox
            lblName = new Label() { Text = "Name:", Left = 20, Top = 20, Width = 100 };
            txtName = new TextBox() { Left = 120, Top = 20, Width = 200 };

            // Age Label & NumericUpDown
            lblAge = new Label() { Text = "Age:", Left = 20, Top = 60, Width = 100 };
            numAge = new NumericUpDown() { Left = 120, Top = 60, Width = 100, Minimum = 1, Maximum = 100 };

            // Gender Label & ComboBox
            lblGender = new Label() { Text = "Gender:", Left = 20, Top = 100, Width = 100 };
            cmbGender = new ComboBox() { Left = 120, Top = 100, Width = 100 };
            cmbGender.Items.AddRange(new string[] { "Male", "Female", "Other" });

            // From Station Label & ComboBox
            lblFrom = new Label() { Text = "From Station:", Left = 20, Top = 140, Width = 100 };
            cmbFrom = new ComboBox() { Left = 120, Top = 140, Width = 150 };
            cmbFrom.Items.AddRange(new string[] { "Mumbai", "Delhi", "Chennai", "Kolkata", "Bangalore" });

            // To Station Label & ComboBox
            lblTo = new Label() { Text = "To Station:", Left = 20, Top = 180, Width = 100 };
            cmbTo = new ComboBox() { Left = 120, Top = 180, Width = 150 };
            cmbTo.Items.AddRange(new string[] { "Mumbai", "Delhi", "Chennai", "Kolkata", "Bangalore" });

            // Journey Date Label & DateTimePicker
            lblDate = new Label() { Text = "Journey Date:", Left = 20, Top = 220, Width = 100 };
            dtpJourneyDate = new DateTimePicker() { Left = 120, Top = 220, Width = 150 };

            // Class Type Label & ComboBox
            lblClass = new Label() { Text = "Class Type:", Left = 20, Top = 260, Width = 100 };
            cmbClass = new ComboBox() { Left = 120, Top = 260, Width = 100 };
            cmbClass.Items.AddRange(new string[] { "General", "Sleeper", "AC" });

            // Seats Label & NumericUpDown
            lblSeats = new Label() { Text = "Seats:", Left = 20, Top = 300, Width = 100 };
            numSeats = new NumericUpDown() { Left = 120, Top = 300, Width = 100, Minimum = 1, Maximum = 6 };

            // Payment Label & ComboBox
            lblPayment = new Label() { Text = "Payment Mode:", Left = 20, Top = 340, Width = 120 };
            cmbPayment = new ComboBox() { Left = 140, Top = 340, Width = 150 };
            cmbPayment.Items.AddRange(new string[] { "UPI", "Credit/Debit Card", "Net Banking" });

            // Buttons
            btnBook = new Button() { Text = "Book Ticket", Left = 20, Top = 400, Width = 100 };
            btnReset = new Button() { Text = "Reset", Left = 140, Top = 400, Width = 100 };
            btnExit = new Button() { Text = "Exit", Left = 260, Top = 400, Width = 100 };

            // Add Button Events
            btnBook.Click += BtnBook_Click;
            btnReset.Click += BtnReset_Click;
            btnExit.Click += BtnExit_Click;

            // Add Controls to Form
            this.Controls.Add(lblName); this.Controls.Add(txtName);
            this.Controls.Add(lblAge); this.Controls.Add(numAge);
            this.Controls.Add(lblGender); this.Controls.Add(cmbGender);
            this.Controls.Add(lblFrom); this.Controls.Add(cmbFrom);
            this.Controls.Add(lblTo); this.Controls.Add(cmbTo);
            this.Controls.Add(lblDate); this.Controls.Add(dtpJourneyDate);
            this.Controls.Add(lblClass); this.Controls.Add(cmbClass);
            this.Controls.Add(lblSeats); this.Controls.Add(numSeats);
            this.Controls.Add(lblPayment); this.Controls.Add(cmbPayment);
            this.Controls.Add(btnBook); this.Controls.Add(btnReset); this.Controls.Add(btnExit);
        }

        // Button Click Events
        private void BtnBook_Click(object sender, EventArgs e)
        {
            string message = $"Booking Confirmed for {txtName.Text}\n" +
                             $"From: {cmbFrom.Text} → To: {cmbTo.Text}\n" +
                             $"Date: {dtpJourneyDate.Value.ToShortDateString()}\n" +
                             $"Class: {cmbClass.Text} | Seats: {numSeats.Value}\n" +
                             $"Payment Mode: {cmbPayment.Text}";
            MessageBox.Show(message, "Booking Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            numAge.Value = 1;
            cmbGender.SelectedIndex = -1;
            cmbFrom.SelectedIndex = -1;
            cmbTo.SelectedIndex = -1;
            dtpJourneyDate.Value = DateTime.Now;
            cmbClass.SelectedIndex = -1;
            numSeats.Value = 1;
            cmbPayment.SelectedIndex = -1;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
