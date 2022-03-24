// See https://aka.ms/new-console-template for more information
Console.WriteLine("ENTER YEAR :");
int year = Convert.ToInt32(Console.ReadLine());
if(((year %4==0) && (year % 100 == 0)) || (year % 400 == 0))
{
    Console.WriteLine("this is a leap year");
}
else

    Console.WriteLine("this is not leap year");
    Console.ReadLine();

