using PrototypePatternExample_ConsoleApp;

var originalCar = new Car
{
    Id = 1,
    Name = "Tesla",
    Model = "Sedan",
    Color = "Blue",
    Brand = "Ford",
    Year = 2023
};

// Clona la instancia original para crear una nueva instancia de Car
var clonedCar = originalCar.Clone() as Car;

// Modifica la propiedad de la instancia clonada
clonedCar.Id = 1000;
clonedCar.Year = 2025;

// Imprime los detalles de ambos carros
Console.WriteLine("Original Car:");
originalCar.PrintDetails();

Console.WriteLine("Cloned Car:");
clonedCar.PrintDetails();