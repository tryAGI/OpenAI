using System.Linq;

#nullable enable

namespace OpenAI
{
    public partial class AssistantsClient
    {
        partial void PrepareListRunStepsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string threadId,
            ref string runId,
            ref int limit,
            ref global::OpenAI.ListRunStepsOrder? order,
            ref string? after,
            ref string? before,
            global::System.Collections.Generic.IList<global::OpenAI.ListRunStepsIncludeItem>? include);
        partial void PrepareListRunStepsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string threadId,
            string runId,
            int limit,
            global::OpenAI.ListRunStepsOrder? order,
            string? after,
            string? before,
            global::System.Collections.Generic.IList<global::OpenAI.ListRunStepsIncludeItem>? include);
        partial void ProcessListRunStepsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListRunStepsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Returns a list of run steps belonging to a run.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="runId"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="include"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenAI.ListRunStepsResponse> ListRunStepsAsync(
            string threadId,
            string runId,
            int limit = 20,
            global::OpenAI.ListRunStepsOrder? order = global::OpenAI.ListRunStepsOrder.Desc,
            string? after = default,
            string? before = default,
            global::System.Collections.Generic.IList<global::OpenAI.ListRunStepsIncludeItem>? include = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListRunStepsArguments(
                httpClient: _httpClient,
                threadId: ref threadId,
                runId: ref runId,
                limit: ref limit,
                order: ref order,
                after: ref after,
                before: ref before,
                include: include);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/threads/{threadId}/runs/{runId}/steps?limit={limit}&order={(global::System.Uri.EscapeDataString(order?.ToValueString() ?? string.Empty))}&after={after}&before={before}&{string.Join("&", include?.Select(static x => $"include={x}") ?? global::System.Array.Empty<string>())}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListRunStepsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                threadId: threadId,
                runId: runId,
                limit: limit,
                order: order,
                after: after,
                before: before,
                include: include);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListRunStepsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListRunStepsResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::OpenAI.ListRunStepsResponse), JsonSerializerContext) as global::OpenAI.ListRunStepsResponse ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}