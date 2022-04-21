using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maskine
{
    public class Terning
    {
        public int AntalSider;
        public int Værdi;

        public int Kast()
        {
            Random random = new Random();
            int value = random.Next(1, AntalSider+1);
            Værdi = value; 
            return value;
        }
    }
}
