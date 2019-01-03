using System;
using System.Collections.Generic;


namespace Arrays_And_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays 
            //Ex 1 creating an array
            int[] numArray = new int[5]; //read as array length of 5, create new instance of an array called an object
            numArray[0] = 5;
            numArray[1] = 2;
            numArray[2] = 10;
            numArray[3] = 200;
            numArray[4] = 5000;

            //Ex 2 another way of creating an array
            int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

            Console.WriteLine(numArray1[3]); //switch between numArray and numArray1
            Console.ReadLine();
        }
    }
}
