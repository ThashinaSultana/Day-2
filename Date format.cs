using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Date
    {
        //private const string d = "MM/dd/yyyy";

        public static void D()
        {
            var dateTime = "01-06-2020 12:12:12";
            DateTime dt = DateTime.ParseExact(dateTime, "MM-dd-yyyy hh:mm:ss", CultureInfo.InvariantCulture);
            var convertedDate = dt.ToString("dd/MM/yyyy");
            Console.WriteLine(convertedDate);

        }

        
    }
}
