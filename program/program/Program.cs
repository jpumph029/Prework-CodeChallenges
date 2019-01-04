using System;
using System.Collections.Generic;
using System.Linq;


namespace program
{
    class Program
    {
        static void Main()
        {
            ArrayMaxResult();
            LeapYearCalculator();
            PerfectSequence();
            SumOfRows();
        }
        static void ArrayMaxResult()
        {
            // generates 5 random number and sticks them into selection using LINQ
            int Min = 1;
            int Max = 10;
            Random randNum = new Random();
            int[] selection = Enumerable
            .Repeat(0, 5)
            .Select(i => randNum.Next(Min, Max))
            .ToArray();
            // writes each number in n the section array
            Console.WriteLine("Array Max Result");
            foreach (var item in selection)
            Console.WriteLine(item);
            //uses Write and Convert.ToInt32 to see the console window input then make it a string
            Console.Write("Choose a number from above: ");
            int input;
            input = Convert.ToInt32(Console.ReadLine());
            //checks for matching numbers and multiplies by how many times it occurs and returns results
            int result;
            int[] resultArr = Array.FindAll(selection, el => el == input);
            result = input * resultArr.Length;
            Console.WriteLine($"The result is: {result}.");
            Console.ReadLine();
        }
        static void LeapYearCalculator()
        {
            //uses a if else to see if the input is divisible by 4, 100, 400, to see if a year falls under a leap year.
            Console.WriteLine("Please type a year to see if it falls under a leap year.");
            int input = Convert.ToInt32(Console.ReadLine());
            string res;
            if ( input % 4 == 0 || input % 100 == 0 || input % 400 == 0 )
                res = $"{input} fell on a leap year.";
                    else
                        res = $"{input} does not fall on a leap year.";
            Console.WriteLine(res);
            Console.ReadLine();
        }
        static void PerfectSequence()
        {
            //new list to hold the input of the user
            List<int> sequenceInput = new List<int>();
            int input;
            int prod = 1;
            int sum = 0;
            //takes user input and adds it to the list 3 times
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{i} out of 3 -- Enter a Perfect Sequence of Numbers one at a time: ");
                input = Convert.ToInt32(Console.ReadLine());
                sequenceInput.Add(input);
            }
            //multiplying and adding each num from the sequenceInput list YES/NO using an if else to 
            foreach (int num in sequenceInput)
            {
                prod *= num;
                sum += num;
            }
            if (sum == prod)
                Console.WriteLine("Your number makes a perfect sequence.");
            else
                Console.WriteLine("Your number does not make a perfect sequence.");
                Console.ReadLine();
        }
        static void SumOfRows()
        {
            Random randNum = new Random();
            int userLength = 0;
            int userHeight = 0;
            //takes users inputs and assigns the length and height of the mutltiple dimension myArray
            Console.Write("Please enter the length of your array: ");
            userLength = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the height of your array: ");
            userHeight = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            int[,] myArray = new int[userHeight, userLength];
            //Generates numbers for the multiple dimension myArray based on the length and height the user chose
            Console.WriteLine("Your array: ");
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = randNum.Next(-99, 99);
                    Console.Write($"{myArray[i, j]} ");
                }
                Console.WriteLine("]");
            }
            //adds all positions of the array
            int[] result = new int[myArray.GetLength(0)];
            int sum;
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < myArray.GetLength(1); j++)
                    sum += myArray[i, j];
                    result[i] = sum;
            }
            Console.Write("The sum of the rows is: ");
            foreach (var item in result)
                Console.Write($"{item} ");
                Console.ReadLine();
        }
    }
}
