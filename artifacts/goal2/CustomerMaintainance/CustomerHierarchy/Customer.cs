using System;

namespace CustomerHierarchy
{
    public class Customer
    {
     

        //constructor
        public Customer(string firstName, string lastName, string email)
        {
            
                FirstName = firstName;
                LastName = lastName;
                Email = email;
            if (FirstName == "" || LastName == "" || Email == "")
            { throw new EmptyFieldsException(); }
            
        }
        public string FirstName
        {
            get; set;
        }
        public string LastName
        {
            get;set;
        }
        public string Email
        {
            get;set;
        }
        public virtual string GetDisplayText()
            {
            return (FirstName + " " +LastName + ", " + Email + " ");
            }
        public class EmptyFieldsException : ApplicationException
        {
            public EmptyFieldsException(string message) : base(message) { }
            public EmptyFieldsException() : base("One or more fields are empty. Please fill in all the information required.") { }
        }
        
    }
}
