namespace BankManagementSystem.Models
{
    public class Manager : Employee
    {

        public Manager(string name, string address, int phoneNumber, BankBranch bankBranch, Department department): base (name,  address,  phoneNumber,  bankBranch,  department)
        { }
        public void ApproveLoan(Loan loan)// ikhali el etat loan approval
        {

        }
    }
}
