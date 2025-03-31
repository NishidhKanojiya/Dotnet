namespace HospitalOPD
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelContact = new System.Windows.Forms.Label();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // labelName
            // 
            this.labelName.Text = "Patient Name:";
            this.labelName.Location = new System.Drawing.Point(30, 30);
            this.labelName.Size = new System.Drawing.Size(100, 30);

            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(150, 30);
            this.textBoxName.Size = new System.Drawing.Size(200, 30);

            // 
            // labelAge
            // 
            this.labelAge.Text = "Age:";
            this.labelAge.Location = new System.Drawing.Point(30, 80);
            this.labelAge.Size = new System.Drawing.Size(100, 30);

            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(150, 80);
            this.textBoxAge.Size = new System.Drawing.Size(200, 30);

            // 
            // labelGender
            // 
            this.labelGender.Text = "Gender:";
            this.labelGender.Location = new System.Drawing.Point(30, 130);
            this.labelGender.Size = new System.Drawing.Size(100, 30);

            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Location = new System.Drawing.Point(150, 130);
            this.comboBoxGender.Size = new System.Drawing.Size(200, 30);
            this.comboBoxGender.Items.AddRange(new string[] { "Male", "Female", "Other" });

            // 
            // labelContact
            // 
            this.labelContact.Text = "Contact No:";
            this.labelContact.Location = new System.Drawing.Point(30, 180);
            this.labelContact.Size = new System.Drawing.Size(100, 30);

            // 
            // textBoxContact
            // 
            this.textBoxContact.Location = new System.Drawing.Point(150, 180);
            this.textBoxContact.Size = new System.Drawing.Size(200, 30);

            // 
            // labelDepartment
            // 
            this.labelDepartment.Text = "Department:";
            this.labelDepartment.Location = new System.Drawing.Point(30, 230);
            this.labelDepartment.Size = new System.Drawing.Size(100, 30);

            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.Location = new System.Drawing.Point(150, 230);
            this.comboBoxDepartment.Size = new System.Drawing.Size(200, 30);
            this.comboBoxDepartment.Items.AddRange(new string[] { "General", "Cardiology", "Neurology", "Orthopedics" });

            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.Location = new System.Drawing.Point(150, 290);
            this.buttonSubmit.Size = new System.Drawing.Size(100, 40);
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);

            // 
            // buttonClear
            // 
            this.buttonClear.Text = "Clear";
            this.buttonClear.Location = new System.Drawing.Point(260, 290);
            this.buttonClear.Size = new System.Drawing.Size(100, 40);
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonClear);
            this.Text = "Hospital OPD Registration";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClear;
    }
}
