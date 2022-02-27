using myprayertimes.esolat.Models;
using Newtonsoft.Json;

namespace myprayertimes.esolat.Extensions;

public static class EsolatApiExtensions
{
    public static EsolatResponse? ToEsolatResponse(this string response)
    {
        if (string.IsNullOrEmpty(response))
            return new EsolatResponse();
        
        var esolatResponse = JsonConvert.DeserializeObject<EsolatResponse>(response);

        if (esolatResponse == null)
            return new EsolatResponse();
        
        var fixedDate = esolatResponse?.PrayerTime?.Select(e =>
        {
            e.Imsak = FixDateTime(e.Date, e.Imsak);
            e.Subuh = FixDateTime(e.Date, e.Subuh);
            e.Syuruk = FixDateTime(e.Date, e.Syuruk);
            e.Zohor = FixDateTime(e.Date, e.Zohor);
            e.Asar = FixDateTime(e.Date, e.Asar);
            e.Maghrib = FixDateTime(e.Date, e.Maghrib);
            e.Isyak = FixDateTime(e.Date, e.Isyak);
            return e;
        }).ToList();
        
        if (esolatResponse != null)
            esolatResponse.PrayerTime = fixedDate;
        
        return esolatResponse ?? default;
    }

    private static DateTime FixDateTime(DateTime current, DateTime prayer)
    {
        return new DateTime(current.Year, current.Month, current.Day, prayer.Hour, prayer.Minute,
            prayer.Second);
    }
}