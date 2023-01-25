using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1
{
    class Assignment1Calc
    {
        static void Main()
        {
            int num1, num2, result1, result2, result3, result4;
            Console.WriteLine("Please Enter 2 int numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            result1 = num1 + num2;
            result2 = num1 - num2;
            result3 = num1 * num2;
            result4 = num1 / num2;
            Console.WriteLine("The sum is " + result1);
            Console.WriteLine("The difference is " + result2);
            Console.WriteLine("The product is " + result3);
            Console.WriteLine("The division is " + result4);
            Console.ReadLine();
        }

    }
}
