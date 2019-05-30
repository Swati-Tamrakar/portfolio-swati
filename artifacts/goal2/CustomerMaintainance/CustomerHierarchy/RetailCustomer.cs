using System;
namespace CustomerHierarchy
{
    public class RetailCustomer : Customer
    {
        public RetailCustomer(string firstName,string lastName, string email, string homePhone) : base(firstName,lastName, email)
        {
            HomePhone = homePhone;
            if (HomePhone == "")
            { throw new EmptyFieldsException(); }
        }
        public string HomePhone
        {
            get;set;
        }
        public override string GetDisplayText()
        {
            return (base.GetDisplayText() + "ph: "+ HomePhone);
        }
    }
}
