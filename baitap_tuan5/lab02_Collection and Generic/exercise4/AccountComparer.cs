using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise4
{
    internal class AccountComparer : IComparer<Account>
    {
        public int Compare(Account x, Account y)
        {
            return x.AccountID.CompareTo(y.AccountID);
        }
    }
}
