<<<<<<< HEAD
﻿using System;
using System.Globalization;
using ExercicioExcecoes.Entities;
using ExercicioExcecoes.Entities.Exceptions;

public class ProcessFile
{
    public static void Main()
    {
        Console.WriteLine("Enter account data");
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Holder: ");
        String holder = Console.ReadLine();
        Console.Write("Initial balance: ");
        double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Withdraw limit: ");
        double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Account acc = new Account(number, holder, balance, withdrawLimit);

        Console.WriteLine();
        Console.Write("Enter amount for withdraw: ");
        double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        try
        {
            acc.Withdraw(amount);
            Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
        }
        catch (DomainException e)
        {
            Console.WriteLine("Withdraw error: " + e.Message);
        }
    }
=======
﻿using System;
using System.Globalization;
using ExercicioExcecoes.Entities;
using ExercicioExcecoes.Entities.Exceptions;

public class ProcessFile
{
    public static void Main()
    {
        Console.WriteLine("Enter account data");
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Holder: ");
        String holder = Console.ReadLine();
        Console.Write("Initial balance: ");
        double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Withdraw limit: ");
        double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Account acc = new Account(number, holder, balance, withdrawLimit);

        Console.WriteLine();
        Console.Write("Enter amount for withdraw: ");
        double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        try
        {
            acc.Withdraw(amount);
            Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
        }
        catch (DomainException e)
        {
            Console.WriteLine("Withdraw error: " + e.Message);
        }
    }
>>>>>>> 1ca3199ed7d57dfcdade365a5d625c1855f8c4d0
}