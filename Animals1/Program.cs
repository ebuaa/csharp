using System;
using System.Collections.Generic;
using System.Linq;
using Animals1;

class Program
{
    // Déplacez la déclaration de listeChiens à l'intérieur de Main pour qu'elle puisse être passée comme argument.
    static void Main(string[] args)
    {
        IList<Chien> listeChiens = new List<Chien>()
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
}