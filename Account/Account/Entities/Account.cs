using System;
using System.Collections.Generic;
using System.Text;

namespace Account.Entities
{
    abstract class Account
    {
        public string Holder { get; set; }
        public double Balance { get; set; }
        public int Number { get; set; }

        public abstract void Withdraw(double amount);
    }
}
