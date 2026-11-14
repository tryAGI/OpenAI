
#nullable enable

namespace tryAGI.OpenAI
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
        /// <default>"item_reference"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "item_reference";

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
            string type = "item_reference")
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

        /// <summary>
        /// Creates a new <see cref="RealtimeResponseItemReference"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static RealtimeResponseItemReference FromId(string id)
        {
            return new RealtimeResponseItemReference
            {
                Id = id,
            };
        }

    }
}