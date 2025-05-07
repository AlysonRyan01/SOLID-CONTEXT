namespace Solid._03_LSP.Good
{
    public abstract class BankAccount
    {
        public decimal Balance { get; protected set; }

        public abstract void Withdraw(decimal amount);
    }

    public class CheckingAccount : BankAccount
    {
        public override void Withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }
    }

    public class SavigsAccount : BankAccount
    {
        public override void Withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}