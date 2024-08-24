
#nullable enable

namespace OpenAI
{
    public sealed partial class OpenAiApi
    {
        /// <inheritdoc cref="OpenAiApi(global::System.Net.Http.HttpClient?, global::System.Uri?)"/>
        public OpenAiApi(
            string apiKey,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null) : this(httpClient, baseUri)
        {
            AuthorizeUsingBearer(apiKey);
        }
    }
}