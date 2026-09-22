
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SafetyCaseResource
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Default Value: safety.case
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SafetyCaseResourceObject.SafetyCase</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SafetyCaseResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.SafetyCaseResourceObject Object { get; set; } = global::tryAGI.OpenAI.SafetyCaseResourceObject.SafetyCase;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityIdentifier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.SafetyCaseNotice Notice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SafetyCaseResource" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="entityIdentifier"></param>
        /// <param name="notice"></param>
        /// <param name="reason"></param>
        /// <param name="object">
        /// Default Value: safety.case
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SafetyCaseResource(
            string id,
            int createdAt,
            string entityIdentifier,
            global::tryAGI.OpenAI.SafetyCaseNotice notice,
            string? reason,
            global::tryAGI.OpenAI.SafetyCaseResourceObject @object = global::tryAGI.OpenAI.SafetyCaseResourceObject.SafetyCase)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.CreatedAt = createdAt;
            this.EntityIdentifier = entityIdentifier ?? throw new global::System.ArgumentNullException(nameof(entityIdentifier));
            this.Reason = reason;
            this.Notice = notice ?? throw new global::System.ArgumentNullException(nameof(notice));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SafetyCaseResource" /> class.
        /// </summary>
        public SafetyCaseResource()
        {
        }

    }
}