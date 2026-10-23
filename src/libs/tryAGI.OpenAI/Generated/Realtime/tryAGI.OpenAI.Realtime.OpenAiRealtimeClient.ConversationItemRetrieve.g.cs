
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
        public async global::System.Threading.Tasks.Task SendConversationItemRetrieveAsync(
            global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemRetrieve message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, (JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_AB2EF0F87067CA13.Default).Options.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemRetrieve)));

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}