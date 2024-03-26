using Animals;

class Program
{
    static void Main(string[] args)
    {


        Animal dinosaure = new Animal("Tricératops");

        string a = dinosaure.Name;

        Console.WriteLine($"The animal's name is {a}.\n");
        Console.WriteLine($"{a} is a big dinosaure\n");
        dinosaure.Moove();
        dinosaure.Sleep();

    }
}