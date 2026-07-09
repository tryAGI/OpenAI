
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An internal identifier for an item to reference.
    /// </summary>
    public sealed partial class BetaItemReferenceParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTagParam? Agent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public global::tryAGI.OpenAI.BetaItemReferenceParamType2? Type { get; set; }

        /// <summary>
        /// The ID of the item to reference.
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
        /// Initializes a new instance of the <see cref="BetaItemReferenceParam" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the item to reference.
        /// </param>
        /// <param name="agent"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaItemReferenceParam(
            string id,
            global::tryAGI.OpenAI.BetaAgentTagParam? agent,
            global::tryAGI.OpenAI.BetaItemReferenceParamType2? type)
        {
            this.Agent = agent;
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaItemReferenceParam" /> class.
        /// </summary>
        public BetaItemReferenceParam()
        {
        }

    }
}