using System;

namespace EloadasProject
{

    class Eloadas
    {
        private bool[,] foglalasok;

        int foglalas = 0;
        int sorokSzama;
        int helyekSzama;


        public Eloadas(int sorokSzama, int helyekSzama)
        {
            if (sorokSzama > 0 && helyekSzama > 0)
            {
                this.sorokSzama = sorokSzama;
                this.helyekSzama = helyekSzama;
                foglalasok = new bool[sorokSzama, helyekSzama];
            }
            else
            {
                ArgumentException e;
            }
        }
        public bool Lefoglal()
        {
            if (SzabadHelyek > 0)
            {
                foglalas++;
                return true;
            }
            return false;
        }
        public int SzabadHelyek
        {
            get
            {
                return (helyekSzama * sorokSzama) - foglalas;
            }
        }
        public bool Teli
        {
            get
            {
                return (helyekSzama * sorokSzama) == foglalas;
            }
        }
        public bool Foglalt(int sorSzam, int helySzam)
        {
            if (sorSzam > 0 && helySzam > 0)
            {

            }
            else
            {
                ArgumentException e;
            }
            return false;
        }
    }


}
