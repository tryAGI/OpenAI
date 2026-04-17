
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
        public async global::System.Threading.Tasks.Task SendInputAudioBufferAppendAsync(
            global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferAppend message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferAppend), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }


        /// <summary>
        /// Base64-encoded audio bytes. This must be in the format specified by the <br/>
        /// `input_audio_format` field in the session configuration.
        /// </summary>
        /// <param name="audio">The binary payload to send.</param>
        /// <param name="eventId">Optional client-generated ID used to identify this event.</param>
        /// <param name="type">The event type, must be `input_audio_buffer.append`.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public global::System.Threading.Tasks.Task SendInputAudioBufferAppendAsync(
            global::System.ReadOnlyMemory<byte> audio,
            string? eventId = default,
            global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferAppendType type = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            return SendInputAudioBufferAppendAsync(
                new global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferAppend
                {
                Audio = global::System.Convert.ToBase64String(audio.Span),
                EventId = eventId,
                Type = type,
                },
                cancellationToken);
        }
    }
}