using System;

namespace Bilbasen

{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List<Vehicles> vehicles = new List<Vehicles>


            List<Vehicles> vehicles = new List<Vehicles>
            {
                new Vehicles("Ford", "Mustang", 1963, "Red", 430),
                new Vehicles("Toyota", "Camry", 2020, "Blue", 200),
                new Vehicles("Chevrolet", "Corvette", 2022, "Silver", 650),
                new Vehicles("Honda", "Civic", 2018, "Black", 150),
                new Vehicles("Nissan", "Altima", 2019, "White", 180),
                new Vehicles("BMW", "3 Series", 2021, "Gray", 250),
                new Vehicles("Audi", "A4", 2020, "Blue", 220),
                new Vehicles("Volkswagen", "Passat", 2017, "Red", 170),
                new Vehicles("Hyundai", "Elantra", 2022, "Silver", 150),
                new Vehicles("Chevrolet", "Malibu", 2016, "Black", 160),
                new Vehicles("Ford", "Focus", 2015, "White", 140),
                new Vehicles("Toyota", "RAV4", 2021, "Green", 200),
                new Vehicles("Honda", "Accord", 2020, "Blue", 190),
                new Vehicles("Nissan", "Rogue", 2021, "Red", 180),
                new Vehicles("BMW", "X5", 2018, "Black", 300),
                new Vehicles("Audi", "Q5", 2020, "Silver", 250),
                new Vehicles("Chevrolet", "Equinox", 2021, "Gray", 170),
                new Vehicles("Toyota", "Highlander", 2019, "White", 220),
                new Vehicles("Ford", "Escape", 2022, "Blue", 200),
                new Vehicles("Hyundai", "Tucson", 2020, "Green", 180),
                new Vehicles("Kia", "Sportage", 2021, "Red", 190),
                new Vehicles("Subaru", "Forester", 2019, "Black", 180),
                new Vehicles("Mazda", "CX-5", 2020, "Silver", 220),
                new Vehicles("Volkswagen", "Jetta", 2021, "Blue", 170),
                new Vehicles("Toyota", "Sienna", 2022, "White", 250),
                new Vehicles("Honda", "Pilot", 2020, "Red", 200),
                new Vehicles("Chevrolet", "Tahoe", 2021, "Gray", 320),
                new Vehicles("Nissan", "Pathfinder", 2019, "Green", 240),
                new Vehicles("Ford", "F-150", 2020, "Black", 400),
                new Vehicles("GMC", "Sierra", 2021, "Silver", 350),
                new Vehicles("Ram", "1500", 2018, "Blue", 400),
                new Vehicles("Honda", "Fit", 2020, "White", 130),
                new Vehicles("Toyota", "Camry Hybrid", 2022, "Red", 150),
                new Vehicles("Hyundai", "Kona", 2021, "Black", 175),
                new Vehicles("Kia", "Soul", 2020, "Green", 145),
                new Vehicles("Subaru", "Crosstrek", 2019, "Silver", 150),
                new Vehicles("Mazda", "CX-30", 2021, "Blue", 200),
                new Vehicles("Volkswagen", "Golf", 2020, "Red", 170),
                new Vehicles("Chevrolet", "Blazer", 2021, "White", 260),
                new Vehicles("Ford", "Bronco", 2022, "Gray", 300),
                new Vehicles("Toyota", "Land Cruiser", 2021, "Black", 400),
                new Vehicles("Nissan", "Armada", 2020, "Silver", 390),
                new Vehicles("BMW", "X3", 2021, "Blue", 250),
                new Vehicles("Audi", "Q7", 2020, "Red", 333),
                new Vehicles("Mercedes", "GLC", 2021, "White", 255),
                new Vehicles("Jaguar", "F-Pace", 2020, "Green", 300),
                new Vehicles("Lexus", "RX", 2021, "Black", 295),
                new Vehicles("Volvo", "XC60", 2020, "Silver", 250),
                new Vehicles("Porsche", "Macan", 2021, "Blue", 265),
                new Vehicles("Mitsubishi", "Outlander", 2020, "Red", 150),
                new Vehicles("Chrysler", "Pacifica", 2021, "White", 287),
                new Vehicles("Buick", "Enclave", 2019, "Gray", 310),
                new Vehicles("Honda", "Clarity", 2020, "Green", 150),
                new Vehicles("Ford", "Fusion", 2020, "Blue", 175),
                new Vehicles("Chevrolet", "Impala", 2020, "Black", 250),
                new Vehicles("Toyota", "Avalon", 2020, "Red", 301),
                new Vehicles("Kia", "K900", 2019, "Silver", 420),
                new Vehicles("Nissan", "370Z", 2021, "Blue", 332),
                new Vehicles("Mazda", "MX-5 Miata", 2020, "White", 181),
                new Vehicles("Subaru", "BRZ", 2022, "Red", 228),
                new Vehicles("Dodge", "Challenger", 2020, "Black", 375),
                new Vehicles("Chevrolet", "Camaro", 2019, "Silver", 455),
                new Vehicles("Ford", "GT", 2021, "Blue", 660),
                new Vehicles("Porsche", "911", 2020, "Red", 443),
                new Vehicles("Jaguar", "F-Type", 2021, "White", 444),
                new Vehicles("Tesla", "Model S", 2022, "Black", 1020),
                new Vehicles("Toyota", "Supra", 2021, "Gray", 335),
                new Vehicles("Nissan", "GT-R", 2022, "Red", 565),
                new Vehicles("Mitsubishi", "Eclipse", 2020, "Blue", 250),
                new Vehicles("Volkswagen", "Beetle", 2019, "Yellow", 174),
                new Vehicles("Hyundai", "Veloster", 2020, "Orange", 275),
                new Vehicles("Honda", "S2000", 2020, "White", 240),
                new Vehicles("Subaru", "WRX", 2021, "Blue", 271),
                new Vehicles("Mazda", "Speed3", 2018, "Red", 263),
                new Vehicles("Ford", "Maverick", 2022, "Gray", 250),
                new Vehicles("Chevrolet", "Silverado", 2021, "Black", 420),
                new Vehicles("Ram", "2500", 2020, "White", 400),
                new Vehicles("Toyota", "Tundra", 2021, "Red", 381),
                new Vehicles("GMC", "Canyon", 2019, "Silver", 275),
                new Vehicles("Nissan", "Titan", 2020, "Blue", 400),
                new Vehicles("Ford", "Expedition", 2021, "Gray", 400),
                new Vehicles("Chevrolet", "Tahoe", 2022, "Black", 355),
                new Vehicles("Honda", "CR-V", 2021, "White", 190),
                new Vehicles("Hyundai", "Santa Fe", 2022, "Red", 227),
                new Vehicles("Kia", "Telluride", 2021, "Silver", 291),
                new Vehicles("Subaru", "Ascent", 2022, "Blue", 260),
                new Vehicles("Mazda", "CX-9", 2021, "Black", 250),
                new Vehicles("Volkswagen", "Atlas", 2021, "White", 276),
                new Vehicles("Toyota", "Venza", 2021, "Gray", 219),
                new Vehicles("Chevrolet", "Trailblazer", 2022, "Red", 155),
                new Vehicles("Ford", "Explorer", 2022, "Blue", 300),
                new Vehicles("Honda", "HR-V", 2022, "Black", 141),
                new Vehicles("Hyundai", "Venue", 2022, "Green", 121),
                new Vehicles("Kia", "Seltos", 2021, "Silver", 175),
                new Vehicles("Subaru", "Outback", 2021, "Red", 182),
                new Vehicles("Mazda", "CX-30", 2021, "White", 186),
                new Vehicles("Volkswagen", "ID.4", 2022, "Blue", 201),
                new Vehicles("Ford", "F-250", 2021, "Gray", 400),
                new Vehicles("Ram", "3500", 2021, "Silver", 420)
            };
            if (vehicles.Count > 0)
            {
                var firstCar = vehicles[0];

                foreach (var vehicle in vehicles)
                {

                    if (vehicle.Brand == firstCar.Brand)
                    {
                        Console.WriteLine($"{vehicle.Year} {vehicle.Brand} {vehicle.Model} - {vehicle.Color} - {vehicle.Horsepower} HP");
                        Console.WriteLine("______________________________________________________________________");

                    }
                    else { }


                }
                foreach (var vehicle in vehicles)
                    if (vehicle.Color == "Red")
                    {
                        Console.WriteLine($"{vehicle.Year} {vehicle.Brand} {vehicle.Model} - {vehicle.Color} - {vehicle.Horsepower} HP");
                        Console.WriteLine("______________________________________________________________________");


                    }

            }
            foreach (var vehicle in vehicles)
            {

                if (vehicle.Horsepower > 200)
                {
                    Console.WriteLine($"{vehicle.Year} {vehicle.Brand} {vehicle.Model} - {vehicle.Color} - {vehicle.Horsepower} HP");
                    Console.WriteLine("______________________________________________________________________");

                }
            }
        }
        public class Vehicles
        {
            public string? Brand { get; set; }
            public string? Model { get; set; }
            public int Year { get; set; }
            public string? Color { get; set; }
            public int Horsepower { get; set; }

            public Vehicles(string? brand, string? model, int year, string? color, int horsepower)
            {
                Brand = brand;
                Model = model;
                Year = year;
                Color = color;
                Horsepower = horsepower;
            }
        }
    }
}
