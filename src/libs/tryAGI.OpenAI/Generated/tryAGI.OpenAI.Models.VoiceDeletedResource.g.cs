
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoiceDeletedResource
    {
        /// <summary>
        /// The voice identifier.<br/>
        /// Example: voice_1234
        /// </summary>
        /// <example>voice_1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, which is always `audio.voice.deleted`.
        /// </summary>
        /// <default>"audio.voice.deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "audio.voice.deleted";

        /// <summary>
        /// Whether the voice was deleted.
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
        /// Initializes a new instance of the <see cref="VoiceDeletedResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The voice identifier.<br/>
        /// Example: voice_1234
        /// </param>
        /// <param name="deleted">
        /// Whether the voice was deleted.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `audio.voice.deleted`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceDeletedResource(
            string id,
            bool deleted,
            string @object = "audio.voice.deleted")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceDeletedResource" /> class.
        /// </summary>
        public VoiceDeletedResource()
        {
        }

    }
}