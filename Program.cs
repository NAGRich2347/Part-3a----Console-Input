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
            Console.WriteLine($"Hello, {first_name}! please enter your age.");
            user_age = Convert.ToInt32(Console.ReadLine());

            int this_year = 2020;

            int answerSubtract;
            answerSubtract = this_year - user_age;
            
            Console.WriteLine($"The current year is {this_year}. If you are {user_age} now, this means you were born in {answerSubtract}.");
            Console.ReadLine();
            
            







            //Console.WriteLine($"The current year is 2020. In 2020, {first_name} is {user_age}.");
            //Console.ReadLine();

            //Console.WriteLine($"Your first name is {first_name}. Your age is {user_age} years old.");
            //Console.ReadLine();

            //Console.WriteLine($"This means that you were born in {current_year} - {user_age}.");
            //Console.ReadLine();
        }
    }
}
