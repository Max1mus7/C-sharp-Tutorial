﻿using System;

namespace Tutorial
{
    internal class Program
    {
        //Ask people how much programming knowledge people have so as to get a general baseline for the audience
        //
        //Have people create their new projects
        //
        //Explain how the main method works
        //
        //Explore the Hello World application they have created(Or create one for them if it is not automatically generated)
        //
        //Explain variables
        //ESPECIALLY bring up the difference between String and the rest of the variables
        //Only bring up var if you feel it is necessary
        //explain the difference between int and double and have them play with the differences for a bit(unless they obviously have a full grasp on it)
        //Modulo(%) should be touched but not emphasised
        //
        //Give brief overview of methods as a concept
        //
        //Explain a few basic methods(Especially Console.WriteLine() and Console.ReadLine()
        //Remember to bring up .Equals(arg1) and .Equals(arg1, arg2) and the difference between them
        //***Explain Convert.To<InsertDataTypeHere>***
        //Have them try something with user input here
        //
        //***GUIDE*** Them on final project of the day(unless we finish this quicker than I expect)
        //Final Project is console calculator
        //Provide help when necessary/tips when they are asked for
        //
        //Before they leave, talk about how a framework is also going to use HTML, CSS, and a database like SQL
        //Encourage them to go check it out for themselves when they go home/back to their dorms79+
        private static void Main(string[] args)
        {
            String text = "Hello World";
            Console.WriteLine(text);
            Console.WriteLine("\n\nThis program takes two numbers and performs an operation of your choice");

            Console.WriteLine("\nPlease input a number:");
            double input1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nPlease input a second number:");
            double input2 = Convert.ToDouble(Console.ReadLine());
            bool worked = false;

            Console.WriteLine("\nPlease input the operation you would like to perform(Add,Subtract,etc)");
            String operation = Console.ReadLine();
            while (worked == false)
            {
                if (operation.Equals("Add", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(input1 + input2);
                    break;
                }

                if (operation.Equals("Subtract", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(input1 - input2);
                    break;
                }

                if (operation.Equals("Multiply", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(input1 * input2);
                    break;
                }

                if (operation.Equals("Divide", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(input1 / input2);
                    break;
                }
                Console.WriteLine("\nSorry, either you input an invalid operation or this calculator does not support the operation you are trying to perform. Please try again:");
                operation = Console.ReadLine();
            }
        }
    }
}