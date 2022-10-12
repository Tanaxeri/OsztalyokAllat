using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsztalyokAllat
{
    class OsztalyokAllat
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program kezdődik...");

            List<Emlosok> emlos = new List<Emlosok>();
            emlos.Add(new Kutya("fiú", 58, 4));
            emlos.Add(new Macska("lány", 45, 4));
            foreach (Emlosok item in emlos)
            {

                item.hangotad();
                item.Emlos();

            }
            

            Console.WriteLine("\nProgram vége!");
            Console.ReadKey();
        }
    }
}
