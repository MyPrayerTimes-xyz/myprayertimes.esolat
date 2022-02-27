using Newtonsoft.Json;

namespace myprayertimes.esolat.Models;

public class PrayerTime
{
    public string? Hijri { get; set; }
    
    public DateTime Date { get; set; }
    
    public string? Day { get; set; }
    
    public DateTime Imsak { get; set; }
    
    [JsonProperty("fajr")]
    public DateTime Subuh { get; set; }
    
    public DateTime Syuruk { get; set; }
    
    [JsonProperty("dhuhr")]
    public DateTime Zohor { get; set; }
    
    [JsonProperty("asr")]
    public DateTime Asar { get; set; }
    
    public DateTime Maghrib { get; set; }
    
    [JsonProperty("isha")]
    public DateTime Isyak { get; set; }
}