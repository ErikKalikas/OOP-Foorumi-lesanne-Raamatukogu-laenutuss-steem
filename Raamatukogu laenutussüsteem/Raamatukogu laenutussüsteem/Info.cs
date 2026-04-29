using System;
using System.Collections.Generic;
using System.Text;

namespace Raamatukogu_laenutussüsteem
{
    class Info
    {
        public static void info(List<Raamat> Raamatud, List<Õpik> Õpikud, List<Audiokirjandus> Audiokirjandus, List<E_raamat> E_raamatud, List<Ajakiri> Ajakirikud)
        {
            while (true)
            {
                
                try
                {
                    Console.WriteLine("kuuva tüpp");
                    Console.WriteLine("1 - Raamatud");
                    Console.WriteLine("2 - Õpikud");
                    Console.WriteLine("3 - Audiokirjandus");
                    Console.WriteLine("4 - E_raamatud");
                    Console.WriteLine("5 - Ajakirikud");
                    Console.WriteLine("");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    switch (a)
                    {
                        case 1:
                            foreach (var raamat in Raamatud)
                            {
                                Console.WriteLine(raamat.GetInfo());
                            }
                            break;
                        case 2:
                            foreach (var raamat in Õpikud)
                            {
                                Console.WriteLine(raamat.GetInfo());
                            }
                            break;
                        case 3:
                            foreach (var raamat in Audiokirjandus)
                            {
                                Console.WriteLine(raamat.GetInfo());
                            }
                            break;
                        case 4:
                            foreach (var raamat in E_raamatud)
                            {
                                Console.WriteLine(raamat.GetInfo());
                            }
                            break;
                        case 5:
                            foreach (var raamat in Ajakirikud)
                            {
                                Console.WriteLine(raamat.GetInfo());    
                            }
                            break;
                    }
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    continue;
                }
            }

            
        }
    }
}
