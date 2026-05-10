
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Realtime translation session fields that can be updated with `session.update`.
    /// </summary>
    public sealed partial class RealtimeTranslationSessionUpdateRequest
    {
        /// <summary>
        /// Configuration for translation input and output audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudio? Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationSessionUpdateRequest" /> class.
        /// </summary>
        /// <param name="audio">
        /// Configuration for translation input and output audio.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranslationSessionUpdateRequest(
            global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudio? audio)
        {
            this.Audio = audio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationSessionUpdateRequest" /> class.
        /// </summary>
        public RealtimeTranslationSessionUpdateRequest()
        {
        }

    }
}