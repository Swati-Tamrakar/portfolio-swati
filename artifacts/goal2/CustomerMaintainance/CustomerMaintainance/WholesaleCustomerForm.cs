using CustomerHierarchy;
using System;
using System.Windows.Forms;

namespace CustomerMaintainance
{
    public partial class frmWholesaleCustomer : Form
    {
        public string _FirstName,_LastName, _Email, _Company, strOutput;
        WholesaleCustomer WSCustomer;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public frmWholesaleCustomer()
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
                _Company = txtBxCompany.Text;
                //call in wholesale customer
                WholesaleCustomer WSCustomer = new WholesaleCustomer(_FirstName, _LastName, _Email, _Company);
                strOutput = WSCustomer.GetDisplayText();
                this.Close();
                //go to the main form 
            }
            catch (Customer.EmptyFieldsException ex)
            {
                MessageBox.Show(ex.Message);
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
        public WholesaleCustomer WholeSaleCustomer
        {
            get => WSCustomer;

            set
            {
                WSCustomer = value;
            }
        }

    }

}
