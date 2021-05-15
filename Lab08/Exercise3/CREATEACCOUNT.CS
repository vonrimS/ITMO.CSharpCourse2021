
using System;

namespace Lab08.Exercise3
{

    class CreateAccount
    {
        static void Main()
        {

            using (BankAccount acc1 = new BankAccount())
            {
                acc1.Deposit(100);
                acc1.Withdraw(50);
                acc1.Deposit(75);
                acc1.Withdraw(50);
                acc1.Withdraw(30);
                acc1.Deposit(40);
                acc1.Deposit(200);
                acc1.Withdraw(250);
                acc1.Deposit(25);
                Write(acc1);
            }
        }

        static void Write(BankAccount toWrite)
        {              

            foreach (BankTransaction tran in toWrite.Transactions())
            {
                toWrite.GetTransactionInfo(tran);                   
            }
        }
    }
}
