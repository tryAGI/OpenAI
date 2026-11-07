
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// Reference an existing item in this Realtime session as response.create input.<br/>
    /// Item references are only accepted in the response input array, not as new<br/>
    /// conversation items.
    /// </summary>
    public sealed partial class RealtimeResponseItemReference
    {
        /// <summary>
        /// The type of this item. Always `item_reference`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeResponseItemReferenceTypeJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseItemReferenceType Type { get; set; }

        /// <summary>
        /// The ID of an existing item in the same Realtime session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseItemReference" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of an existing item in the same Realtime session.
        /// </param>
        /// <param name="type">
        /// The type of this item. Always `item_reference`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeResponseItemReference(
            string id,
            global::tryAGI.OpenAI.Realtime.RealtimeResponseItemReferenceType type)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseItemReference" /> class.
        /// </summary>
        public RealtimeResponseItemReference()
        {
        }

    }
}