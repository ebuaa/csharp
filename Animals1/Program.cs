using System;
using System.Collections.Generic;
using System.Linq;
using Animals1;
using System.Data.SqlClient;
class Program
{
    static void Main(string[] args)
    {
        string connectionString = "Server=LAPTOP-MEVMBK22\\MSSQLSERVER02;Database=Animals;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();

/*        string query = "INSERT INTO Animals(Id, name, type, rarity) VALUES (5, 'Tristana', 'Singe', 'Commun')";
*/        string query = "SELECT * FROM Animals";
          SqlCommand command = new SqlCommand(query, connection);
/*        int rowsAffected = command.ExecuteNonQuery();
*/        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine(reader["Id"].ToString() + " | " + reader["name"].ToString() + " | " + reader["type"].ToString() + " | " + reader["rarity"].ToString() + " | ");
        }



        Console.WriteLine("Quel est le type de l'animal ?");
        string type = Console.ReadLine();
        Console.WriteLine("Quel est le nom de l'animal ?");
        string name = Console.ReadLine();
        Console.WriteLine("Quel est la rareté de l'animal ?");
        string rarity = Console.ReadLine();
        reader.Close();
        Animal animal = null;
        switch (type.ToLower())
        {
            case "dragon":
                animal = new Dragon(name, rarity);
                break;
            case "griffin":
                animal = new Griffin(name, rarity);
                break;
            case "bird":
                animal = new Bird(name, rarity);
                break;
            case "eagle":
                animal = new Eagle(name, rarity);
                break;
            default:
                Console.WriteLine("Type d'animal inconnu, aucun animal instancié.");
                break;
        }
        if (animal != null)
        {
            animal.display();
            animal.move();
            animal.sleep();
        }

        if (animal is IFly)
        {
            Console.WriteLine("Cet animal peut voler");
        }
        else
        {
            Console.WriteLine("Cet animal ne peut pas voler");
        }
        query = "INSERT INTO espece (name, rarity,type) VALUES ('" + name + "', '" + rarity + "', '" + type + "')";
        SqlCommand cmd2 = new SqlCommand(query, connection);
        int rowsAffected = cmd2.ExecuteNonQuery();
        Console.WriteLine(rowsAffected + " ligne(s) ajoutée(s) à la base de données");


        reader.Close();
       connection.Close();










        /*IList<Chien> listeChiens = new List<Chien>()
        {
            new Chien() {ID = 1, Name="Snow", Rarity = "Rare"},
            new Chien() {ID = 2, Name="Ice", Rarity = "Commun"},
            new Chien() {ID = 3, Name="Sun", Rarity = "Rare"},
            new Chien() {ID = 4, Name="Sand", Rarity = "Commun"},
            new Chien() {ID = 5, Name="Cloud", Rarity = "Rare"},
        };

        RareDogs(listeChiens);
        CommunDogs(listeChiens);

    }

    // Cette méthode reste statique et prend maintenant un paramètre IList<Chien>
    public static void RareDogs(IEnumerable<Chien> listeChiens)
    {
        Console.WriteLine("Rare dogs :\n");

        var dogRarity = listeChiens.Where(s => s.Rarity == "Rare").ToList();
        foreach (var dog in dogRarity)
        {
            Console.WriteLine($"ID : {dog.ID} | Name : {dog.Name}");
        }
        Console.WriteLine("__________________________________________________\n");

    }


    public static void CommunDogs(IEnumerable<Chien> listeChiens)
    {
        Console.WriteLine("Commun dogs :\n");

        var communDogs = from dog in listeChiens
                         where dog.Rarity == "Commun"
                         orderby dog.ID descending
                         select dog;

        foreach (var dog in communDogs)
        {
            Console.WriteLine($"ID : {dog.ID} | Name : {dog.Name}");
        }
    }


/*Bird bird = new Bird();
Eagle eagle = new Eagle();

bird.Fly();
eagle.Fly();*/


    }
}