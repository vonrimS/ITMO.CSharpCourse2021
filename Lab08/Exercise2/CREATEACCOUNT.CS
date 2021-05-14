
using System;

namespace Lab08.Exercise2
{

    class CreateAccount
    {
        static void Main()
        {

            BankAccount acc1 = new BankAccount();
            BankAccount acc2 = new BankAccount(AccountType.Deposit);
            BankAccount acc3 = new BankAccount(666);
            BankAccount acc4 = new BankAccount(AccountType.Deposit, 999);

            Write(acc1);
            Write(acc2);
            Write(acc3);
            Write(acc4);

            acc1.Deposit(10);
            acc2.Withdraw(10);
            acc3.Deposit(200);
            acc4.Withdraw(33);

            Console.WriteLine("...a few minutes later");

            Write(acc1);
            Write(acc2);
            Write(acc3);
            Write(acc4);


            //BankAccount berts = NewBankAccount();
            //TestDeposit(berts);
            //TestWithdraw(berts);
            //Write(berts);


            //BankAccount freds = NewBankAccount();
            //TestDeposit(freds);
            //TestWithdraw(freds);
            //Write(freds);


        }

        //static BankAccount NewBankAccount()
        //{       
        //    BankAccount created = new BankAccount();

        //    //Console.Write("Enter the account number   : ");
        //    //long number = long.Parse(Console.ReadLine());
        //    //long number = BankAccount.NextNumber();

        //    Console.Write("Enter the account balance! : ");
        //    decimal balance = decimal.Parse(Console.ReadLine());

        //    //created.Populate(balance);

        //    //created.accNo = number;
        //    //created.accBal = balance;
        //    //created.accType = AccountType.Checking;

        //    return created;
        //}

        static void Write(BankAccount toWrite)
        {
            toWrite.GetInfo();

            foreach (BankTransaction tran in toWrite.Transactions())
            {
                Console.WriteLine("Date/Time: {0}\nAmount: {1}", tran.When(), tran.Amount());
            }
            
            //Console.WriteLine("Account number is {0}", toWrite.Number());
            //Console.WriteLine("Account balance is {0}", toWrite.Balance());
            //Console.WriteLine("Account type is {0}", toWrite.Type());
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
}
