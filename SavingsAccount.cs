using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CD_Account_Test
{
    class SavingsAccount
    {
        // Fields for declaring account number, interest rate, and balance
        private string _accountNumber;
        private decimal _interestRate;
        private decimal _balance;

        // Constructor
        public SavingsAccount()
        {
            _accountNumber = "";
            _interestRate = 0;
            _balance = 0;
        }
        // AccountNumber property to set to public
        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }
        // InterestRate property to set to public
        public decimal InterestRate
        {
            get { return _interestRate; }
            set { _interestRate = value; }
        }
        // Balance property to set to public
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
    }
}