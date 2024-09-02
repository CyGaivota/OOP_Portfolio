namespace OOP_Portfolio
{
    
    public class Program
    {

        public static void Main()
        {


            // Instanziieren von zwei Rechtecken, einem Dreieck und zwei Kreisen
            Rechteck rechteck1 = new Rechteck(4, 5);
            Rechteck rechteck2 = new Rechteck(3, 6);
            Dreieck dreieck1 = new Dreieck(3, 4, 5);
            Kreis kreis1 = new Kreis(2);
            Kreis kreis2 = new Kreis(3);

            // Formenbehälter mit den instanziierten Formen
            FormenBehälter behälter = new FormenBehälter(
                new List<Rechteck> { rechteck1, rechteck2 },
                new List<Dreieck> { dreieck1 },
                new List<Kreis> { kreis1, kreis2 }
            );

            // Berechnungen ausgeben
            Console.WriteLine($"Gesamter Umfang: {behälter.GesamterUmfang()}");
            Console.WriteLine($"Gesamte Fläche: {behälter.GesamteFläche()}");
        }
    }
}

