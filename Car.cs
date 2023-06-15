using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternExample_ConsoleApp
{
    public class Car : ICarPrototype
    {
        public int Id { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(150)]
        public string Model { get; set; }
        [StringLength(150)]
        public string Color { get; set; }
        [StringLength(150)]
        public string Brand { get; set; }
        [Range(1950, 5000)]
        public int Year { get; set; }

        public ICarPrototype Clone()
        {
            // Crea una create a new ins
            return new Car
            {
                Id = this.Id,
                Name = this.Name,
                Model = this.Model,
                Color = this.Color,
                Brand = this.Brand,
                Year = this.Year
            };
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine();
        }
    }

}
