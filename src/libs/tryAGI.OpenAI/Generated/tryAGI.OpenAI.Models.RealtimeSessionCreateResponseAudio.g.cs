
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration for input and output audio for the session.
    /// </summary>
    public sealed partial class RealtimeSessionCreateResponseAudio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInput? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioOutput? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateResponseAudio" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionCreateResponseAudio(
            global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInput? input,
            global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioOutput? output)
        {
            this.Input = input;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateResponseAudio" /> class.
        /// </summary>
        public RealtimeSessionCreateResponseAudio()
        {
        }
    }
}