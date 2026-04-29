namespace Raamatukogu_laenutussüsteem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Raamat> raamatud = new List<Raamat>
            {
                new Raamat("Sipsik", "Eno Raud", "Reegel1", 1962, "2026-05-20", "Paber"),
                new Raamat("Kevade", "Oskar Luts", "Reegel1", 1912, "2026-05-20", "Paber"),
                new Raamat("Tõde ja õigus", "A. H. Tammsaare", "Reegel1", 1929, "2026-05-20", "Paber"),
                new Raamat("Arabella", "Aino Pervik", "Reegel1", 1982, "2026-05-20", "Paber"),
                new Raamat("Nukitsamees", "Oskar Luts", "Reegel1", 1920, "2026-05-20", "Paber")
            };

            List<Õpik> õpikud = new List<Õpik>
            {
                new Õpik("Matemaatika", "Autor A", "Reegel2", 2020, "2026-06-01", "Matemaatika", 9),
                new Õpik("Eesti keel", "Autor B", "Reegel2", 2021, "2026-06-01", "Eesti keel", 9),
                new Õpik("Ajalugu", "Autor C", "Reegel2", 2019, "2026-06-01", "Ajalugu", 8),
                new Õpik("Füüsika", "Autor D", "Reegel2", 2022, "2026-06-01", "Füüsika", 10),
                new Õpik("Inglise keel", "Autor E", "Reegel2", 2023, "2026-06-01", "Inglise keel", 7)
            };

            List<Audiokirjandus> audiokirjandus = new List<Audiokirjandus>
            {
                new Audiokirjandus("Harry Potter", "J.K. Rowling", "Reegel3", 2000, "2026-07-01", 600, "Diktor 1"),
                new Audiokirjandus("Hobbit", "J.R.R. Tolkien", "Reegel3", 1937, "2026-07-01", 500, "Diktor 2"),
                new Audiokirjandus("1984", "George Orwell", "Reegel3", 1949, "2026-07-01", 450, "Diktor 3"),
                new Audiokirjandus("Dune", "Frank Herbert", "Reegel3", 1965, "2026-07-01", 800, "Diktor 4"),
                new Audiokirjandus("Foundation", "Isaac Asimov", "Reegel3", 1951, "2026-07-01", 700, "Diktor 5")
            };

            List<E_raamat> e_raamatud = new List<E_raamat>
            {
                new E_raamat("E-book 1", "Autor 1", "Reegel4", 2025, "2026-05-20", "PDF", 2.5),
                new E_raamat("E-book 2", "Autor 2", "Reegel4", 2025, "2026-05-20", "EPUB", 1.2),
                new E_raamat("E-book 3", "Autor 3", "Reegel4", 2024, "2026-05-20", "PDF", 5.0),
                new E_raamat("E-book 4", "Autor 4", "Reegel4", 2024, "2026-05-20", "MOBI", 0.8),
                new E_raamat("E-book 5", "Autor 5", "Reegel4", 2023, "2026-05-20", "PDF", 3.1)
            };

            List<Ajakiri> ajakirjad = new List<Ajakiri>()
            {
                new Ajakiri("Teadusmaailm", "Autor1", "Tavaline reegel", 2020, "2026-01-10", 1, "Kord kuus"),
                new Ajakiri("Mood & Stiil", "Autor2", "Tavaline reegel", 2022, "2026-01-12", 2, "Kord nädalas"),
                new Ajakiri("Sport Weekly", "Autor3", "Tavaline reegel", 2023, "2026-01-15", 3, "Kord nädalas"),
                new Ajakiri("Laste Maailm", "Autor4", "Tavaline reegel", 2021, "2026-01-20", 4, "Kord kuus"),
                new Ajakiri("Uudised Täna", "Autor5", "Tavaline reegel", 2024, "2026-01-25", 5, "Iga päev")
            };

            Info.info(raamatud, õpikud, audiokirjandus, e_raamatud, ajakirjad);

        }
    }
}
