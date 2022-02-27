using System;
using System.Linq;
using myprayertimes.esolat.Endpoint;
using myprayertimes.esolat.Extensions;
using myprayertimes.esolat.Models;
using Newtonsoft.Json;
using Xunit;

namespace myprayertimes.esolat.tests;

public class Tests
{
    [Fact]
    public void TestDeserializeAndDateFix()
    {
        var exampleResponse =
            "{  \"prayerTime\": [    {      \"hijri\": \"1443-07-25\",      \"date\": \"27-Feb-2022\",      \"day\": \"Sunday\",      \"imsak\": \"06:07:00\",      \"fajr\": \"06:17:00\",      \"syuruk\": \"07:24:00\",      \"dhuhr\": \"13:29:00\",      \"asr\": \"16:44:00\",      \"maghrib\": \"19:29:00\",      \"isha\": \"20:38:00\"    },    {      \"hijri\": \"1443-07-26\",      \"date\": \"28-Feb-2022\",      \"day\": \"Monday\",      \"imsak\": \"06:07:00\",      \"fajr\": \"06:17:00\",      \"syuruk\": \"07:23:00\",      \"dhuhr\": \"13:29:00\",      \"asr\": \"16:44:00\",      \"maghrib\": \"19:29:00\",      \"isha\": \"20:38:00\"    },    {      \"hijri\": \"1443-07-27\",      \"date\": \"01-Mar-2022\",      \"day\": \"Tuesday\",      \"imsak\": \"06:07:00\",      \"fajr\": \"06:17:00\",      \"syuruk\": \"07:23:00\",      \"dhuhr\": \"13:28:00\",      \"asr\": \"16:43:00\",      \"maghrib\": \"19:29:00\",      \"isha\": \"20:38:00\"    },    {      \"hijri\": \"1443-07-28\",      \"date\": \"02-Mar-2022\",      \"day\": \"Wednesday\",      \"imsak\": \"06:06:00\",      \"fajr\": \"06:16:00\",      \"syuruk\": \"07:23:00\",      \"dhuhr\": \"13:28:00\",      \"asr\": \"16:43:00\",      \"maghrib\": \"19:29:00\",      \"isha\": \"20:38:00\"    },    {      \"hijri\": \"1443-07-29\",      \"date\": \"03-Mar-2022\",      \"day\": \"Thursday\",      \"imsak\": \"06:06:00\",      \"fajr\": \"06:16:00\",      \"syuruk\": \"07:23:00\",      \"dhuhr\": \"13:28:00\",      \"asr\": \"16:42:00\",      \"maghrib\": \"19:28:00\",      \"isha\": \"20:38:00\"    },    {      \"hijri\": \"1443-08-01\",      \"date\": \"04-Mar-2022\",      \"day\": \"Friday\",      \"imsak\": \"06:06:00\",      \"fajr\": \"06:16:00\",      \"syuruk\": \"07:22:00\",      \"dhuhr\": \"13:28:00\",      \"asr\": \"16:42:00\",      \"maghrib\": \"19:28:00\",      \"isha\": \"20:38:00\"    },    {      \"hijri\": \"1443-08-02\",      \"date\": \"05-Mar-2022\",      \"day\": \"Saturday\",      \"imsak\": \"06:06:00\",      \"fajr\": \"06:16:00\",      \"syuruk\": \"07:22:00\",      \"dhuhr\": \"13:28:00\",      \"asr\": \"16:41:00\",      \"maghrib\": \"19:28:00\",      \"isha\": \"20:37:00\"    },    {      \"hijri\": \"1443-08-03\",      \"date\": \"06-Mar-2022\",      \"day\": \"Sunday\",      \"imsak\": \"06:05:00\",      \"fajr\": \"06:15:00\",      \"syuruk\": \"07:22:00\",      \"dhuhr\": \"13:27:00\",      \"asr\": \"16:40:00\",      \"maghrib\": \"19:28:00\",      \"isha\": \"20:37:00\"    }  ],  \"status\": \"OK!\",  \"serverTime\": \"2022-02-27 19:58:03\",  \"periodType\": \"duration\",  \"lang\": \"ms_my\",  \"zone\": \"WLY01\"}";

        var fixedResponse = exampleResponse.ToEsolatResponse();

        Assert.Equal(2, fixedResponse?.PrayerTime?.First().Zohor.Month);
        Assert.Equal(3, fixedResponse?.PrayerTime?.Last().Zohor.Month);
    }
    
