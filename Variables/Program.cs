using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args) // deze is een method
        {
            string firstName;
            string lastname;
            int age;
            int klas;

            //Console.WriteLine("Hello and Welcome " + firstName);
            //Console.WriteLine("Hello {0} and Welcome {0} ", firstName, firstName);
            Console.WriteLine("Enter your name please...");// show to the user
            firstName = Console.ReadLine(); // ask user for input

            Console.WriteLine("Enter your last name please...");
            lastname = Console.ReadLine();

            Console.WriteLine($"Hello {firstName} {lastname} and Welcome"); // show to the user

            Console.WriteLine("Enter your age please...");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your clas");
            klas = int.Parse(Console.ReadLine());

            // this is concatenation
            Console.WriteLine("your fullname is " + firstName + " " + lastname);

            // string interpolation
            Console.WriteLine($"You are {age} years old and you are in class {klas} ");
            Console.WriteLine("this is the last line " + age +" "+ klas);
            Console.ReadLine();
        }
    }
}
