﻿using Microsoft.AspNetCore.Routing.Constraints;

namespace BankManagementSystem.Models
{
    public class CheckingAccount : Account
    {
        static double fees = 5;

        public CheckingAccount() { }
        public CheckingAccount(Customer customer, double balance) : base(customer, balance)
        {
        }

        public void PayFees()
        {
            
        }

    }
}
