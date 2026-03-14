
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration for audio output.
    /// </summary>
    public sealed partial class RealtimeResponseAudio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::tryAGI.OpenAI.RealtimeResponseAudioOutput? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseAudio" /> class.
        /// </summary>
        /// <param name="output"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeResponseAudio(
            global::tryAGI.OpenAI.RealtimeResponseAudioOutput? output)
        {
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseAudio" /> class.
        /// </summary>
        public RealtimeResponseAudio()
        {
        }
    }
}