using System;
using System.Collections.Generic;
using System.Text;

namespace Raamatukogu_laenutussüsteem
{
    class Ajakiri : Teavik
    {


        public int VäljaandeNumber { get; set; }    // НомерВыпуска 
        public string Sagedus { get; set; }     //Периодичность

        public Ajakiri(string pealkiri, string autor, string laenutuseÜldreeglid, int aasta,
                        int väljaandeNumber, string sagedus)
            : base(pealkiri, autor, laenutuseÜldreeglid, aasta)
        {
            VäljaandeNumber = väljaandeNumber;
            Sagedus = sagedus;
        }
    }
}