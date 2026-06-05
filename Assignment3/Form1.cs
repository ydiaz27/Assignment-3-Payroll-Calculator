namespace Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtName.Focus();
        }

        //CONSTANTS 
        const double REGULAR_HOURS = 40.0;
        const double OVERTIME_RATE = 1.5;
        const double TAX_RATE = 0.15;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            double hoursWorked; //from txtHours 
            double hourlyRate; //from txtRate

            if (!ValidateDouble(txtHours.Text.Trim(), out hoursWorked)) //checks if there's numbers/no negatives 
            {
                txtHours.Focus();
                return;
            }

            if (!ValidateDouble(txtRate.Text.Trim(), out hourlyRate)) //checks if there's numbers/no negatives
            {
                txtRate.Focus();
                return;
            }

            if (rdoHourly.Checked == false && rdoSalary.Checked == false) //checks if Hourly or Salary is checked 
            {
                MessageBox.Show("Please select Hourly or Salary.");
                return;
            }

            //THE RESULTS 
            //Here I declare the variables and call the functions 
            double regularPay = CalculateRegularPay(hoursWorked, hourlyRate);
            //not sure if I should put $ since all variables are a string already (I think) 
            lblRegularPay.Text = "Regular Pay: " + regularPay.ToString("C2"); //C2 = 2 decimal places 

            double overtimePay = CalculateOvertimePay(hoursWorked, hourlyRate);
            lblOvertimePay.Text = "Overtime Pay: " + overtimePay.ToString("C2");

            double grossPay = CalculateGrossPay(regularPay, overtimePay);
            lblGrossPay.Text = "Gross Pay: " + grossPay.ToString("C2");

            double payrollTaxes = CalculateTax(grossPay);
            lblTaxes.Text = "Payroll Taxes: " + payrollTaxes.ToString("C2");

            double netPay = CalculateNetPay(grossPay, payrollTaxes);
            lblNetPay.Text = "Net Pay: " + netPay.ToString("C2");
        }

        //THE FUNCTIONS 
        //VALIDATE DOUBLE
        private bool ValidateDouble(string input, out double result) //takes in a string, pops out a double 
        {
            if (!double.TryParse(input, out result))
            {
                MessageBox.Show("Please enter a numeric value."); //checks if input is a number (double) 
                return false;
            }

            if (result < 0)
            {
                MessageBox.Show("Negative numbers aren't allowed."); //checks if it's a negative 
                return false;
            }

            return true;
        }

        //REGULAR PAY
        private double CalculateRegularPay(double hoursWorked, double hourlyRate)
        {
            if (hoursWorked > REGULAR_HOURS) //if there's overtime 
            {
                return REGULAR_HOURS * hourlyRate; //only multiply by 40 
            }
            else
            {
                return hoursWorked * hourlyRate; //no overtime (less than 40 hours) 
            }
        }

        //OVERTIME PAY
        private double CalculateOvertimePay(double hoursWorked, double hourlyRate)
        {
            if (rdoSalary.Checked) //salaried employess aren't entitled to overtime
            {
                return 0.0;
            }
            
            if (hoursWorked > REGULAR_HOURS) //if there's overtime 
            {
                double overtimeHours = hoursWorked - REGULAR_HOURS; //find the overtime hours by subtracting 40
                return overtimeHours * hourlyRate * OVERTIME_RATE; //find the overtime pay
            }
            else
            {
                return 0.0; //no overtime 
            }
        }

        //GROSS PAY
        private double CalculateGrossPay(double regularPay, double overtimePay)
        {
            return regularPay + overtimePay;
            //if there's no overtime, 0 is added 
        }

        //PAYROLL TAXES
        private double CalculateTax(double grossPay)
        {
            return grossPay * TAX_RATE;
            //gross pay is multiplied by the tax rate set above 
        }

        //NET PAY
        private double CalculateNetPay(double grossPay, double payrollTaxes)
        {
            return grossPay - payrollTaxes;
            //subtract taxes from the gross pay 
        }

        //CLEAR
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtHours.Clear();
            txtRate.Clear();

            //Reset the labels 
            lblRegularPay.Text = "Regular Pay: ";
            lblOvertimePay.Text = "Overtime Pay: ";
            lblGrossPay.Text = "Gross Pay: ";
            lblTaxes.Text = "Payroll Taxes: ";
            lblNetPay.Text = "Net Pay: ";

            //uncheck both radio buttons 
            rdoHourly.Checked = false;
            rdoSalary.Checked = false;

            txtName.Focus();
        }

        //EXIT
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}