using System.ComponentModel.DataAnnotations;

namespace BankManagementSystem.Models
{
    public abstract class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public BankBranch BankBranch { get; set; }
        public Department Department { get; set; }

        public Employee( string name, string address, int phoneNumber, BankBranch bankBranch, Department department)
        {
            
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            BankBranch = bankBranch;
            Department = department;
        }
    }
}
