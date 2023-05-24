//using System;


////in this exercise we exercise the static key word and Array
//namespace IntroCS
//{
//	public class SimpleBanking
//	{
//        static decimal[] accountBalances = new decimal[5];

//        // Array to store customer account names
//        static string[] accountNames = new string[5];
//        //static keys allow us to use the method without creating an instance
//        static void PrintData(decimal[] balances) {
//            foreach (decimal balance in balances) {
//                Console.WriteLine("Account Balance:" + balance);
//            }
//        }
       
//        //without the static key word an instance needs to be created first
//        //public void PrintData(decimal[] balances)
//        //{
//        //    foreach (decimal balance in balances)
//        //    {
//        //        Console.WriteLine("Account Balance:" + balance);
//        //    }
//        //}
//        static void Main() {
//            // Array to store customer account balances
     

//            // Add initial customer account information
//            accountBalances[0] = 1000.00m;
//            accountNames[0] = "John Doe";

//            // Add more customer account information
//            accountBalances[1] = 500.00m;
//            accountNames[1] = "Jane Smith";
//            SimpleBanking one = new SimpleBanking();
//            SimpleBanking.Deposit(1, 5000, accountBalances);
//            SimpleBanking.PrintData(accountBalances);
//        }
//        static void Deposit(int accountIndex, decimal balance, decimal[] balances)
//        {
//            if (accountIndex > 0) {
//                balances[accountIndex] = balance;
//            }
//        }

//    }
//}

