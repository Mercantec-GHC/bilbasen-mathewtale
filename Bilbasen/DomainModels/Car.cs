using System.Linq;
namespace DomainModels
{


    public abstract class Vehicle : IVehicle
    {

        public int Year { get; set; }
        public string? Color { get; set; }
        public int HorsePower { get; set; }
        public int NumberOfCylinders { get; set; }
        //public string? Fueltype { get; set; }

        public string? Brand { get; set; }
        public string? Model { get; set; }

        public string? Price { get; set; }

    }

    public interface IVehicle
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? Price { get; set; }
    }

    public class Car : Vehicle
    { 
    public Car(string? brand, string? model, int year, string? color, int horsePower, int numberOfCylinders, string? price)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
            HorsePower = horsePower;
            NumberOfCylinders = numberOfCylinders;
            //Fueltype = Fueltype;
            Price = price;

       
        }
        //public static List<Car> GetCarByColor(string? color)
        //{
        //    if (string.IsNullOrEmpty(color))
        //        return new List<Car>(); // Returner en tom liste, hvis farven er null eller tom

        //    // Filtrer biler baseret på farven
        //    return Car.Where(car => car.Color?.Equals(color, StringComparison.OrdinalIgnoreCase) == true).ToList();
        //}


    }


}
