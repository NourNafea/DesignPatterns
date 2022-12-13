using AbstractFactoryPOC.Types;

namespace AbstractFactoryPOC.Factories;

public class SeeFactory : AnimalFactory
{
    public override IAnimal GetAnimal(string animalType)
    {
        return animalType switch
        {
            "Shark" => new Shark(),
            "Octopus" => new Octopus(),
            _ => throw new ArgumentException("Animal type not supported"),
        };
    }
}