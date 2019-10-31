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
    class Tavuk : Hayvan, ISes
    {
        public int tavukyumurtasi;
        private int tavukenerji;
        private int tavukgelir;
        public bool tavukkontrol = true;
        public override int Enerji
        {
            get
            {
                return tavukenerji;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                tavukenerji = value;
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
        public Tavuk()
        {
            tavukyumurtasi = 0;
            Enerji = 100;
        }
        public override int Gelir()
        {
            tavukgelir = tavukyumurtasi * 1;
            tavukyumurtasi = 0;
            return tavukgelir;
        }

        public void Ses()
        {
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + @"\tavuk.wav";
            ses.SoundLocation = dizin;
            ses.Play();
            tavukkontrol = false;
        }
        public override int Urun()
        {
            if (Yasam() == true)
            {
                tavukyumurtasi++;
            }
            return tavukyumurtasi;
        }
        public override int EnerjiHarcama()
        {

            Enerji -= 2;
            return Enerji;
        }

        public override int CanBas()
        {
            Enerji = 100;
            return Enerji;
        }
    }
}
