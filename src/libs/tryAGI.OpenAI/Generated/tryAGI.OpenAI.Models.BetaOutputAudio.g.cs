
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An audio output from the model.
    /// </summary>
    public sealed partial class BetaOutputAudio
    {
        /// <summary>
        /// The type of the output audio. Always `output_audio`.
        /// </summary>
        /// <default>"output_audio"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "output_audio";

        /// <summary>
        /// Base64-encoded audio data from the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// The transcript of the audio data from the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOutputAudio" /> class.
        /// </summary>
        /// <param name="data">
        /// Base64-encoded audio data from the model.
        /// </param>
        /// <param name="transcript">
        /// The transcript of the audio data from the model.
        /// </param>
        /// <param name="type">
        /// The type of the output audio. Always `output_audio`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaOutputAudio(
            string data,
            string transcript,
            string type = "output_audio")
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOutputAudio" /> class.
        /// </summary>
        public BetaOutputAudio()
        {
        }

    }
}