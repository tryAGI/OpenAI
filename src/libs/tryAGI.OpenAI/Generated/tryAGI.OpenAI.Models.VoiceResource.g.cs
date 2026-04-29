
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A custom voice that can be used for audio output.
    /// </summary>
    public sealed partial class VoiceResource
    {
        /// <summary>
        /// The object type, which is always `audio.voice`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VoiceResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.VoiceResourceObject Object { get; set; }

        /// <summary>
        /// The voice identifier, which can be referenced in API endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the voice was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The voice identifier, which can be referenced in API endpoints.
        /// </param>
        /// <param name="name">
        /// The name of the voice.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the voice was created.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `audio.voice`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceResource(
            string id,
            string name,
            int createdAt,
            global::tryAGI.OpenAI.VoiceResourceObject @object)
        {
            this.Object = @object;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceResource" /> class.
        /// </summary>
        public VoiceResource()
        {
        }
    }
}