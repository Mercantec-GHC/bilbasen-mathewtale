using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Runtime.ConstrainedExecution;
using DomainModels;
namespace Bilbasen

{
    internal class Program
    {
        static void Main(string[] args)
        {



            List<Car> vehicles = new List<Car>
            {
                new Car("Ford", "Mustang", 2021, "Red", 450, 8, "$50,000"),
                new Car("Chevrolet", "Camaro", 2021, "Blue", 450, 8, "$52,000"),
                new Car("Toyota", "Supra", 2022, "Red", 335, 6, "$45,000"),
                new Car("Nissan", "GT-R", 2022, "Black", 565, 6, "$115,000"),
                new Car("Honda", "Civic", 2020, "White", 180, 4, "$25,000"),
                new Car("Tesla", "Model S", 2022, "Gray", 1020, 0, "$100,000"),
                new Car("BMW", "M3", 2021, "Blue", 473, 6, "$70,000"),
                new Car("Audi", "A4", 2020, "Silver", 248, 4, "$40,000"),
                new Car("Mercedes", "C-Class", 2021, "Black", 255, 4, "$42,000"),
                new Car("Volkswagen", "Golf", 2021, "Red", 170, 4, "$28,000"),
                new Car("Kia", "Stinger", 2021, "Green", 368, 6, "$38,000"),
                new Car("Subaru", "WRX", 2021, "Blue", 271, 4, "$30,000"),
                new Car("Mazda", "MX-5 Miata", 2021, "Red", 181, 4, "$35,000"),
                new Car("Porsche", "911", 2021, "Yellow", 443, 6, "$110,000"),
                new Car("Jaguar", "F-Type", 2021, "Black", 444, 8, "$70,000"),
                new Car("Chevrolet", "Corvette", 2021, "Silver", 495, 8, "$60,000"),
                new Car("Ford", "F-150", 2021, "Red", 400, 6, "$30,000"),
                new Car("GMC", "Sierra", 2021, "Blue", 355, 6, "$45,000"),
                new Car("Ram", "1500", 2021, "White", 395, 8, "$40,000"),
                new Car("Toyota", "RAV4", 2021, "Green", 203, 4, "$28,000"),
                new Car("Honda", "CR-V", 2021, "Red", 190, 4, "$28,500"),
                new Car("Hyundai", "Tucson", 2021, "Silver", 181, 4, "$26,000"),
                new Car("Nissan", "Rogue", 2021, "Blue", 201, 4, "$27,000"),
                new Car("Volkswagen", "Tiguan", 2021, "White", 184, 4, "$26,500"),
                new Car("Kia", "Sportage", 2021, "Black", 187, 4, "$25,000"),
                new Car("Chevrolet", "Equinox", 2021, "Gray", 170, 4, "$25,000"),
                new Car("Ford", "Explorer", 2021, "Red", 300, 6, "$32,000"),
                new Car("Toyota", "Highlander", 2021, "Blue", 295, 6, "$40,000"),
                new Car("Honda", "Pilot", 2021, "Silver", 280, 6, "$37,000"),
                new Car("Subaru", "Ascent", 2021, "Green", 260, 4, "$33,000"),
                new Car("Mazda", "CX-5", 2021, "Red", 250, 4, "$28,000"),
                new Car("Nissan", "Pathfinder", 2021, "Black", 284, 6, "$35,000"),
                new Car("Jeep", "Grand Cherokee", 2021, "White", 295, 6, "$38,000"),
                new Car("Chrysler", "Pacifica", 2021, "Blue", 287, 6, "$34,000"),
                new Car("Dodge", "Durango", 2021, "Gray", 360, 8, "$39,000"),
                new Car("Volkswagen", "Atlas", 2021, "Silver", 276, 6, "$33,000"),
                new Car("Hyundai", "Santa Fe", 2021, "Red", 191, 4, "$28,500"),
                new Car("Kia", "Telluride", 2021, "Black", 291, 6, "$42,000"),
                new Car("Ford", "Escape", 2021, "Green", 200, 4, "$26,000"),
                new Car("Chevrolet", "Trailblazer", 2021, "Blue", 155, 4, "$23,000"),
                new Car("Toyota", "Venza", 2021, "Red", 219, 4, "$32,000"),
                new Car("Nissan", "Rogue Sport", 2021, "White", 141, 4, "$25,500"),
                new Car("Subaru", "Forester", 2021, "Blue", 182, 4, "$28,000"),
                new Car("Honda", "HR-V", 2021, "Black", 141, 4, "$25,000"),
                new Car("Mazda", "CX-30", 2021, "Silver", 186, 4, "$26,500"),
                new Car("Hyundai", "Kona", 2021, "Green", 175, 4, "$24,000"),
                new Car("Kia", "Seltos", 2021, "Red", 175, 4, "$23,000"),
                new Car("Ford", "Maverick", 2022, "Gray", 250, 4, "$20,000"),
                new Car("Chevrolet", "Silverado", 2022, "Blue", 420, 8, "$45,000"),
                new Car("Ram", "2500", 2022, "White", 400, 8, "$50,000"),
                new Car("Toyota", "Tacoma", 2022, "Black", 278, 6, "$30,000"),
                new Car("Honda", "Ridgeline", 2022, "Red", 280, 6, "$36,000"),
                new Car("Nissan", "Titan", 2022, "Silver", 400, 8, "$39,000"),
                new Car("GMC", "Canyon", 2022, "Blue", 275, 6, "$31,000"),
                new Car("Jeep", "Wrangler", 2022, "Green", 285, 6, "$40,000"),
                new Car("Ford", "Bronco", 2022, "Red", 310, 6, "$35,000"),
                new Car("Chevrolet", "Tahoe", 2022, "Black", 355, 8, "$55,000"),
                new Car("Toyota", "Land Cruiser", 2022, "White", 400, 8, "$85,000"),
                new Car("Subaru", "Crosstrek", 2022, "Blue", 152, 4, "$24,000"),
                new Car("Mazda", "CX-50", 2022, "Red", 200, 4, "$28,000"),
                new Car("Hyundai", "Palisade", 2022, "Gray", 291, 6, "$38,000"),
                new Car("Kia", "Carnival", 2022, "Silver", 290, 6, "$32,000"),
                new Car("Honda", "Odyssey", 2022, "Blue", 280, 6, "$39,000"),
                new Car("Volkswagen", "ID.4", 2022, "Green", 201, 0, "$45,000"),
                new Car("Tesla", "Model Y", 2022, "Red", 480, 0, "$60,000"),
                new Car("Porsche", "Macan", 2022, "Silver", 265, 4, "$55,000"),
                new Car("Jaguar", "E-Pace", 2022, "Black", 246, 4, "$44,000"),
                new Car("Mercedes", "GLC", 2022, "Blue", 255, 4, "$53,000"),
                new Car("BMW", "X3", 2022, "Gray", 248, 6, "$54,000"),
                new Car("Volvo", "XC60", 2022, "Red", 250, 4, "$52,000"),
                new Car("Lexus", "RX", 2022, "White", 295, 6, "$57,000"),
                new Car("Acura", "RDX", 2022, "Green", 272, 4, "$42,000"),
                new Car("Infiniti", "QX50", 2022, "Blue", 268, 4, "$45,000"),
                new Car("Genesis", "GV70", 2022, "Black", 300, 6, "$60,000"),
                new Car("Alfa Romeo", "Stelvio", 2022, "Silver", 280, 4, "$48,000"),
                new Car("Fiat", "500", 2022, "Red", 135, 4, "$20,000")
            };


            if (vehicles.Count > 0)
            {
                var firstvehicles = vehicles[0];
                int vehiclescount = 0;
                foreach (var vehicle in vehicles)
                {

                    if (vehicle.Brand == firstvehicles.Brand)
                    {
                        int vehiclespool = vehiclescount++;
                        Console.WriteLine($" \n {vehicle.Brand} {vehicle.Model} {vehicle.Year} \n {vehicle.Price}  \n {vehicle.Color} \n {vehicle.NumberOfCylinders} \n {vehicle.HorsePower} HP");
                        Console.WriteLine("______________________________________________________________________");

                    }
                    else { }
                    

                }
                Console.WriteLine("");
                Console.WriteLine(vehiclescount );
                Console.WriteLine("");
                foreach (var vehicle in vehicles)
                    if (vehicle.Color == "Red")
                    {
                        Console.WriteLine($"{vehicle.Year} {vehicle.Brand} {vehicle.Model} - {vehicle.Color} - {vehicle.HorsePower} HP");
                        Console.WriteLine("______________________________________________________________________");


                    }

            }
            Console.WriteLine();
            foreach (var vehicle in vehicles)
            {

                if (vehicle.HorsePower > 200)
                {
                    Console.WriteLine($"{vehicle.Year} {vehicle.Brand} {vehicle.Model} - {vehicle.Color} - {vehicle.HorsePower} HP");
                    Console.WriteLine("______________________________________________________________________");

                }
            }
            Console.WriteLine();
            foreach (var vehicle in vehicles)
            {
                if(vehicle.Year >= 1980 && vehicle.Year <= 1999)
                {
                    Console.WriteLine($"{vehicle.Year} {vehicle.Brand} {vehicle.Model} - {vehicle.Color} - {vehicle.HorsePower}");
                    Console.WriteLine("______________________________________________________________________");
                }
                    }
            Console.WriteLine();
            foreach(var vehicle in vehicles)
            {

                string? vehiclesInput;
                vehiclesInput = Console.ReadLine();

                if(!string.IsNullOrEmpty(vehiclesInput) && vehiclesInput.Equals(vehicle.Brand, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{vehicle.Brand} {vehicle.Color}");
                    continue;
                }
                else { }
            }
        }

    }
}
