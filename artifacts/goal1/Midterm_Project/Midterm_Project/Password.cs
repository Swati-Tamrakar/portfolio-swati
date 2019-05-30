using System;
using System.Windows.Forms;

namespace Midterm_Project
{
    public partial class frmUsername : Form
    {
        int i, intCount = 0;
        const int intMax= 50;       
        string strAnswer = "Name".PadRight(30)+"Username".PadRight(18)+ "EmailAddress".PadRight(28)+ "Password".PadLeft(10)+ "\n\n";
        Students[] StudentsArray = new Students[intMax]; 
        public frmUsername()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string strLastName, strFirstName, strSsn, strBirthdate,strTempSsn;
            double dblSsn;
            int intHyphen, intLastHyphen;
            try
            {
                strLastName = txtBxLastName.Text;
                strFirstName = txtBxFirstName.Text;
                strBirthdate = txtBxBirthDate.Text;
                try
                {
                    strSsn = txtBxSsn.Text;                   
                    if ( strSsn != "")
                    {
                        intHyphen = strSsn.IndexOf("-");
                        intLastHyphen = strSsn.LastIndexOf("-");
                        if (intHyphen != 3 || intLastHyphen != 6)
                        {
                            MessageBox.Show("Please enter the SSN in the correct format", "Error");
                            txtBxSsn.SelectAll();
                            txtBxSsn.Focus();

                        }
                        else
                        {
                            strTempSsn = strSsn.Substring(0, intHyphen) + strSsn.Substring(intHyphen + 1, 2) + strSsn.Substring(intLastHyphen + 1);
                            dblSsn = Convert.ToDouble(strTempSsn);
                            Students newStudents = new Students(strFirstName, strLastName, strBirthdate, strSsn);
                            StudentsArray[intCount] = newStudents;
                            MessageBox.Show("Student Added");
                            intCount++;
                            txtBxFirstName.Text = "";
                            txtBxLastName.Text = "";
                            txtBxBirthDate.Text = "";
                            txtBxSsn.Text = "";
                            txtBxFirstName.Focus();
                        }                        
                    }
                    else
                    {
                        //constructor call
                        Students newStudents = new Students(strFirstName, strLastName, strBirthdate, strSsn);
                        StudentsArray[intCount] = newStudents;
                        MessageBox.Show("Student Added");
                        intCount++;
                        txtBxFirstName.Text = "";
                        txtBxLastName.Text = "";
                        txtBxBirthDate.Text = "";
                        txtBxSsn.Text = "";
                        txtBxFirstName.Focus();
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("You must input a number", "error");
                    txtBxSsn.SelectAll();
                    txtBxSsn.Focus();
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("You exceeded the limit", "Error");
                btnAdd.Enabled = false;
            }           
        }
        private void btndisplay_Click(object sender, EventArgs e)
        {
            int k;
            Students newStudents;
            string strName;
            for (int i =1; i<intCount; ++i)
            {
                newStudents = StudentsArray[i];
                k = i;
                while (k>0 && string.Compare(StudentsArray[k-1].LastName, newStudents.LastName)>0)
                {
                    StudentsArray[k] = StudentsArray[k - 1];
                    k = k - 1;
                }
                StudentsArray[k] = newStudents;
            }
            for (int i = 0; i < intCount; i++)
            {
                strName = StudentsArray[i].LastName + ", " + StudentsArray[i].FirstName;
                strAnswer += strName.PadRight(30) + StudentsArray[i].Username.PadRight(18) + StudentsArray[i].Email.PadRight(28) + StudentsArray[i].Password.PadLeft(10) + "\n";
            }

            rchTxtBxAnswer.Text = strAnswer;
            btnAdd.Enabled = false;          
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBxFirstName.Text = "";
            txtBxLastName.Text = "";
            txtBxBirthDate.Text = "";
            txtBxSsn.Text = "";
            txtBxFirstName.Focus();
            rchTxtBxAnswer.Text = "";
            intCount = 0;
            i = 0;
            strAnswer = "Name".PadRight(30) + "Username".PadRight(18) + "EmailAddress".PadRight(28) + "Password".PadLeft(10) + "\n\n";
            btnAdd.Enabled = true;
        }

    }//end class
}//End namespace
