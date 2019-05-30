using System;
namespace CustomerHierarchy
{
    public class WholesaleCustomer : Customer
    {

        public WholesaleCustomer(string firstName, string lastName, string email, string company) : base(firstName,lastName, email)
        {
            Company = company;
            if (Company == "")
            { throw new EmptyFieldsException(); }
        }
        public string Company
        {
            get;
            set;
        }
        public override string GetDisplayText()
        {
            return base.GetDisplayText() + Company;
        }
    }
}
