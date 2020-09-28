using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReteaNeuronala
{
    class Functie
    {
        public string F;
        public int value;
        public Functie(string s,int i)
        {
            F = s;
            value = i;
        }

        public override string ToString()
        {
            return F;
        }
    }
}
