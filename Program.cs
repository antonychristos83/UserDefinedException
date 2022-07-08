using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            checkAge(age);
        }
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access Denied");
            }
            else
            {
                Console.WriteLine("Access Granted");
            }
        }
    }
}
