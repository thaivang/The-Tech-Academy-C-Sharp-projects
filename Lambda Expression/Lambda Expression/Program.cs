using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.In the Main() method, create a list of at least 10 employees.
            //Each employee should have a first and last name, as well as an Id.At least two employees should have the first name "Joe".

            //2.Using a foreach loop, create a new list of all employees with the first name "Joe".

            //3.Do the same thing again, but this time with a lambda expression.

            //4.Using a lambda expression, make a list of all employees with an Id number greater than 5

            List<Employee> Employee = new List<Employee>()// List is type Employee so all properties can be addes to the list 
            {
            new Employee() { FirstName = "Joe", LastName = "Moe", Id = 1 },// Initialize list with collection initializer.
            new Employee() { FirstName = "Joe", LastName = "Dirt", Id = 2 },// Creates new objects from class with properties
            new Employee() { FirstName = "Kenny", LastName = "Penny", Id = 3 },
            new Employee() { FirstName = "Jenny", LastName = "Jcpenny", Id = 4 },
            new Employee() { FirstName = "Billy", LastName = "Bob", Id = 5 },
            new Employee() { FirstName = "Kathy", LastName = "Mathy", Id = 6 },
            new Employee() { FirstName = "Mary", LastName = "Smelly", Id = 7 },
            new Employee() { FirstName = "Shelly", LastName = "Jelly", Id = 8 },
            new Employee() { FirstName = "Bart", LastName = "Fart", Id = 9 },
            new Employee() { FirstName = "Margaret", LastName = "Target", Id = 10 }
            };

            List<Employee> People = new List<Employee>();
            foreach (Employee name in Employee)// foreach (type) (variable name) in the (List Name) + iterates through list adding Employee with FirstName
                                          // Joe to the new list.
            {
                if (name.FirstName == "Joe")
                {
                    People.Add(name);
                    Console.WriteLine("Names with " + name.FirstName + " using foreach loop");
                }
            }
            
            // Lambda Expression
            List<Employee> People2 = new List<Employee>();
            People2 = Employee.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee person in People2)
            {
                Console.WriteLine("Names " + person.FirstName + " Added to the List using lambda");
            }

            //Employee Id > 5, Lambda 
            List<Employee> People3 = new List<Employee>(); //new ofr all employees wi
            People3 = Employee.Where(x => (x.Id > 5)).ToList();
            foreach (Employee personId in People3)
            {
                Console.WriteLine(personId.Id);
            }
            Console.ReadLine();      
        }
    }
}
