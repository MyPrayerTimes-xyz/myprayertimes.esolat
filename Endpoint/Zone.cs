namespace myprayertimes.esolat.Endpoint;

public class Zone
{
    public ZoneCode Code { get; set; }
    public string Name { get; set; }

    public Zone(ZoneCode code, string name)
    {
        Code = code;
        Name = name;
    }
}