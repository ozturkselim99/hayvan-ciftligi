using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp7
{
    class Inek : Hayvan, ISes
    {
        public int ineksutu;
        private int inekenerji;
        private int inekgelir;
        public bool inekkontrol = true;
        public override int Enerji
        {
            get
            {
                return inekenerji;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                inekenerji = value;
            }
        }
        public override bool Yasam()
        {
            if (Enerji > 0)
            {
                return true;
            }
            else
                return false;
        }
        public Inek()
        {
            ineksutu = 0;
            Enerji = 100;
        }
        public override int Gelir()
        {
            inekgelir = ineksutu * 5;
            ineksutu = 0;
            return inekgelir;
        }
        public void Ses()
        {
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + @"\inek.wav";
            ses.SoundLocation = dizin;
            ses.Play();
            inekkontrol = false;
        }
        public override int Urun()
        {
            if (Yasam() == true)
            {
                ineksutu++;
            }
            return ineksutu;
        }
        public override int EnerjiHarcama()
        {
            Enerji -= 8;
            return Enerji;
        }

        public override int CanBas()
        {
            Enerji = 100;
            return Enerji;
        }
    }
}
