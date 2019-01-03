using System;
using System.Text;


namespace String_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenate 3 strings
            string word = "Concatenate";
            word += " 3";
            word += " strings.\n";
            Console.WriteLine(word);
            

            //Convert String to upper case
            string upperword = word.ToUpper();
            Console.WriteLine(upperword);
            

            //Create a Stringbuilder and build a paragraph of text, one sentence at a time.
            StringBuilder create = new StringBuilder();
            create.AppendLine("Welcome To the C# tutorial");
            create.AppendLine("In this tutorial we will learn how to use a string builder");
            create.AppendLine("We can also append strings on the same line of code").AppendLine("This is an example");
            Console.Write(create);
            
            Console.ReadLine();
        }
    }
}
