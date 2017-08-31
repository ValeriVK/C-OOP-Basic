using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var vehicleInfo = Console.ReadLine().Split(' ');
            var vehicleType = vehicleInfo[0];
            Vehicle car = new Car(double.Parse(vehicleInfo[1]), double.Parse(vehicleInfo[2]), double.Parse(vehicleInfo[3]));
            vehicleInfo = Console.ReadLine().Split(' ');
            vehicleType = vehicleInfo[0];
            Vehicle truck = new Truck(double.Parse(vehicleInfo[1]), double.Parse(vehicleInfo[2]), double.Parse(vehicleInfo[3]));
            vehicleInfo = Console.ReadLine().Split(' ');
            vehicleType = vehicleInfo[0];
            Vehicle bus = new Bus(double.Parse(vehicleInfo[1]), double.Parse(vehicleInfo[2]), double.Parse(vehicleInfo[3]));

            var commandsNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandsNumber; i++)
            {
                var commandTokens = Console.ReadLine().Split(' ');
                var vType = commandTokens[1];
                try
                {
                    switch (vType)
                    {
                        case "Car":
                            { ExecuteAction(car, commandTokens[0], double.Parse(commandTokens[2])); }
                            break;
                        case "Truck":
                            { ExecuteAction(truck, commandTokens[0], double.Parse(commandTokens[2])); }
                            break;
                        case "Bus":
                            { ExecuteAction(bus, commandTokens[0], double.Parse(commandTokens[2])); }
                            break;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        private static void ExecuteAction(Vehicle vehicle, string command, double param)
        {
            switch (command)
            {
                case "Drive":
                   var result = vehicle.TryTravelDistance(param);
                    Console.WriteLine(result);
                    break;
                case "DriveEmpty":
                     result = vehicle.TryTravelDistance(param, false);
                    Console.WriteLine(result);
                    break;
                case "Refuel":
                    vehicle.Refuel(param);
                    break;
            }
        }
    }
}
