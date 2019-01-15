using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_IO_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of your choosing : ");
            int text = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\number.txt"))//true will append to file otherwise false or without false will create new file(overwriting the previous input)
            {
                file.WriteLine(text);
                file.Close();
                string file1 = File.ReadAllText(@"C:\number.txt");//file must be closed to read and print to screen
                Console.WriteLine("Your number is " + file1);
            }
            Console.ReadLine();

        }
    }
}
