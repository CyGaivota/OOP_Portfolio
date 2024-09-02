namespace Testfile
{
    internal class Program



    {
        public class FormenTests
        {
            public static void TestRechteck()
            {
                // Arrange
                Rechteck rechteck = new Rechteck(4, 5);

                // Act
                double umfang = rechteck.Umfang();
                double fläche = rechteck.Fläche();

                // Ausgabe der Ergebnisse
                Console.WriteLine("Test Rechteck:");
                Console.WriteLine($"Erwarteter Umfang: 18, Berechneter Umfang: {umfang}");
                Console.WriteLine($"Erwartete Fläche: 20, Berechnete Fläche: {fläche}");
                Console.WriteLine();
            }

            public static void TestDreieck()
            {
                // Arrange
                Dreieck dreieck = new Dreieck(3, 4, 5);

                // Act
                double umfang = dreieck.Umfang();
                double fläche = dreieck.Fläche();

                // Ausgabe der Ergebnisse
                Console.WriteLine("Test Dreieck:");
                Console.WriteLine($"Erwarteter Umfang: 12, Berechneter Umfang: {umfang}");
                Console.WriteLine($"Erwartete Fläche: 6, Berechnete Fläche: {fläche}");
                Console.WriteLine();
            }

            public static void TestKreis()
            {
                // Arrange
                Kreis kreis = new Kreis(3);

                // Act
                double umfang = kreis.Umfang();
                double fläche = kreis.Fläche();

                // Ausgabe der Ergebnisse
                Console.WriteLine("Test Kreis:");
                Console.WriteLine($"Erwarteter Umfang: 18.84955592153876, Berechneter Umfang: {umfang}");
                Console.WriteLine($"Erwartete Fläche: 28.274333882308138, Berechnete Fläche: {fläche}");
                Console.WriteLine();
            }

            public static void Main(string[] args)
            {
                // Führe die Tests aus
                TestRechteck();
                TestDreieck();
                TestKreis();
            }
        }
    }

}
