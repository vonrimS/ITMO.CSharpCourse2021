using System;
using Banking1;


namespace Lab11.Exercise1
{
	class CreateAccount
	{
		// Test Harness
		static void Main()
		{
			long accNo1 = Bank.CreateAccount(AccountType.Checking, 100);
			long accNo2 = Bank.CreateAccount(AccountType.Checking, 100);

			BankAccount acc1 = Bank.GetAccount(accNo1);
			BankAccount acc2 = Bank.GetAccount(accNo2);

			BankAccount acc3 = Bank.GetAccount(accNo1);

			if (acc1.Equals(acc3))
			{
				Console.WriteLine("The accounts are the same. Good!");
			}
			else
			{
				Console.WriteLine("The accounts are different. They should not be!");
			}

			if (!acc1.Equals(acc3))
			{
				Console.WriteLine("The accounts are different. They should not be!");
			}
			else
			{
				Console.WriteLine("The accounts are the same. Good!");
			}

			Console.WriteLine("acc1 – {0}", acc1);
			Console.WriteLine("acc2 – {0}", acc2);
			Console.WriteLine("acc3 – {0}", acc3);

			acc1.Dispose();
			acc2.Dispose();
			acc3.Dispose();

		}

			static void TestDeposit(BankAccount acc)
			{
				Console.Write("Enter amount to deposit: ");
				decimal amount = decimal.Parse(Console.ReadLine());
				acc.Deposit(amount);
			}

			static void TestWithdraw(BankAccount acc)
			{
				Console.Write("Enter amount to withdraw: ");
				decimal amount = decimal.Parse(Console.ReadLine());
				acc.Withdraw(amount);
			}

			static void Write(BankAccount acc)
			{
				Console.WriteLine("Account number is {0}", acc.Number());
				Console.WriteLine("Account balance is {0}", acc.Balance());
				Console.WriteLine("Account type is {0}", acc.Type());
				Console.WriteLine("Transactions:");
				foreach (BankTransaction tran in acc.Transactions())
				{
					Console.WriteLine("Date/Time: {0}\tAmount: {1}", tran.When(), tran.Amount());
				}
				Console.WriteLine();
			}
		} 
	} 

