using myprayertimes.esolat.Endpoint;
using myprayertimes.esolat.Extensions;
using myprayertimes.esolat.Models;

namespace myprayertimes.esolat;

public class EsolatApi : IEsolatApi
{
    private HttpClient? _httpClient;

    public async Task<EsolatResponse?> GetWaktuSolatAsync(Zone zone, Period period, Protocol protocol = Protocol.Https, HttpClient? httpClient = null,
        DateTime? start = null, DateTime? end = null)
    {
        _httpClient = httpClient ?? new HttpClient();
        SetUserAgent();

        var generatedUrl = Constants.BaseUrl(protocol, period, zone);
        string jsonResult;
        
        if (period.Name == Period.Duration.Name)
        {
            if (start == null || end == null)
                throw new ArgumentNullException();
            
            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("datestart", start.Value.ToString(Constants.DurationFormat)),
                new KeyValuePair<string, string>("dateend", end.Value.ToString(Constants.DurationFormat))
            });

            var responseMessage = await _httpClient.PostAsync(generatedUrl, content);
            jsonResult = await responseMessage.Content.ReadAsStringAsync();
        }
        else
            jsonResult = await _httpClient.GetStringAsync(generatedUrl);
        
        return !string.IsNullOrEmpty(jsonResult) ? jsonResult.ToEsolatResponse() : null;
    }

    private void SetUserAgent() => _httpClient?.DefaultRequestHeaders.UserAgent.ParseAdd(Constants.UserAgent);
}