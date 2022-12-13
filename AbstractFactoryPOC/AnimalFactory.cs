using AbstractFactoryPOC.Factories;

namespace AbstractFactoryPOC;

public abstract class AnimalFactory
{
    public abstract IAnimal GetAnimal(string animalType);
    
    public static AnimalFactory CreateAnimalFactory(string factoryType)
    {
        return factoryType switch
        {
            "See" => new SeeFactory(),
            "Land" => new LandFactory(),
            _ => throw new ArgumentException("Invalid factory type")
        };
    }
}