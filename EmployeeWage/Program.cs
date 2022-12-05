using System;

namespace EmployeeeWage

{
    internal class Program

    {
        static void Main(string[] args)
        {

            int fulltime = 1;
            Random random = new Random();
            int checkpresent = random.Next(0, 2);
            Console.WriteLine("Random " + checkpresent);
            if (checkpresent == fulltime)
               {
                Console.WriteLine("employee is present");
               }
            else
            {
                Console.WriteLine("employee is absent");
            }

        }

    }

}