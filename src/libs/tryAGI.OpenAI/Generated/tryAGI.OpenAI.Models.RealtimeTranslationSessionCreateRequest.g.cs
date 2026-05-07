
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Realtime translation session configuration. Translation sessions stream source<br/>
    /// audio in and translated audio plus transcript deltas out continuously.
    /// </summary>
    public sealed partial class RealtimeTranslationSessionCreateRequest
    {
        /// <summary>
        /// The Realtime translation model used for this session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Configuration for translation input and output audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudio? Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationSessionCreateRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The Realtime translation model used for this session.
        /// </param>
        /// <param name="audio">
        /// Configuration for translation input and output audio.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranslationSessionCreateRequest(
            string model,
            global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequestAudio? audio)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Audio = audio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationSessionCreateRequest" /> class.
        /// </summary>
        public RealtimeTranslationSessionCreateRequest()
        {
        }
    }
}