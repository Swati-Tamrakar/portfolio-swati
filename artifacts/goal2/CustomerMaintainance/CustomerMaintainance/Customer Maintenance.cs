using CustomerHierarchy;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace CustomerMaintainance
{
    public partial class frmCustomerMaintenance : Form
    {
        List<Customer> lstCustomers = new List<Customer>();
        string strOutput;
        public frmCustomerMaintenance()
        {
            InitializeComponent();
        }

        private void btnAddWholesale_Click(object sender, EventArgs e)
        {
            frmWholesaleCustomer wholesaleForm = new frmWholesaleCustomer();
            wholesaleForm.ShowDialog();
            lstBxCustomerMaintenance.Items.Add(wholesaleForm.Output);
            lstCustomers.Add(wholesaleForm.WholeSaleCustomer);
        }

        private void btnAddRetail_Click(object sender, EventArgs e)
        {
            frmRetailCustomer retailForm = new frmRetailCustomer();
            retailForm.ShowDialog();
            lstBxCustomerMaintenance.Items.Add(retailForm.Output);
            lstCustomers.Add(retailForm.RetailCustomer);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string Output
        {
            get => strOutput;
            set
            {
                strOutput = value;
            }
        }
        public List<Customer> GetCustomerList
        {
            get => lstCustomers;
            set
            {
                lstCustomers = value;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult1;
            string strName, _Name;
            int intComma;
            strName = Convert.ToString(lstBxCustomerMaintenance.SelectedItem);
            try
            {
                intComma = lstBxCustomerMaintenance.SelectedItem.ToString().IndexOf(',');
                _Name = strName.Substring(0, intComma);

                //Confirm operation
                dialogResult1 = MessageBox.Show("Are you sure you want to delete " + _Name + "?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (dialogResult1 == DialogResult.Yes)
                {
                    
                    lstBxCustomerMaintenance.Items.RemoveAt(lstBxCustomerMaintenance.SelectedIndex);
                    lstCustomers.RemoveAt(lstBxCustomerMaintenance.SelectedIndex + 1);
                }

                else
                {
                    MessageBox.Show("The record has not be deleted.");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show(" Please select the customer from the list.", "Error");
            }
        }
    }
}
