
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An internal identifier for an item to reference.
    /// </summary>
    public sealed partial class ItemReferenceParam
    {
        /// <summary>
        /// The ID of the item to reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The type of item to reference. Always `item_reference`.<br/>
        /// Default Value: item_reference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ItemReferenceParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.ItemReferenceParamType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemReferenceParam" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the item to reference.
        /// </param>
        /// <param name="type">
        /// The type of item to reference. Always `item_reference`.<br/>
        /// Default Value: item_reference
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ItemReferenceParam(
            string id,
            global::tryAGI.OpenAI.ItemReferenceParamType? type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemReferenceParam" /> class.
        /// </summary>
        public ItemReferenceParam()
        {
        }
    }
}