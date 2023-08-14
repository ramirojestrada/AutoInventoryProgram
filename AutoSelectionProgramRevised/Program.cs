using AutoSelectionProgramRevised;
using System;

namespace MyApp 
{
    internal class AutoSelectionProgramRevised
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ESTRADA MOTORSPORTS - INVENTORY PORTAL");
            Console.ResetColor();

            List<SUVs> suvs = new List<SUVs>();
            List<Trucks> trucks = new List<Trucks>();
            List<Cars> cars = new List<Cars>();



            while (true)
            {
                Console.WriteLine("1. Add new Car:");
                Console.WriteLine("2. Add new SUV:");
                Console.WriteLine("3. Add new Truck:");
                Console.WriteLine("4. List Cars:");
                Console.WriteLine("5. List SUVs:");
                Console.WriteLine("6. List Trucks:");
                Console.WriteLine("7. Exit portal");
                Console.Write("Please select your option:");
                int userChoice = int.Parse(Console.ReadLine());

                
                switch (userChoice)
                {
                    case 1:
                        Console.Write("Enter new Car make: ");
                        string makeOfCar = Console.ReadLine();
                        Console.Write("Enter new Car model: ");
                        string modelOfCar = Console.ReadLine();
                        Console.Write("Enter year of Car model: ");
                        int yearOfCar = int.Parse(Console.ReadLine());
                        Console.Write("Enter the current mileage of Car: ");
                        int milesOfCar = int.Parse((string) Console.ReadLine());

                        cars.Add(new Cars { CarMake = makeOfCar, CarModel = modelOfCar, CarYear = yearOfCar, CarMiles = milesOfCar });
                        Console.WriteLine("Car added to inventory!");
                        break;


                    case 2:
                        Console.Write("Enter new SUV make: ");
                        string makeOfSuv = Console.ReadLine();
                        Console.Write("Enter new SUV model: ");
                        string modelOfSuv = Console.ReadLine();
                        Console.Write("Enter the year of the SUV model: ");
                        int yearOfSuv = int.Parse((string) Console.ReadLine());
                        Console.Write("Enter the current mileage of the SUV: ");
                        int milesOfSuv = int.Parse((string) Console.ReadLine());

                        suvs.Add(new SUVs { SuvMake = makeOfSuv, SuvModel = modelOfSuv, SuvYear = yearOfSuv, SuvMiles = milesOfSuv });
                        Console.WriteLine("SUV added to inventory!");
                        break;

                    
                    case 3:
                        Console.Write("Enter new Truck make: ");
                        string makeOfTruck = Console.ReadLine();
                        Console.Write("Enter new Truck model: ");
                        string modelOfTruck = Console.ReadLine();
                        Console.Write("Enter the year of the Truck model: ");
                        int yearOfTruck = int.Parse((string)Console.ReadLine());
                        Console.Write("Enter the current mileage of the Truck: ");
                        int milesOfTruck = int.Parse((string)Console.ReadLine());

                        trucks.Add(new Trucks { TruckMake = makeOfTruck, TruckModel = modelOfTruck, TruckYear = yearOfTruck, TruckMiles = milesOfTruck });
                        Console.WriteLine("Truck added to inventory!");
                        break;

                    
                    case 4:
                        Console.WriteLine("Car Inventory List: ");
                        foreach(var car in cars)
                        {
                            Console.WriteLine($"Car Make: {car.CarMake}, Car Model: {car.CarModel}, Car Year: {car.CarYear}, Car Mileage: {car.CarMiles}");
                        }
                        break;

                    
                    case 5:
                        Console.WriteLine("Truck Inventory List: ");
                        foreach (var truck in trucks)
                        {
                            Console.WriteLine($"Car Make: {truck.TruckMake}, Car Model: {truck.TruckModel}, Car Year: {truck.TruckYear}, Car Mileage: {truck.TruckMiles}");
                        }
                        break;


                    case 6:
                        Console.WriteLine("SUV Inventory List: ");
                        foreach (var suv in suvs)
                        {
                            Console.WriteLine($"SUV Make: {suv.SuvMake}, SUV Model: {suv.SuvModel}, SUV Year: {suv.SuvYear}, SUV Mileage: {suv.SuvMiles}");
                        }
                        break;


                    case 7:
                        Console.WriteLine("EXIT: Press any button to exit and close the window");
                        break;
                }
                Console.WriteLine();
            }


        }
    }
}