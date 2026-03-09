
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Custom voice reference.
    /// </summary>
    public sealed partial class VoiceIdsOrCustomVoiceVariant2
    {
        /// <summary>
        /// The custom voice ID, e.g. `voice_1234`.<br/>
        /// Example: voice_1234
        /// </summary>
        /// <example>voice_1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceIdsOrCustomVoiceVariant2" /> class.
        /// </summary>
        /// <param name="id">
        /// The custom voice ID, e.g. `voice_1234`.<br/>
        /// Example: voice_1234
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceIdsOrCustomVoiceVariant2(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceIdsOrCustomVoiceVariant2" /> class.
        /// </summary>
        public VoiceIdsOrCustomVoiceVariant2()
        {
        }
    }
}