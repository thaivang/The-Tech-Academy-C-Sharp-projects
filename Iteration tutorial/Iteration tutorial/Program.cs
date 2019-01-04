using System;
using System.Collections.Generic;

namespace Iteration_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variest examples showing how to create an array and lists with a for loop 
            // === Must comment in each examples in order for it to work ===
            // lists uses that data type -> using System.Collections.Generic;

            //ex 1 ==========
            int[] testscores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 }; ////int array

            for (int i = 0; i < testscores.length; i++) //starting at 0, for each i less than the length in testscores, increment by 1
            {
                if (testscores[i] > 85) // for each i that is less than length increment by 1 for each int that is greater than 85
                {
                    console.writeline("passing test score: " + testscores[i]);
                }
            }
            console.readline();

            string[] names = { "thai", "jason", "tyler", "ann" }; ////string array

            for (int j = 0; j < names.length; j++)
            {
                if (names[j] == "thai") // without if statemtn console.writeline(names[j]); will print all names inside of string array
                {
                    console.writeline(names[j]);
                }
            }
            console.readline();

            //ex 2 ===========
            list<int> testscores = new list<int>(); // create list
            testscores.add(99);
            testscores.add(98);
            testscores.add(81);
            testscores.add(72);
            testscores.add(70);

            foreach (int score in testscores) //goes through each list
            {
                if (score > 85)
                {
                    console.writeline("passing test score: " + score);
                }
            }
            console.readline();

            //ex 3 =========
            list<string> names = new list<string>() { "thai", "jason", "tyler", "ann" };

            foreach (string name in names)
            {
                console.writeline(name);
            }
            console.readline();

            //Ex 4 Meet a certain condition and add it to a new list =====
            List<int> testScores = new List<int>() { 99, 99, 98, 74, 12, 23};
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }
            Console.WriteLine(passingScores.Count);
            Console.WriteLine(passingScores.());
            Console.ReadLine();
        }  
    }
}
