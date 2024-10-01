using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace as1
{
    public class Customer : user
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string EmailAddress { get; set; }
        int phoneNumber { get; set; }
        string companyName { get; set; }
        string address { get; set; }
        string contry { get; set; }

        public Customer(string username, string password) : base(username, password)
        {
            this.phoneNumber = phoneNumber;
        }
    }
}
