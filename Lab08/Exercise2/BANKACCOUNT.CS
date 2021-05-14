using System;
using System.Collections;

namespace Lab08.Exercise2
{


    class BankAccount    
    {

        public BankAccount()
        {
            accNo = NextNumber();
            accBal = 0;
            accType = AccountType.Checking;
        }
        public BankAccount(AccountType type)
        {
            accNo = NextNumber();
            accBal = 0;
            accType = type;
        }
        public BankAccount(decimal defaultDepostit)
        {
            accNo = NextNumber();
            accBal = defaultDepostit;
            accType = AccountType.Checking;
        }

        public BankAccount(AccountType type, decimal defaultDeposit)
        {
            accNo = NextNumber();
            accBal = defaultDeposit;
            accType = type;
        }


        private Queue tranQueue = new Queue();

    
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

                BankTransaction tran = new BankTransaction(deposit);
                tranQueue.Enqueue(tran);
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
                BankTransaction tran = new BankTransaction(-amount);
                tranQueue.Enqueue(tran);
                accBal -= amount;
            }
            return enoughMoney;
        }

        public void TransferFrom (BankAccount accFrom, decimal amount)
        {
            if (accFrom.Withdraw(amount))
            {
                this.Deposit(amount);
            }

        }

        public void GetInfo()
        {
            Console.WriteLine("\n=====INFO=====");
            Console.WriteLine("Account number is {0}", this.Number());
            Console.WriteLine("Account balance is {0}", this.Balance());
            Console.WriteLine("Account type is {0}", this.Type());
            Console.WriteLine("=====END=====\n");
        }

        public Queue Transactions()
        {
            return tranQueue;
        }
    }
}
