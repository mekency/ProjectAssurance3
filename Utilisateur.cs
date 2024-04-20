using System.Reflection.Metadata;

namespace ConsoleApp6
{
    public class Utilisateur
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public int Telephone { get; set; }

        public void EmprunterDocument(Documents doc)
        {
            // Logique pour emprunter un document
        }

        public void RetournerDocument(Documents doc)
        {
            // Logique pour retourner un document
        }
    }

}