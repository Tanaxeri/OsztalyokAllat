using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsztalyokAllat
{
    class Kutya : Emlosok
    {
        public Kutya(string nem, int suly, int labakszama) : base(nem, suly, labakszama)
        {



        }


        public override void hangotad()
        {

            Console.WriteLine("\nVAU VAU");

        }

    }
}
