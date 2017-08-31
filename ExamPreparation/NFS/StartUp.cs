using System;

public class StartUp
{
    private static void Main()
    {
         
        var manager = new CarManager();
        string inputLine = String.Empty;
        while ((inputLine=Console.ReadLine()) != "Cops Are Here")
        {
            var inputTokens = inputLine.Split(' ');
            var command = inputTokens[0];
            var id = int.Parse(inputTokens[1]);
            switch (command)
            {
                case "register":
                {
                    var type = inputTokens[2];
                    
                    manager.Register(id, type, inputTokens[3], inputTokens[4], int.Parse(inputTokens[5]), int.Parse(inputTokens[6]), int.Parse(inputTokens[7]), int.Parse(inputTokens[8]), int.Parse(inputTokens[9]));
                }
                    break;
                case "check":
                {
                    manager.Check(id);
                }
                    break;
                //case "open":
                //{
                //    var raceId = id;
                //    var type = inputTokens[2];
                //    var length = int.Parse(inputTokens[3]);
                //    var rout = inputTokens[4];
                //    var prizePool = int.Parse(inputTokens[5]);
                //        manager.Open(raceId, type, length, rout, prizePool);
                //    }
                //    break;
                //case "participate":
                //{
                //    var carId = id;
                //    var raceId = int.Parse(inputTokens[2]);
                //        manager.Participate(carId, raceId);
                //    }
                //    break;
                //case "start":
                //{
                //    var raceId = id;
                //        manager.Start(raceId);
                //    }
                //    break;
                //case "park":
                //    {
                //        manager.Park(id);
                //    }
                //    break;
                //case "unpark":
                //    {
                //        manager.Unpark(id);
                //    }
                //       break;
                //case "tune":
                //{
                //    var tuneIndex = int.Parse(inputTokens[1]);
                //    var adOn = inputTokens[2];
                //        manager.Tune(tuneIndex, adOn);
                //    }
                //    break;
            }
        }
    }
}

