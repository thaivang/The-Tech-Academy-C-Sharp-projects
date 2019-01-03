using System;
using System.Collections.Generic;


namespace Arrays_And_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lists

            List<int> intList = new List<int>(); //Type variable (name), also can do - new List<string> name 
            intList.Add(4); // index 0 
            intList.Add(10); // index 1
            intList.Remove(10); // removes list value

            Console.WriteLine(intList[1]);
            Console.ReadLine();


            // Ways to create Arrays 
            //Ex 1 Creating an array
            int[] numArray = new int[5]; //read as array length of 5, create new instance of an array called an object
            numArray[0] = 5;
            numArray[1] = 2;
            numArray[2] = 10;
            numArray[3] = 200;
            numArray[4] = 5000;

            //Ex 2 Another way of creating an array
            int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

            //Ex 3 Faster way of creating an array
            int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 }; //without declaring a new int[]

            numArray2[5] = 650; //changing an array at index 5 

            Console.WriteLine(numArray2[5]); //switch between numArray and numArray1
            Console.ReadLine();

        }
    }
}
