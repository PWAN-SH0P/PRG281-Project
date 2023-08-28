namespace PRG281_Nel_Pieter_Proj
{
    public partial class PromptForPrimeInterestRate : Form
    {
        private double interestRate = 0;

        public PromptForPrimeInterestRate()
        {
            InitializeComponent();
        }

        private void CreateLoans_Load(object sender, EventArgs e)
        {
        }

        private void txtPrimeInterestRate_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(txtPrimeInterestRate.Text, out interestRate);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (interestRate != 0)
            {
                Loan.PrimeInterestRate = interestRate;
                Application.Exit();
            }
        }
    }
}