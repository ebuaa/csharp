public class Griffin : Animal
{
    Griffin()
    {
        Name = "Random griffin";
    }
    public Griffin(string name)
    {
        Name = name;
    }
    public override void Move()
    {
        Console.WriteLine("*flap flap, bruits de "+this.Name+" le griffin qui bouge*");
    }
    public override void Sleep()
    {
        Console.WriteLine("*"+ this.Name + " le griffin dort fort et ronfle sa race*");
    }
}
