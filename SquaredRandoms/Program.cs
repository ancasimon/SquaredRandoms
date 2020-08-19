using System;
using System.Collections.Generic;
using System.Linq;

namespace SquaredRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var randomNumberList = new List<int>();
            var squaredRandomNumberList = new List<int>();
            int squaredNumber;
            //var evenSquaredNumbersOnly = new List<int>();


            //1 - get randomly-generated numbers and add them to a collection:
            //initial way of generating numbers:
            //var numberA = random.Next(51);
            //var numberB = random.Next(51);
            //var numberC = random.Next(51);
            //var numberD = random.Next(51);
            //randomNumberList.Add(numberA);
            //randomNumberList.Add(numberB);
            //randomNumberList.Add(numberC);
            //randomNumberList.Add(numberD);

            //1 - updated way to reduce code:
            var numberOfInstances = 20;
            for (var i = 0; i < numberOfInstances; i++)
            {
                var newNumber = random.Next(51);
                randomNumberList.Add(newNumber);
            }

            Console.WriteLine("Here is your list of random numbers:");
            foreach ( var num in randomNumberList)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            //2 - square them:
            foreach (var number in randomNumberList)
            {
                squaredNumber = number * number;
                squaredRandomNumberList.Add(squaredNumber);
            }

            Console.WriteLine("Here is a list of the random numbers squared: ");
            foreach (var squaredNum in squaredRandomNumberList)
            {
                Console.WriteLine(squaredNum);
            }
            Console.WriteLine();

            //3 - find only the even numbers in the list of results after squaring the original numbers and put them in a new collection:
            //foreach (var number in squaredRandomNumberList)
            //{
            //    if (number % 2 == 0)
            //    {
            //        evenSquaredNumbersOnly.Add(number);
            //    }
            //}

            //Console.WriteLine("Here is the final list with even squared numbers only: ");
            //foreach (var evenNum in evenSquaredNumbersOnly)
            //{
            //    Console.WriteLine(evenNum);
            //}

            //3 - Hmm - I was trying a different way - but getting an error that the collection  was modified and enumeration operation may not execute ... SO - I cannot remove the item while iterating over the collection?
            //BUT apparently I can use a regular for loop?? Why??
            //foreach ( var number in squaredRandomNumberList)
            //{
            //    if (number % 2 != 0)
            //    {
            //        squaredRandomNumberList.Remove(number);
            //    }
            //}

            //for (var i = 0; i < squaredRandomNumberList.Count; i++)
            //{
            //    if(squaredRandomNumberList[i] % 2 != 0 )
            //    {
            //        squaredRandomNumberList.Remove(squaredRandomNumberList[i]);
            //    }
            //}

            //Console.WriteLine("Here is the final list updated to include only even squared results.");
            //foreach (var evenNum in squaredRandomNumberList)
            //{
            //    Console.WriteLine(evenNum);
            //}

            //With the last version above: I do still get odd numbers in my final list - why????? GOT IT!!! Because the integers are always rounded down!! So that's how odd numbers get in my final list in this version! because the remainder is rounded down!!

            //UPDATE: One more option for the last list - using Linq and .Where()!
            var evenSquaredNumbersOnly = squaredRandomNumberList.Where(number => (number % 2 == 0));

            Console.WriteLine($"Here is the final list of even only numbers: {string.Join(",", evenSquaredNumbersOnly)}");
        }
    }
}
