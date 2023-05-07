using System.ComponentModel.DataAnnotations;

namespace BankManagementSystem.Models
{
    public class BankBranch
    {
        [Key]
        public int BranchId { get; set; }
        [Required]
        public string Name { get; set; }

        public string City { get; set; }
        public int PhoneNumber { get; set; }
        public double BankBalance { get; set; }

        public List<Customer> CustomersList { get; set; }

        public BankBranch() { }
        public BankBranch(string name, string city, int phonenumber,double balance ) 
        {
            Name=name;
            City=city;
            PhoneNumber = phonenumber;
            BankBalance=balance;
            CustomersList = new List<Customer>();
        }
        public void AddEmployee() { }
        public void RemoveEmployee() { }
        public void AddAccount() { }
        public void RemoveAccount() { }
    }
}
