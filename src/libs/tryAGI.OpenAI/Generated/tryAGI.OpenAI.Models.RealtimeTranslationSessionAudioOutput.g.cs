
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeTranslationSessionAudioOutput
    {
        /// <summary>
        /// Target language for translated output audio and transcript deltas.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationSessionAudioOutput" /> class.
        /// </summary>
        /// <param name="language">
        /// Target language for translated output audio and transcript deltas.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranslationSessionAudioOutput(
            string? language)
        {
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationSessionAudioOutput" /> class.
        /// </summary>
        public RealtimeTranslationSessionAudioOutput()
        {
        }

    }
}