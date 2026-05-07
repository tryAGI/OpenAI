
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration for translation input and output audio.
    /// </summary>
    public sealed partial class RealtimeTranslationSessionCreateRequestAudio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudioInput? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudioOutput? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationSessionCreateRequestAudio" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranslationSessionCreateRequestAudio(
            global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudioInput? input,
            global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudioOutput? output)
        {
            this.Input = input;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationSessionCreateRequestAudio" /> class.
        /// </summary>
        public RealtimeTranslationSessionCreateRequestAudio()
        {
        }
    }
}