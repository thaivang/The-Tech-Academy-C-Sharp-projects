using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Thai";
            //string quote = "The man said, \"Hello\", Thai. \n Hello on a new line. \n \t Hello on a new tab with new line";
            //String fileName = @"C:\Users\Jesse"; //@ same as "C:\\Users\\Thai"

            //bool trueOrFalse = name.Contains("i");
            //trueOrFalse = name.EndsWith("i");

            //int length = name.Length;

            //name = name.ToLower();


            //Console.WriteLine(length);
            //Console.WriteLine(trueOrFalse);
            //Console.WriteLine(fileName);
            //Console.WriteLine(quote);
            //Console.ReadLine();

            //Strings are immutable and string builder is mutable  
            string name = "Thai";
            name = "Jason";
            Console.WriteLine(name);
            Console.ReadLine();

            //dynamic object
            StringBuilder sb = new StringBuilder();

            sb.Append("My Name is Thai");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
