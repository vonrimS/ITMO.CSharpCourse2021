
using System;

class BankAccount
{
    public void Populate(decimal balance) {
        accNo = NextNumber();
        accBal = balance;
        accType = AccountType.Checking;
    }

    public long Number()
    {
        return accNo;
    }

    public decimal Balance()
    {
        return accBal;
    }

    public string Type()
    {
        return accType.ToString();
    }

    private static long nextAccNo = 123;

    private static long NextNumber()
    {
        return nextAccNo++;
    }

    private long accNo;
    private decimal accBal;
    private AccountType accType;

    public decimal Deposit( decimal deposit)
    {
        if (deposit > 0){
            return accBal += deposit;
        }
        else
        {
            throw new ArithmeticException("Enter positive number only");
            Console.WriteLine("Check your input, it has to be positive number...");
        }
               
    }

    public bool Withdraw(decimal amount)
    {
        bool enoughMoney = accBal >= amount;

        if (enoughMoney)
        {
            accBal -= amount;
        }
        return enoughMoney;
    }
}
