using System;
using System.Collections.Generic;
using System.Text;

namespace Raamatukogu_laenutussüsteem
{
    class Info
    {
        public static void menu1(List<Raamat> Raamatud, List<Õpik> Õpikud, List<Audiokirjandus> Audiokirjandus, List<E_raamat> E_raamatud, List<Ajakiri> Ajakirikud)
        {
            while (true)
            {
                
                try
                {
                    Console.WriteLine("");
                    Console.WriteLine("kuuva tüpp");
                    Console.WriteLine("0 - lõpp");
                    Console.WriteLine("1 - Raamatud");
                    Console.WriteLine("2 - Õpikud");
                    Console.WriteLine("3 - Audiokirjandus");
                    Console.WriteLine("4 - E_raamatud");
                    Console.WriteLine("5 - Ajakirikud");
                    Console.WriteLine("6 - raamatuid, mida pole");
                    Console.WriteLine("");
                    int peamineValik = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("");

                    if (peamineValik == 0)
                    {
                        return;
                    }      
                    else if (peamineValik == 6)
                    {
                        RaamatuidMidaPole(Raamatud, Õpikud, Audiokirjandus, E_raamatud, Ajakirikud);
                    }
                    else
                    {
                        menu3(peamineValik, Raamatud, Õpikud, Audiokirjandus, E_raamatud, Ajakirikud);
                    }

                    
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("kirjutage number");
                    Console.WriteLine("");
                    Console.WriteLine("---------------------------------------------------");
                    continue;
                }
            }

            
            
        }

        public static void menu2(int peamineValik, List<Raamat> Raamatud, List<Õpik> Õpikud, List<Audiokirjandus> Audiokirjandus, List<E_raamat> E_raamatud, List<Ajakiri> Ajakirikud)
        {
           while(true)
           {
                if(peamineValik == 3 || peamineValik == 4)
                {
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("1 - raamat kätte võtta");
                    Console.WriteLine("2 - lõpp");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("1 - raamat kätte võtta");
                    Console.WriteLine("2 - raamat tagastada");
                    Console.WriteLine("3 - lõpp");
                    Console.WriteLine("");
                }             

                if (int.TryParse(Console.ReadLine(), out int a1) && (a1 == 1 || a1 == 2 || a1 == 3))
                {
                    Console.Clear();
                    while (true)
                    {
                        Console.WriteLine("");
                        menu4(a1 ,peamineValik, Raamatud, Õpikud, Audiokirjandus, E_raamatud, Ajakirikud);
                        switch (a1)
                        {
                            case 1:
                                if (peamineValik == 1)
                                {
                                    int ab = Raamatud.Count;
                                    if (int.TryParse(Console.ReadLine(), out int a2) && (a2 <= ab && a2 > 0))
                                    {
                                        a2--;
                                        try
                                        {
                                            Raamatud[a2].GetTeavik();
                                            string a3 = Raamatud[a2].GetInfo1();

                                            Console.Clear();
                                            Console.WriteLine("");
                                            Console.WriteLine("te võtsite: " + a3);
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("\nVIGA: " + ex.Message); // Выведет "матерьяла нету"
                                        }
                                        Console.WriteLine("");
                                        Console.WriteLine("ENTER");
                                        string ba = Console.ReadLine();
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("NB! valige olemasolev number");
                                        Console.WriteLine("");
                                        continue;
                                    }
                                }
                                else if (peamineValik == 2)
                                {
                                    int ab = Õpikud.Count;
                                    if (int.TryParse(Console.ReadLine(), out int a2) && (a2 <= ab && a2 > 0))
                                    {
                                        a2--;
                                        try
                                        {
                                            Õpikud[a2].GetTeavik();
                                            string a3 = Õpikud[a2].GetInfo1();

                                            Console.Clear();
                                            Console.WriteLine("");
                                            Console.WriteLine("te võtsite: " + a3);
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("\nVIGA: " + ex.Message); // Выведет "матерьяла нету"
                                        }
                                        Console.WriteLine("");
                                        Console.WriteLine("ENTER");
                                        string ba = Console.ReadLine();
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("NB! valige olemasolev number");
                                        Console.WriteLine("");
                                        continue;
                                    }
                                }
                                else if (peamineValik == 3)
                                {
                                    int ab = Audiokirjandus.Count;
                                    if (int.TryParse(Console.ReadLine(), out int a2) && (a2 <= ab && a2 > 0))
                                    {
                                        a2--;
                                        try
                                        {
                                            Audiokirjandus[a2].GetTeavik();
                                            string a3 = Audiokirjandus[a2].GetInfo1();

                                            Console.Clear();
                                            Console.WriteLine("");
                                            Console.WriteLine("te võtsite: " + a3);
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("\nVIGA: " + ex.Message); // Выведет "матерьяла нету"
                                        }
                                        Console.WriteLine("");
                                        Console.WriteLine("ENTER");
                                        string ba = Console.ReadLine();
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("NB! valige olemasolev number");
                                        Console.WriteLine("");
                                        continue;
                                    }
                                }
                                else if (peamineValik == 4)
                                {
                                    int ab = E_raamatud.Count;
                                    if (int.TryParse(Console.ReadLine(), out int a2) && (a2 <= ab && a2 > 0))
                                    {
                                        a2--;
                                        try
                                        {
                                            E_raamatud[a2].GetTeavik();
                                            string a3 = E_raamatud[a2].GetInfo1();

                                            Console.Clear();
                                            Console.WriteLine("");
                                            Console.WriteLine("te võtsite: " + a3);
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("\nVIGA: " + ex.Message); // Выведет "матерьяла нету"
                                        }
                                        Console.WriteLine("");
                                        Console.WriteLine("ENTER");
                                        string ba = Console.ReadLine();
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("NB! valige olemasolev number");
                                        Console.WriteLine("");
                                        continue;
                                    }
                                }
                                else if (peamineValik == 5)
                                {
                                    int ab = Ajakirikud.Count;
                                    if (int.TryParse(Console.ReadLine(), out int a2) && (a2 <= ab && a2 > 0))
                                    {
                                        a2--;
                                        try
                                        {
                                            Ajakirikud[a2].GetTeavik();
                                            string a3 = Ajakirikud[a2].GetInfo1();

                                            Console.Clear();
                                            Console.WriteLine("");
                                            Console.WriteLine("te võtsite: " + a3);
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("\nVIGA: " + ex.Message); // Выведет "матерьяла нету"
                                        }
                                        Console.WriteLine("");
                                        Console.WriteLine("ENTER");
                                        string ba = Console.ReadLine();
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("NB! valige olemasolev number");
                                        Console.WriteLine("");
                                        continue;
                                    }
                                }
                                break;
                            case 2:
                                if(peamineValik == 1)
                                {
                                    RaamatuidMidaPole(Raamatud, Õpikud, Audiokirjandus, E_raamatud, Ajakirikud);
                                }
                                if (peamineValik == 2)
                                {
                                    RaamatuidMidaPole(Raamatud, Õpikud, Audiokirjandus, E_raamatud, Ajakirikud);
                                }
                                if (peamineValik == 3)
                                {

                                }
                                else if(peamineValik == 4)
                                {

                                }
                                else if(peamineValik == 5)
                                {
                                    RaamatuidMidaPole(Raamatud, Õpikud, Audiokirjandus, E_raamatud, Ajakirikud);
                                }
                                break;
                            case 3:
                                break;
                        }
                        break;
                    }
                    Console.Clear();
                }
                else if (a1 >= 4 || a1 <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("NB! kirjuta olemasolev variant");
                    Console.WriteLine("");
                    menu3(peamineValik, Raamatud, Õpikud, Audiokirjandus, E_raamatud, Ajakirikud);
                    continue;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("NB! Vigane sisend! Palun sisesta number.");
                    Console.WriteLine("");
                    menu3(peamineValik, Raamatud, Õpikud, Audiokirjandus, E_raamatud, Ajakirikud);
                    continue;
                }
                return;
           }
        }

