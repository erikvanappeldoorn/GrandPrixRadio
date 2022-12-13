using GrandPrixRadio.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GrandPrixRadio.Services;

internal interface IPlaylistService
{
    Task<IEnumerable<PlayItem>> GetHistoryListAsync();
}
