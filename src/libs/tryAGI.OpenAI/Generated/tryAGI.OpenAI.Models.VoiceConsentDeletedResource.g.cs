
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoiceConsentDeletedResource
    {
        /// <summary>
        /// The consent recording identifier.<br/>
        /// Example: cons_1234
        /// </summary>
        /// <example>cons_1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"audio.voice_consent"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "audio.voice_consent";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceConsentDeletedResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The consent recording identifier.<br/>
        /// Example: cons_1234
        /// </param>
        /// <param name="deleted"></param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceConsentDeletedResource(
            string id,
            bool deleted,
            string @object = "audio.voice_consent")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceConsentDeletedResource" /> class.
        /// </summary>
        public VoiceConsentDeletedResource()
        {
        }

    }
}