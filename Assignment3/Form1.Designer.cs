namespace Assignment3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblRegularPay = new Label();
            lblOvertimePay = new Label();
            lblGrossPay = new Label();
            lblTaxes = new Label();
            lblNetPay = new Label();
            txtName = new TextBox();
            txtHours = new TextBox();
            txtRate = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            rdoSalary = new RadioButton();
            rdoHourly = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 26);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 0;
            label1.Text = "Employee Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 76);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 1;
            label2.Text = "Hours Worked:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 123);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "Hourly Rate:";
            // 
            // lblRegularPay
            // 
            lblRegularPay.AutoSize = true;
            lblRegularPay.Location = new Point(389, 26);
            lblRegularPay.Name = "lblRegularPay";
            lblRegularPay.Size = new Size(89, 20);
            lblRegularPay.TabIndex = 3;
            lblRegularPay.Text = "Regular Pay:";
            // 
            // lblOvertimePay
            // 
            lblOvertimePay.AutoSize = true;
            lblOvertimePay.Location = new Point(389, 76);
            lblOvertimePay.Name = "lblOvertimePay";
            lblOvertimePay.Size = new Size(99, 20);
            lblOvertimePay.TabIndex = 4;
            lblOvertimePay.Text = "Overtime Pay:";
            // 
            // lblGrossPay
            // 
            lblGrossPay.AutoSize = true;
            lblGrossPay.Location = new Point(389, 123);
            lblGrossPay.Name = "lblGrossPay";
            lblGrossPay.Size = new Size(74, 20);
            lblGrossPay.TabIndex = 5;
            lblGrossPay.Text = "Gross Pay:";
            // 
            // lblTaxes
            // 
            lblTaxes.AutoSize = true;
            lblTaxes.Location = new Point(389, 170);
            lblTaxes.Name = "lblTaxes";
            lblTaxes.Size = new Size(95, 20);
            lblTaxes.TabIndex = 6;
            lblTaxes.Text = "Payroll Taxes:";
            // 
            // lblNetPay
            // 
            lblNetPay.AutoSize = true;
            lblNetPay.Location = new Point(389, 219);
            lblNetPay.Name = "lblNetPay";
            lblNetPay.Size = new Size(62, 20);
            lblNetPay.TabIndex = 7;
            lblNetPay.Text = "Net Pay:";
            // 
            // txtName
            // 
            txtName.Location = new Point(163, 23);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 1;
            // 
            // txtHours
            // 
            txtHours.Location = new Point(163, 73);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(125, 27);
            txtHours.TabIndex = 2;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(163, 120);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(125, 27);
            txtRate.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(65, 348);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(271, 348);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(472, 348);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 37);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 73);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoSalary);
            groupBox1.Controls.Add(rdoHourly);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(22, 184);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(155, 117);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employment";
            // 
            // rdoSalary
            // 
            rdoSalary.AutoSize = true;
            rdoSalary.Location = new Point(15, 73);
            rdoSalary.Name = "rdoSalary";
            rdoSalary.Size = new Size(70, 24);
            rdoSalary.TabIndex = 11;
            rdoSalary.TabStop = true;
            rdoSalary.Text = "Salary";
            rdoSalary.UseVisualStyleBackColor = true;
            // 
            // rdoHourly
            // 
            rdoHourly.AutoSize = true;
            rdoHourly.Location = new Point(15, 35);
            rdoHourly.Name = "rdoHourly";
            rdoHourly.Size = new Size(69, 24);
            rdoHourly.TabIndex = 10;
            rdoHourly.TabStop = true;
            rdoHourly.Text = "Houly";
            rdoHourly.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 416);
            Controls.Add(groupBox1);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtRate);
            Controls.Add(txtHours);
            Controls.Add(txtName);
            Controls.Add(lblNetPay);
            Controls.Add(lblTaxes);
            Controls.Add(lblGrossPay);
            Controls.Add(lblOvertimePay);
            Controls.Add(lblRegularPay);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblRegularPay;
        private Label lblOvertimePay;
        private Label lblGrossPay;
        private Label lblTaxes;
        private Label lblNetPay;
        private TextBox txtName;
        private TextBox txtHours;
        private TextBox txtRate;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private RadioButton rdoSalary;
        private RadioButton rdoHourly;
    }
}
