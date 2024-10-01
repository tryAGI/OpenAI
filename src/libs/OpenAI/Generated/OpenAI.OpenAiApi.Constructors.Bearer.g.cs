
#nullable enable

namespace OpenAI
{
    public sealed partial class OpenAiApi
    {
        /// <inheritdoc cref="OpenAiApi(global::System.Net.Http.HttpClient?, global::System.Uri?, global::OpenAI.EndPointAuthorization?)"/>
        public OpenAiApi(
            string apiKey,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::OpenAI.EndPointAuthorization? authorization = null) : this(httpClient, baseUri, authorization)
        {
            Authorizing(_httpClient, ref apiKey);

            AuthorizeUsingBearer(apiKey);

            Authorized(_httpClient);
        }

        partial void Authorizing(
            global::System.Net.Http.HttpClient client,
            ref string apiKey);
        partial void Authorized(
            global::System.Net.Http.HttpClient client);
    }
}