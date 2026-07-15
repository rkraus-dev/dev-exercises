BankAccount account1 = new BankAccount("Rob", 1234);
account1.Balance = 999.99;
Console.WriteLine(account1.Balance);
account1.Balance = -99;
Console.WriteLine(account1.Balance);
Console.WriteLine(account1.AccountId);

class BankAccount
{
    private double balance;
    public string Owner { get; set; }

    public double Balance
    {
        get
        {
            return balance;
        }
        set
        {
            if (value < 0)
            {
                balance = 0;
            }
            else
            {
                balance = value;
            }

        }
    }

    public int AccountId { get; private set; }

    public BankAccount(string owner, int accountId)
    {
        Owner = owner;
        AccountId = accountId;
    }

}