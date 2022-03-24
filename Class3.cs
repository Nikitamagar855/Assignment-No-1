using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORK
{
    internal class Calc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter  first No");
            int no1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second no ");
            int no2=Convert.ToInt32(Console.ReadLine());

            string operand;
            float ans;
            Console.WriteLine("please enter operand ");
            operand=Console.ReadLine();

            switch (operand)
            {
                case "+":
                    ans = no1+ no2;
                    break;
                case "-":
                    ans= no1- no2;
                    break ;
                 case "*":
                    ans = no1*no2;
                    break;
                case "/":
                    ans = no1 / no2;
                    break;
                default:
                    Console.WriteLine( " invalid input please enter valid input");
                    break;




                    Console.WriteLine(no1.ToString()+" "+operand+" "+no2.ToString()+"="+ans.ToString());
                    Console.ReadLine();
            }
        }
    }
}
