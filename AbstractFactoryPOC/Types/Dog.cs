namespace AbstractFactoryPOC.Types;

public class Dog : IAnimal
{
    public string Speak()
    {
        return "Woof";
    }
}