using PexelsDotNetSDK.Models;
using PexelsDotNetSDK;
using System.Collections.Generic;
using System.Threading.Tasks;

public class PexelsService
{
    private readonly PexelsClient _pexelsClient;

    public PexelsService(string apiKey)
    {
        _pexelsClient = new PexelsClient(apiKey);
    }

    public async Task<IEnumerable<PexelsPhoto>> GetPhotosAsync(string query)
    {
        var result = await _pexelsClient.SearchPhotosAsync(query);
        return result.Photos;
    }
}
