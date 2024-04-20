
using System.Reflection.Metadata;

namespace ConsoleApp6
{
    public class Journal : Documents
    {
        public DateTime DateParution { get; set; }

        public string LireArticlePrincipal()
        {
            return "Ceci est l'article principal du journal.";
        }
    }

}