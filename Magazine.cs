using System.Reflection.Metadata;

namespace ConsoleApp6
{
    public class Magazine : Documents
    {
        public int Numero { get; set; }
        public string Frequence { get; set; }

        public void AfficherSommaire()
        {
            Console.WriteLine($"Numéro: {Numero}, Fréquence: {Frequence}");
        }
    }

}