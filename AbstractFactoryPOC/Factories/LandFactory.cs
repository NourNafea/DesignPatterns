using AbstractFactoryPOC.Types;

namespace AbstractFactoryPOC.Factories;

public class LandFactory : AnimalFactory
{
    public override IAnimal GetAnimal(string animalType)
    {
        return animalType switch
        {
            "Dog" => new Dog(),
            "Cat" => new Cat(),
            _ => throw new ArgumentException("Animal type not supported"),
        };
    }
}