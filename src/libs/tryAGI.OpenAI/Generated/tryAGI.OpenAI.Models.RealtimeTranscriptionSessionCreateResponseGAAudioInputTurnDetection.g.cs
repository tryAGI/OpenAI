
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration for turn detection. For `gpt-realtime-whisper`, this must be `null`; VAD is not supported.
    /// </summary>
    public sealed partial class RealtimeTranscriptionSessionCreateResponseGAAudioInputTurnDetection
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}