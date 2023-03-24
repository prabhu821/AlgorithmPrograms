using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_AlgorithmAndProgrammingProblems.DataStructurePrograms;

public class BankCashCounter
{
    BankQueue<string> queue;
    int totalAmount;
    public void CashCounter()
    {
        string line = "1,2,3,4";
        string[] words = line.Split(",");
        queue = new BankQueue<string>();
        foreach (var word in words)
        {
            queue.Enqueue(word);
        }
        queue.Display();
        Console.Write("Total Amount Available in Bank Initially :");
        totalAmount = Convert.ToInt32(Console.ReadLine());
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("\nWelcome To Bank Cash Counter");
            Console.WriteLine("Select The Option \n1.Deposit Amount\n2.Withdraw Amount\n3.Exit");
            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Deposit();
                    break;
                case 2:
                    Withdraw();
                    break;
                default:
                    flag = false;
                    break;
            }
        }
        Console.WriteLine("Cash available in Bank: " + totalAmount);
    }
    public void Deposit()
    {
        Console.Write("Enter the amount you want to Deposit: ");
        int deposit = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Money Deposited Successfully");
        totalAmount += deposit;
        queue.Dequeue();
    }
    public void Withdraw()
    {
        Console.Write("Enter the amount you want to Withdraw: ");
        int withdraw = Convert.ToInt32(Console.ReadLine());
        if (totalAmount > withdraw)
        {
            if (withdraw <= 2000)
            {
                totalAmount -= withdraw;
                queue.Dequeue();
                Console.WriteLine("Money Withdraw Succesfully");
            }
            else
            {
                Console.WriteLine("InsufficientBalance.Try Again");
                Withdraw();
            }
        }
    }
}
