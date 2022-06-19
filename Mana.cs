using System;
using System.Collections.Generic;
using System.Text;

namespace Ex._1_Laborator7_
{
    class Mana
    {
        private Carte[] mana = new Carte[5];
        /// <summary>
        /// Creaza o mana de 5 carti.
        /// </summary>
        /// <param name="mana"></param>
        public Mana(Carte[] mana)
        {
            this.mana = mana;
        }
        /// <summary>
        /// Returneaza tipul mainii.
        /// </summary>
        public void GetTipMana()
        {
            SimbolCarte verificareSimbol = new SimbolCarte();
            int numerotareInimaNeagra = 0;
            int numerotareInimaRosie = 0;
            int numerotareNumar = 0;
            int[] vectorNumere = new int[5];

            int i = 0;
            foreach (Carte carte in mana)
            {
                verificareSimbol = carte.GetSimbol();
                if (verificareSimbol == SimbolCarte.InimaNeagra)
                {
                    numerotareInimaNeagra++;
                }
                if (verificareSimbol == SimbolCarte.InimaRosie)
                {
                    numerotareInimaRosie++;
                }

                vectorNumere[i] = carte.GetNumar();
                i++;
            }

            for (int k = 0; k < 2; k++)
            {
                numerotareNumar = 0;
                for (int j = 0; j < vectorNumere.Length; j++)
                {
                    if (vectorNumere[k] == vectorNumere[j])
                    {
                        numerotareNumar++;
                    }
                }
            }

            if (numerotareNumar == 4)
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
        /// <summary>
        /// Tipareste o mana.
        /// </summary>
        public void Tipareste()
        {
            Console.WriteLine("Mana: ");
            foreach (Carte carte in mana)
            {
                carte.Tipareste();
            }
        }
    }
}
