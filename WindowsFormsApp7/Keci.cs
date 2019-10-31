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
    class Keci : Hayvan, ISes
    {
        public int kecisutu;
        private int kecienerji;
        private int kecigelir;
        public bool kecikontrol = true;
        public override int Enerji
        {
            get
            {
                return kecienerji;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                kecienerji = value;
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
        public Keci()
        {
            Enerji=100;
            kecisutu = 0;
        }
        public override int Gelir()
        {
            kecigelir = kecisutu * 8;
            kecisutu = 0;
            return kecigelir;
        }
        public void Ses()
        {
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + @"\keci.wav";
            ses.SoundLocation = dizin;
            ses.Play();
            kecikontrol = false;
        }
        public override int Urun()
        {
            if (Yasam() == true)
            {
                kecisutu++;
            }
            return kecisutu;
        }


        public override int EnerjiHarcama()
        {
            Enerji -= 6;
            return Enerji;
        }

        public override int CanBas()
        {
            Enerji = 100;
            return Enerji;
        }
    }
}
