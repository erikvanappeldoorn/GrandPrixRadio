using GrandPrixRadio.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GrandPrixRadio.Services;

internal class PlayListService : IPlaylistService
{
    private List<PlayItem> playItems = new List<PlayItem>();
   
    public async Task<IEnumerable<PlayItem>> GetHistoryListAsync()
    {
        const byte showMaxPlayItems = 8;

        using (var client = new HttpClient())
        {
            var result = await client.GetAsync(UriLocator.NowPlayingUri);
            try
            {
                string data = await result.Content.ReadAsStringAsync();
                dynamic json = JsonConvert.DeserializeObject<ExpandoObject>(data);
                
                string playing = json.data.attributes.title;
                if (playing?.Length > 0 && json.data.attributes.artist?.Length > 0)
                    playing += " - ";
                playing += json.data.attributes.artist; 

                string time = DateTime.Now.ToString("HH:mm");
                if (playItems.Count == 0 || playing != playItems[0].Label)
                {
                    if (playing.Length > 3)
                    {
                        playItems.Insert(0, new PlayItem() { Label = playing, Time = time });
                    }
                }
            }
            catch
            {
            }
        }
        return playItems.Take(showMaxPlayItems);
    }
}           
