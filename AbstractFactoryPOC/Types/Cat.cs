namespace AbstractFactoryPOC.Types;

public class Cat : IAnimal
{
    public string Speak()
    {
        return "Meow";
    }
}