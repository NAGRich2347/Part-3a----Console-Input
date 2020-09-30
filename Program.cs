using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3a____Console_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            string first_name;
            Console.WriteLine("Please enter your first name.");
            first_name = Console.ReadLine();

            int user_age;
            Console.WriteLine("Now, please enter your age ");
            user_age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The ");


            Console.WriteLine($"Your first name is {first_name}." +
                $"Your age is" {user_age});
        }
    }
}
