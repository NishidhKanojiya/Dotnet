namespace CalculatorApp
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
            textBox_Result = new TextBox();
            button0 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonAdd = new Button();
            buttonSubtract = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            buttonEquals = new Button();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // textBox_Result
            // 
            textBox_Result.Dock = DockStyle.Top;
            textBox_Result.Font = new Font("Segoe UI", 30F);
            textBox_Result.Location = new Point(0, 0);
            textBox_Result.Name = "textBox_Result";
            textBox_Result.ReadOnly = true;
            textBox_Result.Size = new Size(416, 87);
            textBox_Result.TabIndex = 0;
            textBox_Result.TextAlign = HorizontalAlignment.Right;
            textBox_Result.TextChanged += textBox_Result_TextChanged;
            // 
            // button0
            // 
            button0.BackColor = Color.LightGray;
            button0.Font = new Font("Arial", 14F);
            button0.Location = new Point(321, 464);
            button0.Name = "button0";
            button0.Size = new Size(87, 87);
            button0.TabIndex = 1;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Font = new Font("Arial", 14F);
            button1.Location = new Point(12, 228);
            button1.Name = "button1";
            button1.Size = new Size(87, 87);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.Font = new Font("Arial", 14F);
            button2.Location = new Point(117, 227);
            button2.Name = "button2";
            button2.Size = new Size(87, 87);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.Font = new Font("Arial", 14F);
            button3.Location = new Point(218, 227);
            button3.Name = "button3";
            button3.Size = new Size(87, 87);
            button3.TabIndex = 4;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightGray;
            button4.Font = new Font("Arial", 14F);
            button4.Location = new Point(12, 344);
            button4.Name = "button4";
            button4.Size = new Size(87, 87);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LightGray;
            button5.Font = new Font("Arial", 14F);
            button5.Location = new Point(117, 346);
            button5.Name = "button5";
            button5.Size = new Size(87, 87);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.LightGray;
            button6.Font = new Font("Arial", 14F);
            button6.Location = new Point(218, 346);
            button6.Name = "button6";
            button6.Size = new Size(87, 87);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.LightGray;
            button7.Font = new Font("Arial", 14F);
            button7.Location = new Point(12, 465);
            button7.Name = "button7";
            button7.Size = new Size(87, 87);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.LightGray;
            button8.Font = new Font("Arial", 14F);
            button8.Location = new Point(117, 464);
            button8.Name = "button8";
            button8.Size = new Size(87, 87);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.LightGray;
            button9.Font = new Font("Arial", 14F);
            button9.Location = new Point(218, 464);
            button9.Name = "button9";
            button9.Size = new Size(87, 87);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.SkyBlue;
            buttonAdd.Font = new Font("Arial", 14F);
            buttonAdd.Location = new Point(119, 109);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(85, 87);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += operator_Click;
            // 
            // buttonSubtract
            // 
            buttonSubtract.BackColor = Color.SkyBlue;
            buttonSubtract.Font = new Font("Arial", 14F);
            buttonSubtract.Location = new Point(218, 109);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(87, 87);
            buttonSubtract.TabIndex = 12;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = false;
            buttonSubtract.Click += operator_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.BackColor = Color.SkyBlue;
            buttonMultiply.Font = new Font("Arial", 14F);
            buttonMultiply.Location = new Point(321, 109);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(87, 87);
            buttonMultiply.TabIndex = 13;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = false;
            buttonMultiply.Click += operator_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.BackColor = Color.SkyBlue;
            buttonDivide.Font = new Font("Arial", 14F);
            buttonDivide.Location = new Point(321, 228);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(87, 87);
            buttonDivide.TabIndex = 14;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = false;
            buttonDivide.Click += operator_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.BackColor = Color.Cyan;
            buttonEquals.Font = new Font("Arial", 14F);
            buttonEquals.Location = new Point(321, 346);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(87, 87);
            buttonEquals.TabIndex = 15;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = false;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.SkyBlue;
            buttonClear.Font = new Font("Arial", 14F);
            buttonClear.Location = new Point(12, 109);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(87, 87);
            buttonClear.TabIndex = 16;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 570);
            Controls.Add(buttonClear);
            Controls.Add(buttonEquals);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonSubtract);
            Controls.Add(buttonAdd);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button0);
            Controls.Add(textBox_Result);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Result;
        private Button button0;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonAdd;
        private Button buttonSubtract;
        private Button buttonMultiply;
        private Button buttonDivide;
        private Button buttonEquals;
        private Button buttonClear;
    }
}
