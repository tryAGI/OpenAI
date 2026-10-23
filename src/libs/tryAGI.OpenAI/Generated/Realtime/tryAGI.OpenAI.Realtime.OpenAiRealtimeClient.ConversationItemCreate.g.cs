
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendConversationItemCreateAsync(
            global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemCreate message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemCreate), (JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_234BCC0282E0CDD4.Default));

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}