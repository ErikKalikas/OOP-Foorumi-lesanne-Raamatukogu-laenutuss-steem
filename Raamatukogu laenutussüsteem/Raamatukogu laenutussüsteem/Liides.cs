using System;
using System.Collections.Generic;
using System.Text;

namespace Raamatukogu_laenutussüsteem
{
    interface Liides
    {
        //Liides määrab, mida iga teavik peab suutma:

         string GetInfo();     //предоставлять информацию о себе

         DateTime? tähtaeg();  //рассчитывать срок возврата

         bool OnSaadaval();   //проверять, доступен ли материал
    }
}
