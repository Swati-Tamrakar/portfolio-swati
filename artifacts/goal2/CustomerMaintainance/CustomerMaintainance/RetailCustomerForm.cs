using CustomerHierarchy;
using System;
using System.Windows.Forms;

namespace CustomerMaintainance
{
    public partial class frmRetailCustomer : Form
    {
        public string _FirstName, _LastName, _Email, _HomePhone, strOutput;
        RetailCustomer RCustomer;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public frmRetailCustomer()
        {
            InitializeComponent();
        }            

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                _FirstName = txtBxFirstName.Text;
                _LastName = txtBxLastName.Text;
                _Email = txtBxEmail.Text;
                _HomePhone = txtBxCompany.Text;
                int rateSign = _Email.IndexOf('@');
                if (rateSign < 0)
                {
                    MessageBox.Show("Please enter a valid email address.");
                    txtBxEmail.SelectAll();
                    txtBxEmail.Focus();
                }
                else
                {
                    int dashSign = _HomePhone.IndexOf('-');
                    if (dashSign == 3 || dashSign == 7)
                    {
                        RetailCustomer RCustomer = new RetailCustomer(_FirstName, _LastName, _Email, _HomePhone);
                        strOutput = RCustomer.GetDisplayText();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid phone number.");
                        txtBxCompany.SelectAll();
                        txtBxCompany.Focus();
                    }
                }
            }
            catch (Customer.EmptyFieldsException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public RetailCustomer RetailCustomer
        {
            get => RCustomer;

            set
            {
                RCustomer = value;
            }
        }
        public string Output
        {
            get => strOutput;
            set
            {
                strOutput = value;
            }
        }
    }
}
