using System;
using Reward_Assignment.Repository;

namespace Reward_Assignment
{
    
    class Program
    {

        static void Main(string[] args)
        {

            RewardAssignment model = new RewardAssignment();
            Console.WriteLine();
            Console.WriteLine("**************************************");
            Console.WriteLine("Please Add 10 Transaction Amounts");
            Console.WriteLine("**************************************");
            for (int i= 1;i<=10;i++)
            {
                Console.WriteLine("Add "+i+" Transaction Amount");
                model.addTransaction(int.Parse(Console.ReadLine()));
                Console.WriteLine();
            }
            var list = model.getAllTransactions();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Price    Reward     Date");
            Console.WriteLine("**************************************************");
            foreach (var item in list)
            {
                Console.WriteLine(item.price + "    " + item.Rewards + "     " + item.Date); 
            }
            Console.ReadLine();
            
        }
    }
}
