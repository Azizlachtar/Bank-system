using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankManagementSystem.Models
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        [Required]
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer AccountHolder { get; set; }

        public double Balance { get; set; }

        public Boolean AccountStatus { get; set; }

        public Customer Customer { get; set; }
        public List<Transaction> Transactions { get; set; }
        public List<Loan> loans { get; set; }

        public List<Transfer> Transfers { get; set; }

        public Account() { }
        public Account( Customer customer, double balance) 
        { 
            AccountHolder = customer;
            Balance = balance;
            AccountStatus = true;
            Transactions = new List<Transaction>();
            loans = new List<Loan>();
            Transfers = new List<Transfer>();
        }

        public  void Deactivate() // ziid fazt system time
        {
            AccountStatus = false;
        }
        public void Deposit(double amount)
        { 
            amount +=amount;
        }

        public void Withdraw(double amount)
        { 
            
        }
        


    }
}
