namespace DomainModels
{

    public abstract class Vehicle : IVehicle
    {

        public int Year { get; set; }
        public string? Color { get; set; }
        public int HoursePower { get; set; }
        public int NumberOfCylinders { get; set; }
        public string? Fueltype { get; set; }

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

    class Car : Vehicle
    { 
    public Car(string? brand, string? model, int year, string? color, int hoursePower)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
            HoursePower = hoursePower;
            NumberOfCylinders = NumberOfCylinders;
       
        }}


}
