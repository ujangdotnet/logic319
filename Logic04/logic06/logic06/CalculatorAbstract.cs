using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic06
{
    public abstract class CalculatorAbstract
    {
        public abstract int jumlah(int x, int y);

        public abstract int kurang(int x, int y);
    }

    public class TestTurunan : CalculatorAbstract
    {
        public override int jumlah(int x, int y)
        {
            return x + y;
        }

        public override int kurang(int x, int y)
        {
            return x - y;
        }
    }
}
