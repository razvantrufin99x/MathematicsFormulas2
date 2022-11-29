using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsFormulas.NumberSets
{
    public class Pair
    {
        public Number A= new Number();
        public Number B = new Number();
        public Pair() { }
        public Pair(Number pA, Number pB) { A = pA;B = pB; }
        public Pair(float fA, float fB) { A = new Number(fA); B = new Number(fB); }
    }
}
