
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveDecisionRefusalParam
    {
        /// <summary>
        /// Default Value: refusal
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDecisionRefusalParamType.Refusal</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionRefusalParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionRefusalParamType Type { get; set; } = global::tryAGI.OpenAI.LiveDecisionRefusalParamType.Refusal;

        /// <summary>
        /// The refusal text.
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
        /// Initializes a new instance of the <see cref="LiveDecisionRefusalParam" /> class.
        /// </summary>
        /// <param name="refusal">
        /// The refusal text.
        /// </param>
        /// <param name="type">
        /// Default Value: refusal
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDecisionRefusalParam(
            string refusal,
            global::tryAGI.OpenAI.LiveDecisionRefusalParamType type = global::tryAGI.OpenAI.LiveDecisionRefusalParamType.Refusal)
        {
            this.Type = type;
            this.Refusal = refusal ?? throw new global::System.ArgumentNullException(nameof(refusal));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionRefusalParam" /> class.
        /// </summary>
        public LiveDecisionRefusalParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveDecisionRefusalParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveDecisionRefusalParam FromRefusal(string refusal)
        {
            return new LiveDecisionRefusalParam
            {
                Refusal = refusal,
            };
        }

    }
}