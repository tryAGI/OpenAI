
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DecisionInputToolOutputContentPartDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionInputToolOutputContentPartDiscriminatorTypeJsonConverter))]
        public global::tryAGI.OpenAI.DecisionInputToolOutputContentPartDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionInputToolOutputContentPartDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionInputToolOutputContentPartDiscriminator(
            global::tryAGI.OpenAI.DecisionInputToolOutputContentPartDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionInputToolOutputContentPartDiscriminator" /> class.
        /// </summary>
        public DecisionInputToolOutputContentPartDiscriminator()
        {
        }

    }
}