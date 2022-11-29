using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsFormulas.NumberSets
{
    public class Element
    {
        public float value;
        public Element() { }
        public Element(float value) { this.value = value; }
        public Element ComplementOfElementInsideSet(Set s)
        {
            //error
            return new Element(value*(-1)) ;
        }
        public bool Compare(ref Element x)
        {
            if (this.value == x.value)
            { 
                return true; 
            } 

            return false;
        }
        public Element Smaller(ref Element x)
        {
            if(x.value < this.value)
            {
                return x;
            }
            else
            {

                return this;
            }

        }
        public Element Bigger(ref Element x)
        {
            if (x.value > this.value)
            {
                return x;
            }
            else
            {

                return this;
            }

        }
        public bool Equals(ref Element x)
        {
            if (this.value == x.value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
