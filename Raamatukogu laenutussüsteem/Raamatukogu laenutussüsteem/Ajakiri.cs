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
                       string millalTagastada, int väljaandeNumber, string sagedus)
            : base(pealkiri, autor, laenutuseÜldreeglid, aasta, millalTagastada)
        {
            VäljaandeNumber = väljaandeNumber;
            Sagedus = sagedus;
        }
    }
}