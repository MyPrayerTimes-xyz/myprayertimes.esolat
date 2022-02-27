using myprayertimes.esolat.Endpoint;

namespace myprayertimes.esolat.Models;

public class EsolatResponse
{
    public string? Status { get; set; }
    
    public DateTime ServerTime { get; set; }
    
    public string? PeriodType { get; set; }
    
    public string? Lang { get; set; }
    
    public ZoneCode Zone { get; set; }
    
    public string? Bearing { get; set; }
    
    public List<PrayerTime>? PrayerTime { get; set; }
}