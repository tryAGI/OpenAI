
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
        public async global::System.Threading.Tasks.Task SendInputAudioBufferClearAsync(
            global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferClear message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, (JsonSerializerContextProvider?.Value ?? global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_E3C86B466AF6B60A.Default).Options.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferClear)));

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}