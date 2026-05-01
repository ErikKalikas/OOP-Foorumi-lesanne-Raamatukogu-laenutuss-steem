namespace Raamatukogu_laenutussüsteem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Raamat> raamatud = new List<Raamat>
            {
                new Raamat("Sõda ja rahu", "Lev Tolstoi", "30 päeva", 1869, "Paber"),
                new Raamat("1984", "George Orwell", "30 päeva", 1949, "Paber"),
                new Raamat("Hobbit", "J.R.R. Tolkien", "30 päeva", 1937, "Paber"),
                new Raamat("Alkeemik", "Paulo Coelho", "30 päeva", 1988, "Paber"),
                new Raamat("Dracula", "Bram Stoker", "30 päeva", 1897, "Paber")
            };

            List<Õpik> õpikud = new List<Õpik>
            {
                new Õpik("Matemaatika", "Ivan Ivanov", "14 päeva", 2020, "Matemaatika", 5),
                new Õpik("Eesti keel", "Mari Maasikas", "14 päeva", 2019, "Eesti keel", 6),
                new Õpik("Füüsika", "Jaan Tamm", "14 päeva", 2018, "Füüsika", 7),
                new Õpik("Keemia", "Peeter Saar", "14 päeva", 2021, "Keemia", 8),
                new Õpik("Bioloogia", "Kati Kask", "14 päeva", 2022, "Bioloogia", 9)
            };

            List<Audiokirjandus> audiokirjandus = new List<Audiokirjandus>
            {
                new Audiokirjandus("Harry Potter", "J.K. Rowling", "7 päeva", 2001, 600, "John Smith"),
                new Audiokirjandus("Hobbit", "Tolkien", "7 päeva", 1937, 700, "David Brown"),
                new Audiokirjandus("Düün", "Frank Herbert", "7 päeva", 1965, 900, "Mike Johnson"),
                new Audiokirjandus("Dracula", "Bram Stoker", "7 päeva", 1897, 500, "Chris Lee"),
                new Audiokirjandus("Alkeemik", "Coelho", "7 päeva", 1988, 300, "Anna White")
            };

            List<E_raamat> e_raamatud = new List<E_raamat>
            {
                new E_raamat("Clean Code", "Robert Martin", "10 päeva", 2008, "PDF", 5.2),
                new E_raamat("C# Basics", "Microsoft", "10 päeva", 2021, "EPUB", 3.1),
                new E_raamat("Java Guide", "Oracle", "10 päeva", 2020, "PDF", 4.7),
                new E_raamat("Python 101", "Guido", "10 päeva", 2019, "MOBI", 2.9),
                new E_raamat("Algorithms", "CLRS", "10 päeva", 2009, "PDF", 6.5)
            };

            List<Ajakiri> ajakirjad = new List<Ajakiri>()
            {
                new Ajakiri("National Geographic", "Various", "7 päeva", 2023, 1, "Kuu"),
                new Ajakiri("Time", "Various", "7 päeva", 2023, 2, "Nädal"),
                new Ajakiri("Forbes", "Various", "7 päeva", 2023, 3, "Kuu"),
                new Ajakiri("Science", "Various", "7 päeva", 2023, 4, "Nädal"),
                new Ajakiri("Nature", "Various", "7 päeva", 2023, 5, "Nädal")
            };

            Info.menu1(raamatud, õpikud, audiokirjandus, e_raamatud, ajakirjad);

        }
    }
}
