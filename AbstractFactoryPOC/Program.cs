using AbstractFactoryPOC;

var animalFactory = AnimalFactory.CreateAnimalFactory(Console.ReadLine()!);
var result = animalFactory.GetAnimal(Console.ReadLine()!).Speak();
Console.WriteLine(result);