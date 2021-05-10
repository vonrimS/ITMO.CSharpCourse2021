
using System;

class CreateAccount
{
    static void Main() 
    {
        BankAccount berts = NewBankAccount();
        TestDeposit(berts);
        TestWithdraw(berts);
        Write(berts);
       
        
        BankAccount freds = NewBankAccount();
        TestDeposit(freds);
        TestWithdraw(freds);
        Write(freds);


    }
    
    static BankAccount NewBankAccount()
    {       
        BankAccount created = new BankAccount();

        //Console.Write("Enter the account number   : ");
        //long number = long.Parse(Console.ReadLine());
        //long number = BankAccount.NextNumber();

        Console.Write("Enter the account balance! : ");
        decimal balance = decimal.Parse(Console.ReadLine());

        created.Populate(balance);

        //created.accNo = number;
        //created.accBal = balance;
        //created.accType = AccountType.Checking;

        return created;
    }
    
    static void Write(BankAccount toWrite)
    {
        Console.WriteLine("Account number is {0}",  toWrite.Number());
        Console.WriteLine("Account balance is {0}", toWrite.Balance());
        Console.WriteLine("Account type is {0}", toWrite.Type());
    }

    public static void TestDeposit(BankAccount balanceToCheck)
    {
        Console.WriteLine("Please enter the sum to deposit to your bank account: ");
        decimal amount = decimal.Parse(Console.ReadLine());
        balanceToCheck.Deposit(amount);

    }

    public static void TestWithdraw(BankAccount acc)
    {
        Console.WriteLine("How much do you want to withdraw? ");
        decimal amount = decimal.Parse(Console.ReadLine());
        if (!acc.Withdraw(amount))
        {
            Console.WriteLine("insufficient funds");
        }
    }
}