        public static void menu3(int peamineValik, List<Raamat> Raamatud, List<Õpik> Õpikud, List<Audiokirjandus> Audiokirjandus, List<E_raamat> E_raamatud, List<Ajakiri> Ajakirikud)
        {
            switch (peamineValik)
            {
                case 1:
                    Console.WriteLine("id");
                    Console.WriteLine("---------------------------------------------------");
                    for (int i = 0; i < Raamatud.Count; i++)
                    {
                        Console.WriteLine(i + 1 + " | " + Raamatud[i].GetInfo2());
                    }
                    break;
                case 2:
                    Console.WriteLine("id");
                    Console.WriteLine("---------------------------------------------------");
                    for (int i = 0; i < Õpikud.Count; i++)
                    {
                        Console.WriteLine(i + 1 + " | " + Õpikud[i].GetInfo2());
                    }
                    break;
                case 3:
                    Console.WriteLine("id");
                    Console.WriteLine("---------------------------------------------------");
                    for (int i = 0; i < Audiokirjandus.Count; i++)
                    {
                        Console.WriteLine(i + 1 + " | " + Audiokirjandus[i].GetInfo2());
                    }
                    break;
                case 4:
                    Console.WriteLine("id");
                    Console.WriteLine("---------------------------------------------------");
                    for (int i = 0; i < E_raamatud.Count; i++)
                    {
                        Console.WriteLine(i + 1 + " | " + E_raamatud[i].GetInfo2());
                    }
                    break;
                case 5:
                    Console.WriteLine("id");
                    Console.WriteLine("---------------------------------------------------");
                    for (int i = 0; i < Ajakirikud.Count; i++)
                    {
                        Console.WriteLine(i + 1 + " | " + Ajakirikud[i].GetInfo2());
                    }
                    break;
                default:
                    Console.WriteLine("NB! valige olemasolev partitsioon");
                    Console.WriteLine("");
                    return;
            }
            menu2(peamineValik, Raamatud, Õpikud, Audiokirjandus, E_raamatud, Ajakirikud);
        }

