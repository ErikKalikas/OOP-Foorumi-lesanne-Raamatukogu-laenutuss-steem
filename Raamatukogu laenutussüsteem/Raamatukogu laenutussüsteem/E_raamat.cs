using System;
using System.Collections.Generic;
using System.Text;

namespace Raamatukogu_laenutussüsteem
{
    class E_raamat : Teavik
    {
        public string FailiFormaat { get; set; } // Например, "PDF"
        public double FailiSuurusMB { get; set; }

        public E_raamat(string pealkiri, string autor, string laenutuseÜldreeglid, int aasta, string millalTagastada, string formaat, double suurus)
            : base(pealkiri, autor, laenutuseÜldreeglid, aasta, millalTagastada)
        {
            FailiFormaat = formaat;
            FailiSuurusMB = suurus;
        }

        public override bool OnSaadaval()
        {
            return true;
        }

        public override string GetInfo() => $"E-raamat: {Pealkiri} ({VäljaandmiseAasta})";
    }
}
