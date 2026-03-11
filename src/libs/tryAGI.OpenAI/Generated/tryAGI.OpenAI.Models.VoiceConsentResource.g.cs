
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A consent recording used to authorize creation of a custom voice.
    /// </summary>
    public sealed partial class VoiceConsentResource
    {
        /// <summary>
        /// The object type, which is always `audio.voice_consent`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VoiceConsentResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.VoiceConsentResourceObject Object { get; set; }

        /// <summary>
        /// The consent recording identifier.<br/>
        /// Example: cons_1234
        /// </summary>
        /// <example>cons_1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The label provided when the consent recording was uploaded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The BCP 47 language tag for the consent phrase (for example, `en-US`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Language { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the consent recording was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceConsentResource" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type, which is always `audio.voice_consent`.
        /// </param>
        /// <param name="id">
        /// The consent recording identifier.<br/>
        /// Example: cons_1234
        /// </param>
        /// <param name="name">
        /// The label provided when the consent recording was uploaded.
        /// </param>
        /// <param name="language">
        /// The BCP 47 language tag for the consent phrase (for example, `en-US`).
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the consent recording was created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceConsentResource(
            string id,
            string name,
            string language,
            global::System.DateTimeOffset createdAt,
            global::tryAGI.OpenAI.VoiceConsentResourceObject @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.CreatedAt = createdAt;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceConsentResource" /> class.
        /// </summary>
        public VoiceConsentResource()
        {
        }
    }
}