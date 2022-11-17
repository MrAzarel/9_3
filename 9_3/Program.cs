using System.Linq;
using System.Reflection.Metadata;

enum ClothingSize
{
    XXS = 32,
    XS = 34,
    S = 36,
    M = 38,
    L = 40
}

public static class Age
{
    public static string SizeToAge(Constant size)
    {
        if (size.Equals(32)||size.Equals(34))
            return "Детский размер";
        else
            return "Взрослый размер";
    }
}

public interface IMansClothing
{
    public void DressAMan()
    {

    }
}

public interface IWomensClothing
{
    public void DressAWoman()
    {

    }
}

abstract class Clothes
{
    int size;
    double price;
    string color;
}

class TShirt : Clothes 
{

}

class Pants : Clothes
{

}

class Tie : Clothes
{

}

class Atelier
{

}

class Program
{
    static void Main(string[] args)
    {
        
    }
}
