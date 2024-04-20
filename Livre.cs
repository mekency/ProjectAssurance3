using System.Reflection.Metadata;

namespace ConsoleApp6
{
    public class Livre : Documents
    {
        public string ISBN { get; set; }
        public string Editeur { get; set; }
        public int NombrePages { get; set; }

        public string LireExtrait()
        {
            return "Ceci est un extrait du livre.";
        }
    }

}