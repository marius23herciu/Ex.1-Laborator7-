using System;
using System.Collections.Generic;
using System.Text;

namespace Ex._1_Laborator7_
{
    class Carte
    {
        private SimbolCarte simbol;
        private int numar;

        /// <summary>
        /// Creeaza carte.
        /// </summary>
        /// <param name="simbol"></param>
        /// <param name="numar">Introduceti un numar intre 1 si 14.</param>
        public Carte(SimbolCarte simbol, int numar)
        {
            this.simbol = simbol;
            this.numar = numar;
        }
        /// <summary>
        /// Returneaza simbolul unei carti.
        /// </summary>
        /// <returns></returns>
        public SimbolCarte GetSimbol()
        {
            SimbolCarte verificareSimbol = this.simbol;
            return verificareSimbol;
        }
        /// <summary>
        /// Returneaza numarul unei carti.
        /// </summary>
        /// <returns></returns>
        public int GetNumar()
        {
            int numar = this.numar;
            return numar;
        }
        /// <summary>
        /// Tipareste o carte.
        /// </summary>
        public void Tipareste()
        {
            Console.WriteLine($"{simbol} {numar}");
        }
    }
}
