using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORK
{
    internal class Vowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any Alpabate");
            char ch = Convert.ToChar(Console.ReadLine().ToLower());
            Console.WriteLine(ch);

            switch (ch)
            {
                case 'a':
                    Console.WriteLine("alphabate is vowel");
                    break; ;
                case 'e':
                    Console.WriteLine("alphabate is vowel");
                    break;
                case 'i':
                    Console.WriteLine("alphabate is vowel");
                    break;
                case 'o':
                    Console.WriteLine("alphabate is vowel");
                    break;
                case 'u':
                    Console.WriteLine("alphabate is vowel");
                    break;
                default:
                    Console.WriteLine("alphabate is consonants");
                    break;
            }




        }
    }
 }
