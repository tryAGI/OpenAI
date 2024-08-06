using System.Net.Http;

namespace OpenAI;

public partial class OpenAiApi
{
    /// <inheritdoc cref="OpenAiApi(HttpClient?, Uri?)"/>
    public OpenAiApi(
        string apiKey, 
        HttpClient? httpClient = null,
        Uri? baseUri = null) : this(httpClient, baseUri)
    {
        AuthorizeUsingBearer(apiKey);
    }
}