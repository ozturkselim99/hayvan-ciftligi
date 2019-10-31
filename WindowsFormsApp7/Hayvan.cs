using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    abstract class Hayvan
    {
        public abstract int Enerji { get; set; } 
        public abstract int Urun();
        public abstract int Gelir();
        public abstract bool Yasam();
        public abstract int EnerjiHarcama();
        public abstract int CanBas();
    }
}
