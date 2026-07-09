
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An action to type in text.
    /// </summary>
    public sealed partial class BetaTypeParam
    {
        /// <summary>
        /// Specifies the event type. For a type action, this property is always set to `type`.<br/>
        /// Default Value: type
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaTypeParamType.Type</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaTypeParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaTypeParamType Type { get; set; } = global::tryAGI.OpenAI.BetaTypeParamType.Type;

        /// <summary>
        /// The text to type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTypeParam" /> class.
        /// </summary>
        /// <param name="text">
        /// The text to type.
        /// </param>
        /// <param name="type">
        /// Specifies the event type. For a type action, this property is always set to `type`.<br/>
        /// Default Value: type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTypeParam(
            string text,
            global::tryAGI.OpenAI.BetaTypeParamType type = global::tryAGI.OpenAI.BetaTypeParamType.Type)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTypeParam" /> class.
        /// </summary>
        public BetaTypeParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaTypeParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaTypeParam FromText(string text)
        {
            return new BetaTypeParam
            {
                Text = text,
            };
        }

    }
}