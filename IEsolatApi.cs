using myprayertimes.esolat.Endpoint;
using myprayertimes.esolat.Models;

namespace myprayertimes.esolat;

public interface IEsolatApi
{
    Task<EsolatResponse?> GetWaktuSolatAsync(Zone zone, Period period, Protocol protocol = Protocol.Https,
        HttpClient? httpClient = null,
        DateTime? start = null, DateTime? end = null);
}