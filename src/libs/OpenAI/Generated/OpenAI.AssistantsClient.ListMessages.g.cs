
#nullable enable

namespace OpenAI
{
    public partial class AssistantsClient
    {
        partial void PrepareListMessagesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string threadId,
            ref int? limit,
            ref global::OpenAI.ListMessagesOrder? order,
            ref string? after,
            ref string? before,
            ref string? runId);
        partial void PrepareListMessagesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string threadId,
            int? limit,
            global::OpenAI.ListMessagesOrder? order,
            string? after,
            string? before,
            string? runId);
        partial void ProcessListMessagesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListMessagesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Returns a list of messages for a given thread.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "OPENAI_BETA_001")]
        public async global::System.Threading.Tasks.Task<global::OpenAI.ListMessagesResponse> ListMessagesAsync(
            string threadId,
            int? limit = default,
            global::OpenAI.ListMessagesOrder? order = default,
            string? after = default,
            string? before = default,
            string? runId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListMessagesArguments(
                httpClient: HttpClient,
                threadId: ref threadId,
                limit: ref limit,
                order: ref order,
                after: ref after,
                before: ref before,
                runId: ref runId);

            var __pathBuilder = new PathBuilder(
                path: $"/threads/{threadId}/messages",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("order", order?.ToValueString()) 
                .AddOptionalParameter("after", after) 
                .AddOptionalParameter("before", before) 
                .AddOptionalParameter("run_id", runId) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareListMessagesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                threadId: threadId,
                limit: limit,
                order: order,
                after: after,
                before: before,
                runId: runId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListMessagesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessListMessagesResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::OpenAI.ListMessagesResponse.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}