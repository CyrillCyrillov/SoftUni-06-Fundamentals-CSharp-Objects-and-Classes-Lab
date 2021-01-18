using System;
using System.Collections.Generic;
using System.Linq;

namespace Task07_Vehicle_Catalogue
{
    class Truck
    {
        public Truck(string brand, string model, string weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
        
        public string Brand { set; get; }
        public string Model { set; get; }
        public string Weight { set; get; }

        public override string ToString()
        {
            return $"{Brand}: {Model} - {Weight}kg";
        }
    }

    class Car
    {   
        public Car(string brand, string model, string horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Brand { set; get; }
        public string Model { set; get; }
        public string HorsePower { set; get; }

        public override string ToString()
        {
            return $"{Brand}: {Model} - {HorsePower}hp";
        }
    }

    class Catalog
    {
        List<Car> CarsInCatalog { get; set; }
        List<Truck> TrucksInCatalog { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carsInCatalog = new List<Car>();
            List<Truck> trucksInCatalog = new List<Truck>();

            while (true)
            {
                string[] vehicleData = Console.ReadLine().Split('/', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (vehicleData[0].ToUpper() == "END")
                {
                    break;
                }
                
                if(vehicleData[0].ToUpper() == "CAR") // {type}/{brand}/{model}/{horse power / weight}
                {
                    Car nextCar = new Car(vehicleData[1], vehicleData[2], vehicleData[3]);
                    carsInCatalog.Add(nextCar);
                }

                if (vehicleData[0].ToUpper() == "TRUCK")
                {
                    Truck nextTruck = new Truck(vehicleData[1], vehicleData[2], vehicleData[3]);
                    trucksInCatalog.Add(nextTruck);
                }
            }

            carsInCatalog =  carsInCatalog.OrderBy(x => x.Brand).ToList();
            trucksInCatalog = trucksInCatalog.OrderBy(x => x.Brand).ToList();

            if(carsInCatalog.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car item in carsInCatalog)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            
            //Console.WriteLine(string.Join((char)13, carsInCatalog.ToString()));

            if(trucksInCatalog.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck item in trucksInCatalog)
                {
                    Console.WriteLine(item.ToString());
                }
            }

            
            
            

            //Console.WriteLine(string.Join((char)13, trucksInCatalog.ToString()));
            
        }
    }
}
