using System;
using System.Collections.Generic;
using System.Text;

namespace Ex._1_Laborator7_
{
    class Carte
    {
        public enum SimbolCarte
        {
            InimaRosie,
            InimaNeagra,
            Romb,
            Trefla
        }
        private SimbolCarte simbol;
        private int numar;

        /// <summary>
        /// Seteaza simbolul cartii.
        /// </summary>
        //public  SimbolCarte { get; set; }
        
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
            return this.simbol;
        }
        /// <summary>
        /// Returneaza numarul unei carti.
        /// </summary>
        /// <returns></returns>
        public int GetNumar()
        {
            return this.numar;
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
