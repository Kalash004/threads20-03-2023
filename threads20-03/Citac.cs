using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threads20_03
{
    internal class Citac
    {
        private int hodnota = 0;

        public int Hodnota { get => hodnota; set => hodnota = value; }

        public int Zvys()
        {
            hodnota = hodnota + 1;
            return hodnota;
        }
        
        public int Sniz()
        {
            hodnota = hodnota - 1;
            return hodnota;
        }
    }
}
