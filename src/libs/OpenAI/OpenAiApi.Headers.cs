using System.Net.Http;

namespace OpenAI;

public partial class OpenAiApi
{
    partial void Initialized(HttpClient client)
    {
        _httpClient.DefaultRequestHeaders.Add("OpenAI-Beta", "assistants=v2");
    }
}