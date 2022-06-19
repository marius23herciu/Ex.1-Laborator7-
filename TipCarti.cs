using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Ex._1_Laborator7_
{
    class TipCarti
    {
        /// <summary>
        /// Seteaza simbolul cartii.
        /// </summary>
        public TipCarti SimbolCarte { get; set; }
    }
    enum SimbolCarte
    {
        InimaRosie,
        InimaNeagra,
        Romb,
        Trefla
    }
}
