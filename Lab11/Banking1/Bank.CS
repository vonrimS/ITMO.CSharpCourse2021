using System;
using System.Collections;


namespace Banking1
{
    public class Bank
    {
        private Bank() { }

        private static Hashtable accounts = new Hashtable();

        internal static long CreateAccount()
        {
            BankAccount newAcc = new BankAccount();
            long bankAccNum = newAcc.Number();
            accounts[bankAccNum] = newAcc;
            return bankAccNum;
        }
        internal static long CreateAccount(decimal accDeposit)
        {
            BankAccount newAcc = new BankAccount(accDeposit);
            long bankAccNum = newAcc.Number();
            accounts[bankAccNum] = newAcc;
            return bankAccNum;
        }
        internal static long CreateAccount(AccountType accType)
        {
            BankAccount newAcc = new BankAccount(accType);
            long bankAccNum = newAcc.Number();
            accounts[bankAccNum] = newAcc;
            return bankAccNum;
        }
        internal static long CreateAccount(AccountType accType, decimal accDeposit)
        {
            BankAccount newAcc = new BankAccount(accType, accDeposit);
            long bankAccNum = newAcc.Number();
            accounts[bankAccNum] = newAcc;
            return bankAccNum;
        }

        public static bool CloseAccount(long bankAccNum)
        {
            BankAccount closing = (BankAccount)accounts[bankAccNum];

            if (closing != null)
            {
                accounts.Remove(closing);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static BankAccount GetAccount(long bankAccNum)
        {
            return (BankAccount)accounts[bankAccNum];
        }
    }
}