using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsFormulas.NumberSets
{
    public class ImaginaryNumber
    {
        public string i = "i";

        public string PowerOfImaginaryNumber(int xp, int n, int s)
        {
            if (xp == 1) { return "i"; }
            else if (xp == 2) { return "-1"; }
            else if (xp == 3) { return "-i"; }
            else if (xp == 4 && n == 0 && s == 0) { return "1"; }
            else if (xp == 5) { return "i"; }
            else if (xp == 6) { return "-1"; }
            else if (xp == 7) { return "1"; }
            else if (xp == 8) { return "1"; }
            else if (xp == 4 && n != 0 && s == 1) { return "i"; }
            else if (xp == 4 && n != 0 && s == 2) { return "-1"; }
            else if (xp == 4 && n != 0 && s == 3) { return "-i"; }
            else if (xp == 4 && n != 0 && s == 0) { return "1"; }
            else { return "0"; }

        }
    }
}
