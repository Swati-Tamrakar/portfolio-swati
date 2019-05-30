using System;

namespace Midterm_Project
{//Swati Tamrakar   
    //Midterm Project   
    //Due 03-29-2016
    class Students
    {
        private string strFirstName, strLastName, strEmail, strPassword, strUsername,strBirthdate, strSsn;
        private int intID;
        public Students(string FirstName, string LastName, string Birthdate, string Ssn)
        {
            strFirstName = FirstName;
            strLastName = LastName;
            strBirthdate = Birthdate;
            strSsn = Ssn;
            intID = ID;
            ID = FindID();
            strUsername = FindUserName(ID, strLastName);
            strEmail = FindEmail(strUsername);
            strPassword = FindPassword(intID, strBirthdate, strSsn);
        }                
        public static int FindID()
        {
            int intID;
            Random Id = new Random();
            intID = Id.Next(100000,999999);
            return intID;
        }
        public static string FindUserName(int ID, string LastName)
        {
            string strUsername;           
            int intSpace, intDash, intApostrophy;
            intSpace = LastName.IndexOf(" ");
            intDash = LastName.IndexOf('-');
            intApostrophy= LastName.IndexOf("'");
            if (intSpace != -1)
            {
             LastName = LastName.Substring(0, intSpace) + LastName.Substring(intSpace + 1);
            }
            if (intDash !=-1)
            {
                LastName = LastName.Substring(0, intDash) + LastName.Substring(intDash + 1);
            }
            if (intApostrophy != -1)
            {
                LastName = LastName.Substring(0, intApostrophy) + LastName.Substring(intApostrophy + 1);
            }
            if (LastName.Length <= 8)
            {
               strUsername = LastName.ToLower() + ID.ToString();
            }
            else
            {
                strUsername = LastName.ToLower().Substring(0,8) + ID.ToString();
            }
                return strUsername;
        }
        public static string FindEmail(string UserName)
        {
            string strUsername, strEmail;
            strUsername=UserName;
            strEmail = strUsername + "@newmanu.edu";
            return strEmail;
        }
        public static string FindPassword(int ID, string Birthdate, string Ssn)
        {
            int intID, intSlash, intLastSlash;
            string strPassword, strBirthDate,  strMonth, strDate,strSsn;             
            strBirthDate = Birthdate;            
            strSsn = Ssn;
            intID = ID;
            if (strBirthDate == "")
            {
                strBirthDate = "9999";
            }
            else
            {
                intSlash = strBirthDate.IndexOf("/");
                intLastSlash = strBirthDate.LastIndexOf("/");
                strMonth = strBirthDate.Substring(0, intSlash);
               if (strMonth.Length==1)
                {
                    strMonth = "0" + strMonth.Substring(0, 1);
                }
                strDate = strBirthDate.Substring(intSlash + 1,intLastSlash-intSlash-1);
                if (strDate.Length == 1)
                {
                    strDate = "0" + strDate.Substring(0, 1);
                }
                strBirthDate = strMonth + strDate;
                
            }
                if (strSsn == "")
                {
                    strPassword = strBirthDate + ID.ToString().Substring(2);
                }
                else
                {
                    strPassword = strBirthDate + strSsn.Substring(7);
                }            
            return strPassword;
        }
        //properties
        public string FirstName
        {
            get
            {
                return strFirstName;
            }
            set
            {
                strFirstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return strLastName;
            }
            set
            {
                strLastName = value;
            }
        }
        public string Username
        {
            get
            {
                return strUsername;
            }
            set
            {
                strUsername = value;
            }
        }
        public string Email
        {
            get
            {
                return strEmail;
            }
            set
            {
                strEmail = value;
            }
        }
        public string Password
        {
            get
            {
                return strPassword;
            }
            set
            {
                strPassword = value;
            }
        }
        public int ID
        {
            get
            {
                return intID;
            }
            set
            {
                intID = value;
            }
        }
        public string BirthDate
        {
            get
            {
                return strBirthdate;
            }
            set
            {
                strBirthdate = value;
            }
        }
        public string Ssn
        {
            get
            {
                return strSsn;
            }
            set
            {
                strSsn = value;
            }
        }
    }
}
