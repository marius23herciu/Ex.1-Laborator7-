using System;
using System.Collections.Generic;
using System.Text;

namespace Ex._1_Laborator7_
{
    class Mana
    {
        private Carte[] carti = new Carte[5];
        /// <summary>
        /// Creaza o mana de 5 carti.
        /// </summary>
        /// <param name="mana"></param>
        public Mana(Carte[] carti)
        {
            this.carti = carti;
        }
        /// <summary>
        /// Returneaza tipul mainii.
        /// </summary>
        public void GetTipMana()
        {

            int numerotareInimaNeagra = CheckRoyalFlush();
            int numerotareInimaRosie = CheckStraightFlush();
            int verificareNUmarIdentic = CheckFourOfAKind();

            if (verificareNUmarIdentic == 4)
            {
                Console.WriteLine("Four of a kind");
                Console.WriteLine();
            }
            else if (numerotareInimaNeagra == 5)
            {
                Console.WriteLine("Royal flush");
                Console.WriteLine();
            }
            else if (numerotareInimaRosie == 5)
            {
                Console.WriteLine("Straight flush");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Mana comuna");
                Console.WriteLine();
            }
        }
        private int CheckRoyalFlush()
        {
            int numerotareInimaNeagra = 0;
            Carte.SimbolCarte verificareSimbol = new Carte.SimbolCarte();
            foreach (Carte carte in carti)
            {
                verificareSimbol = carte.GetSimbol();
                if (verificareSimbol == Carte.SimbolCarte.InimaNeagra)
                {
                    numerotareInimaNeagra++;
                }
            }
            return numerotareInimaNeagra;
        }
        private int CheckStraightFlush()
        {
            int numerotareInimaRosie = 0;
            Carte.SimbolCarte verificareSimbol = new Carte.SimbolCarte();
            foreach (Carte carte in carti)
            {
                verificareSimbol = carte.GetSimbol();
                if (verificareSimbol == Carte.SimbolCarte.InimaRosie)
                {
                    numerotareInimaRosie++;
                }
            }
            return numerotareInimaRosie;
        }
        private int CheckFourOfAKind()
        {
            int verificareNUmarIdentic = 0;
            for (int i = 0; i < carti.Length; i++)
            {
                verificareNUmarIdentic = 0;
                for (int j = 0; j < carti.Length; j++)
                {
                    if (carti[i].GetNumar() == carti[j].GetNumar())
                    {
                        verificareNUmarIdentic++;
                    }
                }
                if (verificareNUmarIdentic == 4)
                {
                    break;
                }
            }

            return verificareNUmarIdentic;
        }
        /// <summary>
        /// Tipareste o mana.
        /// </summary>
        public void Tipareste()
        {
            Console.WriteLine("Mana: ");
            foreach (Carte carte in carti)
            {
                carte.Tipareste();
            }
        }
    }
}
