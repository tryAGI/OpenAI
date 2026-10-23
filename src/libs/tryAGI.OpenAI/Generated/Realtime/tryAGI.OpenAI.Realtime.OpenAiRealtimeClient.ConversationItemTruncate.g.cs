
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
        public async global::System.Threading.Tasks.Task SendConversationItemTruncateAsync(
            global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemTruncate message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, (JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_23AE4C92A0F58CE9.Default).Options.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemTruncate)));

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}