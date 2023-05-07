namespace BankManagementSystem.Models
{
    public class Transfer
    {
        public int IdTransfer { get; set; }

        public CheckingAccount Sender { get; set; }

        public CheckingAccount Reciever { get; set; }

        public DateTime Date { get; set; }

        public double Amount { get; set; }

        public Transfer() { }
        public Transfer(CheckingAccount sender, CheckingAccount reciever, double amount ) 
        {
            Sender = sender;
            Reciever = reciever;
            Amount = amount;
            Date = DateTime.Now;
        }

        public void Commit() { }


    }
}
