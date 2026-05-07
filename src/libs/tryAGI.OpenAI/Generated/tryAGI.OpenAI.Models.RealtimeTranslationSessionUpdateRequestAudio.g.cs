
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration for translation input and output audio.
    /// </summary>
    public sealed partial class RealtimeTranslationSessionUpdateRequestAudio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudioInput? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudioOutput? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationSessionUpdateRequestAudio" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranslationSessionUpdateRequestAudio(
            global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudioInput? input,
            global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudioOutput? output)
        {
            this.Input = input;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationSessionUpdateRequestAudio" /> class.
        /// </summary>
        public RealtimeTranslationSessionUpdateRequestAudio()
        {
        }
    }
}