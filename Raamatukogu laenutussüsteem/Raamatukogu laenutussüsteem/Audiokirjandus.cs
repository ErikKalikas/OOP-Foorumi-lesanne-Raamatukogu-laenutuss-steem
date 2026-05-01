using System;
using System.Collections.Generic;
using System.Text;

namespace Raamatukogu_laenutussüsteem
{
    class Audiokirjandus : Teavik
    {
        public int KestusMinutites { get; set; }    
        public string Diktor { get; set; }  //имя

        public Audiokirjandus(string pealkiri, string autor, string laenutuseÜldreeglid, int aasta ,int kestus, string diktor)
            : base(pealkiri, autor, laenutuseÜldreeglid, aasta)
        {
            KestusMinutites = kestus;
            Diktor = diktor;
        }

        public override bool OnSaadaval()
        {
            return true;
        }

        public override string GetInfo() => $"Audiokirjandus: {Pealkiri} ({VäljaandmiseAasta})";
    }
}
