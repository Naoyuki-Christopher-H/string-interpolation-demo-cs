using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_interpolation_demo_cs
{
    class Solution
    {
        public Solution()
        {
            String FirstName = "Yuki";
            String LastName = "James";
            int Age = 33;

            Console.WriteLine($"Hello There.");
            Console.WriteLine($"My name is {LastName}.");
            Console.WriteLine($"{FirstName} {LastName}.");
            Console.WriteLine($"I am {Age} years old.");
        }
    }
}