        public static void menu4(int a1 ,int peamineValik, List<Raamat> Raamatud, List<Õpik> Õpikud, List<Audiokirjandus> Audiokirjandus, List<E_raamat> E_raamatud, List<Ajakiri> Ajakirikud)
        {
            switch (peamineValik)
            {
                case 1:
                    Console.WriteLine("id");
                    Console.WriteLine("---------------------------------------------------");
                    for (int i = 0; i < Raamatud.Count; i++)
                    {
                        Console.WriteLine(i + 1 + " | " + Raamatud[i].GetInfo2());
                    }
                    Console.WriteLine("---------------------------------------------------");
                    break;
                case 2:
                    Console.WriteLine("id");
                    Console.WriteLine("---------------------------------------------------");
                    for (int i = 0; i < Õpikud.Count; i++)
                    {
                        Console.WriteLine(i + 1 + " | " + Õpikud[i].GetInfo2());
                    }
                    Console.WriteLine("---------------------------------------------------");
                    break;
                case 3:
                    Console.WriteLine("id");
                    Console.WriteLine("---------------------------------------------------");
                    for (int i = 0; i < Audiokirjandus.Count; i++)
                    {
                        Console.WriteLine(i + 1 + " | " + Audiokirjandus[i].GetInfo2());
                    }
                    Console.WriteLine("---------------------------------------------------");
                    break;
                case 4:
                    Console.WriteLine("id");
                    Console.WriteLine("---------------------------------------------------");
                    for (int i = 0; i < E_raamatud.Count; i++)
                    {
                        Console.WriteLine(i + 1 + " | " + E_raamatud[i].GetInfo2());
                    }
                    Console.WriteLine("---------------------------------------------------");
                    break;
                case 5:
                    Console.WriteLine("id");
                    Console.WriteLine("---------------------------------------------------");
                    for (int i = 0; i < Ajakirikud.Count; i++)
                    {
                        Console.WriteLine(i + 1 + " | " + Ajakirikud[i].GetInfo2());
                    }
                    Console.WriteLine("---------------------------------------------------");
                    break;
                default:
                    Console.WriteLine("valige olemasolev partitsioon");
                    Console.WriteLine("");
                    Console.WriteLine("---------------------------------------------------");
                    break;
            }
            if (a1 == 1)
            {
                Console.WriteLine("valige ese, mida soovite laenata");
                Console.WriteLine("");
            }
        }

        public static void RaamatuidMidaPole(List<Raamat> Raamatud, List<Õpik> Õpikud, List<Audiokirjandus> Audiokirjandus, List<E_raamat> E_raamatud, List<Ajakiri> Ajakirikud)
        {
            List<Teavik> kõik = new List<Teavik>();

            foreach (var item in Raamatud)
            {
                if (!item.saadaval)
                {
                    kõik.Add(item);
                }
            }
            foreach (var item in Õpikud)
            {
                if (!item.saadaval)
                {
                    kõik.Add(item);
                }
            }
            foreach (var item in Ajakirikud)
            {
                if (!item.saadaval)
                {
                    kõik.Add(item);
                }
            }

            foreach (var item in kõik)
            {
                Console.WriteLine(item.GetInfo2());
            }

            if (kõik.Count == 0)
            {
                Console.WriteLine("te ei laenanud raamatuid");
            }
            else
            {
                tagasi(Raamatud, Õpikud, Audiokirjandus, E_raamatud, Ajakirikud);
            }
            Console.WriteLine("");
            Console.WriteLine("ENTER");
            string a = Console.ReadLine();
            Console.Clear();
        }

        public static void tagasi(List<Raamat> Raamatud, List<Õpik> Õpikud, List<Audiokirjandus> Audiokirjandus, List<E_raamat> E_raamatud, List<Ajakiri> Ajakirikud)
        {
                Console.WriteLine("");
                Console.WriteLine("Kas sa tahad, et ma selle tagasi annaksin?");
                Console.WriteLine("1 - Yah");
                Console.WriteLine("2 - Ei");
                Console.WriteLine("");
                if (int.TryParse(Console.ReadLine(), out int a1) && (a1 == 1 || a1 == 2))
                {
                     Console.Clear();
                    if (a1 == 1)
                    {
                        Console.Clear();
                        foreach (var item in Raamatud)
                        {
                            if (!item.saadaval)
                            {
                                item.ReturnTeavik();
                            }
                        }
                        foreach (var item in Õpikud)
                        {
                            if (!item.saadaval)
                            {
                                item.ReturnTeavik();
                            }
                        }
                        foreach (var item in Ajakirikud)
                        {
                            if (!item.saadaval)
                            {
                                item.ReturnTeavik();
                            }
                        }
                    }
                    else
                    {
                        
                    }
                }
                else
                {
                    Console.Clear();
                }


        }
    }
}
