
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration for audio input and output.
    /// </summary>
    public sealed partial class RealtimeResponseCreateParamsAudio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::tryAGI.OpenAI.RealtimeResponseCreateParamsAudioOutput? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseCreateParamsAudio" /> class.
        /// </summary>
        /// <param name="output"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeResponseCreateParamsAudio(
            global::tryAGI.OpenAI.RealtimeResponseCreateParamsAudioOutput? output)
        {
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseCreateParamsAudio" /> class.
        /// </summary>
        public RealtimeResponseCreateParamsAudio()
        {
        }
    }
}