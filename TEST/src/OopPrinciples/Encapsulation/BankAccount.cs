
namespace TEST.src.OopPrinciples.Encapsulation
{
    public class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal balance)
        {
            Deposit(balance);
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive");
            }

            this.balance += amount;
        }

        public decimal GetBalance()
        {
            return this.balance;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdraw amount must be positive");
            }

            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient funds");
            }

            this.balance += amount;
        }
    }

}