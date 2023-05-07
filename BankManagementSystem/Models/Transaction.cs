using System.ComponentModel.DataAnnotations;

namespace BankManagementSystem.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        [Required]
        public Account Account { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public Transaction() { }
        public Transaction(Account account, string desc) 
        {
            Account = account;
            Description = desc;
            Date = DateTime.Now;
        }
    }
}
