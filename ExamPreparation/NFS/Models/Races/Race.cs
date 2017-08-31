using System.Collections.Generic;
using System.Security.AccessControl;

public abstract class Race
{
    
    public Race(int length, string route, int prizePool)
    {
        this.Length = length;
        this.Route = route;
        this.PrizePool = prizePool;
        this.Participants = new List<int>();
    }

    protected int Length { get; set; }
    protected string Route { get; set; }
    protected int PrizePool { get; set; }
    protected List<int> Participants { get; set; }
}