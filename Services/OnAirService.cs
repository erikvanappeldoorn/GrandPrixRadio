using Newtonsoft.Json;
using System;
using System.Dynamic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace GrandPrixRadio.Services;

public class OnAirService : IOnAirService
{
    public async Task<string> NowOnAirAsync()
    {
        string result = String.Empty;
        string djname = "";

        try
        {
            using var client = new HttpClient();
            var response = await client.GetAsync(UriLocator.NowOnAirUri);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string data = await response.Content.ReadAsStringAsync();
                dynamic json = JsonConvert.DeserializeObject<ExpandoObject>(data);

                djname = json.included[0].attributes.full_name;
                DateTime start_time = json.data.attributes.start_at;
                DateTime end_time = json.data.attributes.end_at;

                if (djname?.Length > 0)
                    result = $"On Air: {djname} {start_time.ToString("HH:mm")} - {end_time.ToString("HH:mm")}";
            }
        }
        catch 
        {
            if (djname?.Length > 0)
                result = $"On Air: {djname}";  
        }
        
        return result;
    }
}
