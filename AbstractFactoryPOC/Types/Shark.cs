namespace AbstractFactoryPOC.Types;

public class Shark : IAnimal
{
    public string Speak()
    {
        return "Shark says: 'I can't talk, I'm a shark!'";
    }
}