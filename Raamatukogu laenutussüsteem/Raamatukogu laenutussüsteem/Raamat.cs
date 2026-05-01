using System;
using System.Collections.Generic;
using System.Text;

namespace Raamatukogu_laenutussüsteem
{
    class Raamat : Teavik
    {
        public string RaamatuMaterjal { get; set; }

        // Передаем все нужные параметры в базовый класс Teavik через : base(...)
        public Raamat(string pealkiri, string autor, string laenutuseÜldreeglid, int aasta, string materjal)
            : base(pealkiri, autor, laenutuseÜldreeglid, aasta)
        {
            RaamatuMaterjal = materjal;
        }
    }
}
