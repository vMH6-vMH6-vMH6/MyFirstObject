﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstObject
{
    class Program
    {
        static void Main(string[] args)
        {

            BankAccount myAccount = new BankAccount();
            myAccount.Balance = 5;
            myAccount.CustomerName = "Matt";

            Console.WriteLine(" The account name is " + myAccount.CustomerName);
            Console.WriteLine("The amount of money i have is " + myAccount.Balance);

            float newDeposit;
            float newBalance;
            Console.WriteLine(" Input your transaction ammount");
            newDeposit = float.Parse(Console.ReadLine());
            newBalance = myAccount.NewBalance(newDeposit);
            Console.WriteLine(newBalance);
            Console.ReadLine();

        }///////////////////////////////////////////////////
    }
}
