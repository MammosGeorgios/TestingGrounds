using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExperiments
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime date = new DateTime(2020, 11, 11);

            Console.WriteLine(date.DayOfWeek);
            //if (date.DayOfWeek.ToString() == "Friday") Console.WriteLine("equals works");

            if (date.DayOfWeek.ToString().Equals("Monday"))
            {
                Console.WriteLine("It's Monday");
            }
            else if (date.DayOfWeek.ToString().Equals("Tuesday"))
            {
                Console.WriteLine("It's Tuesday");
            }
            else if (date.DayOfWeek.ToString().Equals("Wednesday"))
            {
                Console.WriteLine("It's Wednesday");
            }
            else if (date.DayOfWeek.ToString().Equals("Thursday"))
            {
                Console.WriteLine("It's Thursday");
            }
            else if (date.DayOfWeek.ToString().Equals("Friday"))
            {
                Console.WriteLine("It's Friday");
            }
            else if (date.DayOfWeek.ToString().Equals("Saturday"))
            {
                Console.WriteLine("It's Saturday");
            }
            else //(date.DayOfWeek.ToString().Equals("Sunday"))
            {
                Console.WriteLine("It's Sunday");
            }

            DateTime date2 = new DateTime(2020, 11, 10);
            if (date2 < date) Console.WriteLine("date2 smaller than date");

        }
    }
}
