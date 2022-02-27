namespace myprayertimes.esolat.Endpoint;

public class Period
{
    public string Name { get; set; }

    private Period(string name)
    {
        Name = name;
    }
    
    public static Period Year => new Period("year");
    public static Period Monthly => new Period("month");
    public static Period Weekly => new Period("week");
    public static Period Daily => new Period("today");
    public static Period Duration => new Period("duration");
}