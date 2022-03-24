using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORK
{
    internal class MaxNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first No");
            int No1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second No");
            int No2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third No");
            int No3 = Convert.ToInt32(Console.ReadLine());

            if ((No1 > No2) && (No1 > No3))
            {
                Console.WriteLine(No1 + " is GREATER NO");

            }
            else if ((No1 < No2) && (No2 > No3))
            {
                Console.WriteLine(No2 + "Is greater");
            }
            else
            {
                Console.WriteLine(No3 + "is greater");
            }


        }

    }
}