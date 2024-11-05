using ConsoleAppEFRelations.Model;

namespace ConsoleAppEFRelations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string connectionString = "Data Source=NB21-6CDPYD3\\SQLEXPRESS;Initial Catalog=GeoDB;Integrated Security=True;TrustServerCertificate=True";


            GeoWikiContext db = new(connectionString);
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
        }
    }
}
