using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GrandPrixRadio;

internal class PlsToUriConverter
{
    internal async Task<string> ConvertAsync(string plsUri)
    {
        string result = String.Empty;

        try
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetStringAsync(plsUri);

                var stringSeparators = new string[] { "\r\n" };
                string searchPrefix = "File1";
                var lines = response.Split(stringSeparators, StringSplitOptions.None);

                result = lines.First(l => l.StartsWith(searchPrefix))
                              .Substring(searchPrefix.Length + 1);

                return result;
            }
        }
        catch
        {

        }
        return result;
    }
}
