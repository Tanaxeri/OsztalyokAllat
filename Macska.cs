using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsztalyokAllat
{
    class Macska : Emlosok
    {
        public Macska(string nem, int suly, int labakszama) : base(nem, suly, labakszama)
        {



        }

        public override void hangotad()
        {

            Console.WriteLine("\nMiau Miau");

        }

    }
}
