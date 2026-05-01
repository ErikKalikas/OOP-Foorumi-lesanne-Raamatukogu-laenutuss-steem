using System;
using System.Collections.Generic;
using System.Text;

namespace Raamatukogu_laenutussüsteem
{
    class Õpik : Teavik
    {
        public string Õppeaine { get; set; }
        public int Klass { get; set; }

        public Õpik(string pealkiri, string autor, string laenutuseÜldreeglid, int aasta, string õppeaine, int klass)
            : base(pealkiri, autor, laenutuseÜldreeglid, aasta)
        {
            Õppeaine = õppeaine;
            Klass = klass;
        }
    }
}
