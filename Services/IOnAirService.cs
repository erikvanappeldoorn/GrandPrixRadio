using System.Threading.Tasks;

namespace GrandPrixRadio.Services;

public interface IOnAirService
{ 
    Task<string> NowOnAirAsync();
}
