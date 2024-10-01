// See https://aka.ms/new-console-template for more information

Bird sparrow = new Bird();
sparrow.MakeSound();
((IFlyable)sparrow).Fly();


Bird penguin = new Penguin();
penguin.MakeSound();

public class Bird 
{ 
    public virtual void MakeSound()
    {
        Console.WriteLine("Ada suara lah pokoknya");
    }
}

public class Sparrow : Bird, IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Bisa terbang");
    }
}

public class Penguin : Bird 
{
    public override void MakeSound()
    {
        base.MakeSound();
    }
}

public interface IFlyable
{
    void Fly();
}