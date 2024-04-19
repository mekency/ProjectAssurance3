using ConsoleApp6;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        // Créez des instances de chaque classe et testez les méthodes
     
        Livre livre = new Livre
        {
            ID = "L123",
            Titre = "Harry Potter",
            AnneePublication = 2001,
            Auteurs = "J.K. Rowling",
            ISBN = "978-1234567890",
            Editeur = "Poudlard Press",
            NombrePages = 300
        };

        Magazine magazine = new Magazine
        {
            ID = "M456",
            Titre = "National Geographic",
            AnneePublication = 2022,
            Auteurs = "Divers auteurs",
            Numero = 123,
            Frequence = "Mensuel"
        };

        Journal journal = new Journal
        {
            ID = "J789",
            Titre = "Le Monde",
            AnneePublication = 2026,
            Auteurs = "Journalistes",
            DateParution = DateTime.Now
        };

        Utilisateur utilisateur = new Utilisateur
        {
            ID = 1,
            Nom = "Mohammed",
            Prenom = "Mekency",
            Email = "mohammed@example.com",
            Adresse = "123 Rue des Livres",
            Telephone = 123456789
        };

        // Affichez les détails des documents
        livre.AfficherDetails();
        magazine.AfficherDetails();
        journal.AfficherDetails();

        // Testez les méthodes spécifiques
        Console.WriteLine(livre.LireExtrait());
        magazine.AfficherSommaire();
        Console.WriteLine(journal.LireArticlePrincipal());

        // Testez les méthodes d'emprunt et de retour
        utilisateur.EmprunterDocument(livre);
        utilisateur.RetournerDocument(livre);
    }
    
}
