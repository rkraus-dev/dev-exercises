BankAccount account1 = new BankAccount();
account1.Balance = 30.0;
account1.Withdraw(10);

try
{
    account1.Withdraw(150);
}
catch(InsufficientFundsException ex)
{
    Console.WriteLine(ex.Message);
}

class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message)
    {

    }
}

class BankAccount
{
    public double Balance { get; set; }

    public void Withdraw(double amount)
    {
        if(Balance < amount)
        {
            throw new InsufficientFundsException($"Cannot withdraw {amount}, only {Balance} available.");
        }
        Balance -= amount;
    }
}