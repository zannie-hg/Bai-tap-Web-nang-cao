using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise4
{
    [Serializable]
    internal class Account
    {


        public int AccountID { get; set; }
        public double Balance { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Account()
        {
        }

        public Account(int accountID, double balance, string firstName, string lastName)
        {
            AccountID = accountID;
            Balance = balance;
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return $"ID: {AccountID}, Name: {FirstName} {LastName}, Balance: {Balance}";
        }

    }
}
