using System;
using System.Collections.Generic;
using System.Text;

namespace Raamatukogu_laenutussüsteem
{
    abstract class Teavik : Liides
    {
        public string Pealkiri { get; set; }             //название
        public string Autor { get; set; }
        public int VäljaandmiseAasta { get; set; }       //год издания
        public string LaenutuseÜldreeglid { get; set; }  //общие правила выдачи
        public bool saadaval { get; set; }               //доступен ли?
        public DateTime? MillalTagastada { get; set; }      //дата возврата
        public string žanr { get; set; }

        public Teavik(string pealkiri, string autor, string laenutuseÜldreeglid, int väljaandmiseAasta)
        {
            saadaval = true;

            Pealkiri = pealkiri;

            Autor = autor;

            VäljaandmiseAasta = väljaandmiseAasta;

            LaenutuseÜldreeglid = laenutuseÜldreeglid;


            // 2.
            if (pealkiri == "")
            {
                //выкидывает с ошибкой
                throw new ArgumentException("Pealkiri ei tohi olla tühi.");
            }

            // 3. Год издания не должен относиться к будущему
            if (väljaandmiseAasta > DateTime.Now.Year)
            {
                throw new ArgumentException("Väljaandmise aasta ei tohi olla tulevikust.");
            }

        }

        public virtual string GetInfo()
        {
            return $"{Pealkiri} - {Autor} ({VäljaandmiseAasta})";
        }

        public virtual DateTime? tähtaeg() //кода вернуть
        {
            return MillalTagastada;
        }

        public virtual bool OnSaadaval()     //проверять, доступен ли продукт
        {
            return saadaval;
        }

        public virtual void GetTeavik()
        {
            if(OnSaadaval())
            {
                saadaval = false;
                MillalTagastada = DateTime.Now.AddDays(30);
            }
            else
            {
                throw new Exception("матерьяла нету");
            }          
        }

        public virtual void ReturnTeavik()
        {
            if (!OnSaadaval())
            {
                saadaval = true;
                MillalTagastada = null;
            }
            else
            {
                throw new Exception("книга в наличии");
            }


        }
    }
}
