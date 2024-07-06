
#nullable enable

namespace OpenAI
{
    public partial class AssistantsClient
    {
        /// <summary>
        /// Create a message.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenAI.MessageObject> CreateMessageAsync(
            string threadId,
            global::OpenAI.CreateMessageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.GetLeftPart(global::System.UriPartial.Authority) + $"/threads/{threadId}/messages", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, global::OpenAI.SourceGenerationContext.Default.CreateMessageRequest);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::OpenAI.SourceGenerationContext.Default.MessageObject) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a message.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="role"></param>
        /// <param name="content"></param>
        /// <param name="attachments"></param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenAI.MessageObject> CreateMessageAsync(
            string threadId,
            global::OpenAI.CreateMessageRequestRole role,
            global::System.OneOf<string, global::System.Collections.Generic.IList<global::System.OneOf<global::OpenAI.MessageContentImageFileObject?, global::OpenAI.MessageContentImageUrlObject?, global::OpenAI.MessageRequestContentTextObject?>>> content,
            global::System.Collections.Generic.IList<global::OpenAI.CreateMessageRequestAttachments?>? attachments = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::OpenAI.CreateMessageRequest
            {
                Role = role,
                Content = content,
                Attachments = attachments,
                Metadata = metadata,
            };

            return await CreateMessageAsync(
                threadId: threadId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}