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
    class Ordek : Hayvan, ISes
    {
        public int ordekyumurtasi;
        private int ordekenerji;
        private int ordekgelir;
        public bool ordekkontrol = true;
        public override int Enerji
        {
            get
            {
                return ordekenerji;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                ordekenerji = value;
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
        public Ordek()
        {
            ordekyumurtasi = 0;
            Enerji = 100;
        }
        public override int Gelir()
        {
            ordekgelir = ordekyumurtasi * 3;
            ordekyumurtasi = 0;
            return ordekgelir;
        }
        public void Ses()
        {
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + @"\ordek.wav";
            ses.SoundLocation = dizin;
            ses.Play();
            ordekkontrol = false;
        }
        public override int Urun()
        {
            if (Yasam() == true)
            {
                ordekyumurtasi++;
            }
            return ordekyumurtasi;
        }

        public override int EnerjiHarcama()
        {
            Enerji -= 3;
            return Enerji;
        }

        public override int CanBas()
        {
            Enerji = 100;
            return Enerji; ;
        }
    }
}
