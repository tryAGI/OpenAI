
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DecisionInputRefusal
    {
        /// <summary>
        /// Default Value: refusal
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DecisionInputRefusalType.Refusal</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionInputRefusalTypeJsonConverter))]
        public global::tryAGI.OpenAI.DecisionInputRefusalType Type { get; set; } = global::tryAGI.OpenAI.DecisionInputRefusalType.Refusal;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refusal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Refusal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionInputRefusal" /> class.
        /// </summary>
        /// <param name="refusal"></param>
        /// <param name="type">
        /// Default Value: refusal
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionInputRefusal(
            string refusal,
            global::tryAGI.OpenAI.DecisionInputRefusalType type = global::tryAGI.OpenAI.DecisionInputRefusalType.Refusal)
        {
            this.Type = type;
            this.Refusal = refusal ?? throw new global::System.ArgumentNullException(nameof(refusal));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionInputRefusal" /> class.
        /// </summary>
        public DecisionInputRefusal()
        {
        }

        /// <summary>
        /// Creates a new <see cref="DecisionInputRefusal"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static DecisionInputRefusal FromRefusal(string refusal)
        {
            return new DecisionInputRefusal
            {
                Refusal = refusal,
            };
        }

    }
}