using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsztalyokAllat
{
    abstract class Emlosok
    {

        private string nem;
        private int suly;
        private int labakszama;

        public string Nem { get => nem; set => nem = value; }
        public int Suly { get => suly; set => suly = value; }
        public int Labakszama { get => labakszama; set => labakszama = value; }

        public Emlosok(string nem, int suly, int labakszama)
        {

            Nem = nem;
            Suly = suly;
            Labakszama = labakszama;

        }

        public virtual void Emlos() 
        {

            Console.WriteLine(string.Format("Neme: {0}", this.nem));
            Console.WriteLine(string.Format("Súlya {0} kg", this.suly));
            Console.WriteLine(string.Format("Lábakszáma: {0}", this.labakszama));

        }
        public abstract void hangotad();

    }
}
