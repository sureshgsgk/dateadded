using System;
using System.Globalization;

namespace NewDate
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            String myDate = "31/01/2016";
            Console.WriteLine("Current Date: "+ myDate);
            Console.WriteLine("Please Add Days");
            number = Convert.ToInt32(Console.ReadLine());
            CultureInfo culture = new CultureInfo("es-ES");
            DateTime date = DateTime.Parse(myDate, culture);
            string ss = date.ToString("dd/MM/yyyy");
            DateTime dt1 = Convert.ToDateTime(ss);
            DateTime result = dt1.AddDays(number);
            string result1 = result.ToString("dd/MM/yyyy");
            Console.WriteLine("New Date: " + result1);
        }
    }
}
