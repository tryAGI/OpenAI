
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Metadata for work delegated by the Live model. Client delegations are handled by your application; Responses delegations run on the configured backend.
    /// </summary>
    public sealed partial class LiveDelegationItem
    {
        /// <summary>
        /// The unique ID of the delegation. Use this as delegation_id when replying to client-owned work or correlating Responses events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, always `delegation`.<br/>
        /// Default Value: delegation
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDelegationItemType.Delegation</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDelegationItemTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDelegationItemType Type { get; set; } = global::tryAGI.OpenAI.LiveDelegationItemType.Delegation;

        /// <summary>
        /// Where the Live model delegated the work: `client` for your application, or `responses` for the configured Responses backend.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.LiveDelegationItemTargetVariant1?, global::tryAGI.OpenAI.LiveDelegationItemTargetVariant2?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDelegationItemTargetVariant1?, global::tryAGI.OpenAI.LiveDelegationItemTargetVariant2?> Target { get; set; }

        /// <summary>
        /// The ID of the Responses API response associated with a Responses delegation. Omitted for client delegations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        public string? ResponseId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDelegationItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the delegation. Use this as delegation_id when replying to client-owned work or correlating Responses events.
        /// </param>
        /// <param name="target">
        /// Where the Live model delegated the work: `client` for your application, or `responses` for the configured Responses backend.
        /// </param>
        /// <param name="responseId">
        /// The ID of the Responses API response associated with a Responses delegation. Omitted for client delegations.
        /// </param>
        /// <param name="type">
        /// The object type, always `delegation`.<br/>
        /// Default Value: delegation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDelegationItem(
            string id,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDelegationItemTargetVariant1?, global::tryAGI.OpenAI.LiveDelegationItemTargetVariant2?> target,
            string? responseId,
            global::tryAGI.OpenAI.LiveDelegationItemType type = global::tryAGI.OpenAI.LiveDelegationItemType.Delegation)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Target = target;
            this.ResponseId = responseId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDelegationItem" /> class.
        /// </summary>
        public LiveDelegationItem()
        {
        }

    }
}