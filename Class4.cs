using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORK
{
    internal class PosNegNo
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter No");
            int Num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Num);
            if (Num == 0)
            {
                Console.WriteLine("No is zero");
            }
            else if (Num > 0)
            {
                Console.WriteLine("No is poitive");
            }
            else
            {
                Console.WriteLine("No is negative");
            }
            Console.ReadLine();

        }
    }
}
