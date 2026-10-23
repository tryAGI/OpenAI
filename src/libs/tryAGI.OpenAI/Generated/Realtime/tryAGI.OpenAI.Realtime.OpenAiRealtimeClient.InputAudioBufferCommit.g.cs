
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
        public async global::System.Threading.Tasks.Task SendInputAudioBufferCommitAsync(
            global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferCommit message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferCommit), (JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_00366DC3090C0C65.Default));

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}