
using Animals1;

class Program
{
    static void Main(string[] args)
    {
        /*  Console.WriteLine("entre le nom d'un griffon");
          string griffinName = Console.ReadLine();
          Console.WriteLine("entre le nom d'un dragon");
          string dragonName = Console.ReadLine();

          Griffin griffin = new Griffin(griffinName);
          Dragon dragon = new Dragon(dragonName);

          dragon.Move();
          dragon.Sleep();
          griffin.Move();
          griffin.Sleep();
  */
        Dragon dragon = new Dragon();
        dragon.Moove();

        Vehicle vehicle = new Vehicle();
        vehicle.Moove();
    }
}