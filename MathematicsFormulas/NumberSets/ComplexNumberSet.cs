using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsFormulas.NumberSets
{
    public class ComplexNumberSet
    {
        //real part A and B
        public Number RealPartA = new Number();
        public Number RealPartB = new Number();
        //imaginary part is a char
        public ImaginaryNumber ImaginariParti = new ImaginaryNumber();
        //modulus
        public float fi = 0.0f;
        //argument
        public float r = 0.0f;

        //z = a + b*i

        public float Modulus() {
            return this.fi;
        }

        public float Argument()
        {
            return this.r;
        }

        //end of day 1

        //identities in C set of numbers
        //power of imaginari numbers set

        public ComplexPlane ZPlane;
        public ImaginaryAxis iAxis;
        public RealAxis RAxis;

        //operations with complex numbers

        //add
        //dif
        //mult
        //div

        //conjugate

        //a = r cos fi
        //b = r sin fi

        //graphic representation of Z
        //graphic of x0y plane representing Z = a+bi
        //with bi on y
        //and a on x
        //r length of vector a+bi
        //fi the angle of vector relative of x 

        //polar representation of Z
        //a+bi = r(cos fi + i sin fi)

        //modulus and argument of a Z
        //if a+bi =z
        //then
        //modulus
        //r = sqrt(a^2 + b^2)
        //argument
        //fi = arctan (b/a)

        //product in polar repr
        //z1*z2


        //conjugate in polar rep
        //r(cos fi + i sin fi)negat

        //inverse of Z in pr
        //1/r(cos fi + i sin fi)

        //quotient in p.r.
        //z1/z2

        //poqer of Z
        //z^n

        //formula de moivre

        //nth root of Z
        //nsqrt(z)

        //euler formula
        //e^ix




    }
}
