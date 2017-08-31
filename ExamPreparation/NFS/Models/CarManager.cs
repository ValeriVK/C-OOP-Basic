using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class CarManager
{
    public CarManager()
    {
        //this.CarIds = new List<int>();
        //this.RaceId = new List<int>();
        this.Cars = new Dictionary<int, Car>();
        this.Races = new Dictionary<int, Race>();
        //this.ParkedCars = new List<int>();
        //this.Participatients = new Dictionary<int, List<int>>();
        this.Garage = new Garage();
    }

    //private List<int> CarIds { get; set; }
    //private List<int> RaceId { get; set; }
    private Dictionary<int, Car> Cars { get; set; }
    private Dictionary<int, Race> Races { get; set; }
    //private Dictionary<int, List<int>> Participatients { get; set; }
    //private List<int> ParkedCars { get; set; }
    private Garage Garage { get; set; }

    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        //CarIds.Add(id);
        if (type == "Performance")
        {
            Car car = new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
            Cars.Add(id, car);
        }
        else
        {
            Car car = new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
            Cars.Add(id, car);
        }

    }

    public void Check(int id)
    {
        Console.WriteLine($"{Cars[id]}");
    }

    //public void Open(int id, string type, int length, string route, int prizePool)
    //{
    //    this.RaceId.Add(id);
    //    switch (type)
    //    {
    //        case "Casual":
    //            {
    //                var race = new CasualRace(length, route, prizePool);
    //                Races.Add(id, race);
    //            }
    //            break;
    //        case "Drag":
    //            {
    //                var race = new DragRace(length, route, prizePool);
    //                Races.Add(id, race);
    //            }
    //            break;
    //        case "Drift":
    //            {
    //                var race = new DriftRace(length, route, prizePool);
    //                Races.Add(id, race);
    //            }
    //            break;
    //    }
    //}

    //public void Participate(int carId, int raceId)
    //{
        
    //    if (!this.Participatients.ContainsKey(raceId))
    //    {
    //        this.Participatients.Add(raceId, new List<int>());
    //    }
    //    this.Participatients[raceId].Add(carId);
    //}

    //public string Start(int raceId)
    //{
    //    if (this.Participatients[raceId].Count == 0)
    //    {
    //        Console.WriteLine("Cannot start the race with zero participants.");
    //    }


    //    return "";
    //}

    //public void Park(int id)
    //{
    //    this.ParkedCars.Add(id);
    //}

    //public void Unpark(int id)
    //{
    //    if (this.ParkedCars.Contains(id))
    //    {
    //        this.ParkedCars.Remove(id);
    //    }

    //}

    //public void Tune(int tuneIndex, string addOn)
    //{
    //    foreach (var carIndex in ParkedCars)
    //    {
    //        if (Cars.ContainsKey(carIndex))
    //        {
    //            Cars[carIndex].HorsePower *= tuneIndex;
    //            Cars[carIndex].Suspension *= tuneIndex * 50 / 100;

    //        }
    //    }
    //}
}