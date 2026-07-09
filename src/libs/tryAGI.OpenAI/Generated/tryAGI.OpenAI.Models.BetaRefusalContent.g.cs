
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A refusal from the model.
    /// </summary>
    public sealed partial class BetaRefusalContent
    {
        /// <summary>
        /// The type of the refusal. Always `refusal`.<br/>
        /// Default Value: refusal
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaRefusalContentType.Refusal</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaRefusalContentTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaRefusalContentType Type { get; set; } = global::tryAGI.OpenAI.BetaRefusalContentType.Refusal;

        /// <summary>
        /// The refusal explanation from the model.
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
        /// Initializes a new instance of the <see cref="BetaRefusalContent" /> class.
        /// </summary>
        /// <param name="refusal">
        /// The refusal explanation from the model.
        /// </param>
        /// <param name="type">
        /// The type of the refusal. Always `refusal`.<br/>
        /// Default Value: refusal
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRefusalContent(
            string refusal,
            global::tryAGI.OpenAI.BetaRefusalContentType type = global::tryAGI.OpenAI.BetaRefusalContentType.Refusal)
        {
            this.Type = type;
            this.Refusal = refusal ?? throw new global::System.ArgumentNullException(nameof(refusal));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRefusalContent" /> class.
        /// </summary>
        public BetaRefusalContent()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaRefusalContent"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaRefusalContent FromRefusal(string refusal)
        {
            return new BetaRefusalContent
            {
                Refusal = refusal,
            };
        }

    }
}