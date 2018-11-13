using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_156
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("The current date + time is: " + DateTime.Now);
            Console.WriteLine("Please enter a number:");
            int userInput = Convert.ToInt32(Console.ReadLine());
            DateTime xHoursLater = currentTime.AddHours(userInput);
            Console.WriteLine("In {0} hours it will be {1}", userInput, xHoursLater);
            Console.ReadLine();
        }
    }
}