    [Fact]
    public void TestModels()
    {
        var exampleResponse =
            "{\"prayerTime\":[{\"hijri\":\"1443-07-25\",\"date\":\"27-Feb-2022\",\"day\":\"Sunday\",\"imsak\":\"06:07:00\",\"fajr\":\"06:17:00\",\"syuruk\":\"07:24:00\",\"dhuhr\":\"13:29:00\",\"asr\":\"16:44:00\",\"maghrib\":\"19:29:00\",\"isha\":\"20:38:00\"},{\"hijri\":\"1443-07-26\",\"date\":\"28-Feb-2022\",\"day\":\"Monday\",\"imsak\":\"06:07:00\",\"fajr\":\"06:17:00\",\"syuruk\":\"07:23:00\",\"dhuhr\":\"13:29:00\",\"asr\":\"16:44:00\",\"maghrib\":\"19:29:00\",\"isha\":\"20:38:00\"},{\"hijri\":\"1443-07-27\",\"date\":\"01-Mar-2022\",\"day\":\"Tuesday\",\"imsak\":\"06:07:00\",\"fajr\":\"06:17:00\",\"syuruk\":\"07:23:00\",\"dhuhr\":\"13:28:00\",\"asr\":\"16:43:00\",\"maghrib\":\"19:29:00\",\"isha\":\"20:38:00\"},{\"hijri\":\"1443-07-28\",\"date\":\"02-Mar-2022\",\"day\":\"Wednesday\",\"imsak\":\"06:06:00\",\"fajr\":\"06:16:00\",\"syuruk\":\"07:23:00\",\"dhuhr\":\"13:28:00\",\"asr\":\"16:43:00\",\"maghrib\":\"19:29:00\",\"isha\":\"20:38:00\"},{\"hijri\":\"1443-07-29\",\"date\":\"03-Mar-2022\",\"day\":\"Thursday\",\"imsak\":\"06:06:00\",\"fajr\":\"06:16:00\",\"syuruk\":\"07:23:00\",\"dhuhr\":\"13:28:00\",\"asr\":\"16:42:00\",\"maghrib\":\"19:28:00\",\"isha\":\"20:38:00\"},{\"hijri\":\"1443-08-01\",\"date\":\"04-Mar-2022\",\"day\":\"Friday\",\"imsak\":\"06:06:00\",\"fajr\":\"06:16:00\",\"syuruk\":\"07:22:00\",\"dhuhr\":\"13:28:00\",\"asr\":\"16:42:00\",\"maghrib\":\"19:28:00\",\"isha\":\"20:38:00\"},{\"hijri\":\"1443-08-02\",\"date\":\"05-Mar-2022\",\"day\":\"Saturday\",\"imsak\":\"06:06:00\",\"fajr\":\"06:16:00\",\"syuruk\":\"07:22:00\",\"dhuhr\":\"13:28:00\",\"asr\":\"16:41:00\",\"maghrib\":\"19:28:00\",\"isha\":\"20:37:00\"},{\"hijri\":\"1443-08-03\",\"date\":\"06-Mar-2022\",\"day\":\"Sunday\",\"imsak\":\"06:05:00\",\"fajr\":\"06:15:00\",\"syuruk\":\"07:22:00\",\"dhuhr\":\"13:27:00\",\"asr\":\"16:40:00\",\"maghrib\":\"19:28:00\",\"isha\":\"20:37:00\"}],\"status\":\"OK!\",\"serverTime\":\"2022-02-27 19:29:48\",\"periodType\":\"week\",\"lang\":\"ms_my\",\"zone\":\"WLY01\",\"bearing\":\"292&#176; 31&#8242; 16&#8243;\"}";

        var response = JsonConvert.DeserializeObject<EsolatResponse>(exampleResponse);

        var first = response?.PrayerTime?.First();
        Assert.Equal("1443-07-25", first?.Hijri);
        Assert.NotEqual(new DateTime(), first?.Imsak);
        Assert.NotEqual(new DateTime(), first?.Subuh);
        Assert.NotEqual(new DateTime(), first?.Syuruk);
        Assert.NotEqual(new DateTime(), first?.Zohor);
        Assert.NotEqual(new DateTime(), first?.Asar);
        Assert.NotEqual(new DateTime(), first?.Maghrib);
        Assert.NotEqual(new DateTime(), first?.Isyak);
    }

    [Fact]
    public void TestBaseUrl()
    {
        var expectedUrl = "https://www.e-solat.gov.my/index.php?r=esolatApi/takwimsolat&period=today&zone=WLY01";
        var generatedUrl = Constants.BaseUrl(Protocol.Https, Period.Daily, Constants.Zones[ZoneCode.WLY01]);
        Assert.Equal(expectedUrl, generatedUrl);
    }
}