namespace BankManagementSystem.Models
{
    public class Agent : Employee
    {
        public Agent (string name, string address, int phoneNumber, BankBranch bankBranch, Department department): base (name, address, phoneNumber, bankBranch, department)
        { }
    }
}
