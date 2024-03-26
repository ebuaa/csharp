using Animals;

class Program
{
    static void Main(string[] args)
    {


        Animal dinosaure = new Animal("Tricératops", 15000000);

        string a = dinosaure.Name;
        int b = dinosaure.Age;

        Console.WriteLine($"The animal's name is {a}.\n");
        Console.WriteLine($"{a} is a big dinosaure\n");
        Console.WriteLine($"{a} is {b} years old\n");
        dinosaure.Moove();
        dinosaure.Sleep();

    }
}