namespace ConsoleApp6
{
    public class Documents
    {
        public string ID { get; set; }
        public string Titre { get; set; }
        public int AnneePublication { get; set; }
        public string Auteurs { get; set; }

        public void AfficherDetails()
        {
            Console.WriteLine($"ID: {ID}, Titre: {Titre}, Année de publication: {AnneePublication}, Auteurs: {Auteurs}");
        }
    }

}