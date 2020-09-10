using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
   class Filter
    {

   public static void Fil()
    {

            List<string> words = new List<string> { "ajeeth@impelsys.com",
                "thashina@impelsys.co.in",
                "shan@impelsys.com",
                "sam@gmail.co.in",
                "maimu@impelsys.com"
                 };

          var filtered1 = new List<string>();
           var filtered2 = new List<string>();


            foreach (var word in words)
            {
                if (word.EndsWith(".com"))
                {
                    filtered1.Add(word);
                }
                if (word.EndsWith(".co.in"))
                {
                    filtered2.Add(word);
                }

            }
            Console.WriteLine("email ids ending with .com are as follows");

            Console.WriteLine(string.Join("\n", filtered1));
            Console.WriteLine("email ids ending with .co.in are as follows");
            Console.WriteLine(string.Join("\n", filtered2));
            Console.Read();

        }
}
    }

