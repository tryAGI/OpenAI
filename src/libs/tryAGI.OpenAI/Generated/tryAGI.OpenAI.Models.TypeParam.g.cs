
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An action to type in text.
    /// </summary>
    public sealed partial class TypeParam
    {
        /// <summary>
        /// Specifies the event type. For a type action, this property is always set to `type`.<br/>
        /// Default Value: type
        /// </summary>
        /// <default>global::tryAGI.OpenAI.TypeParamType.Type</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.TypeParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.TypeParamType Type { get; set; } = global::tryAGI.OpenAI.TypeParamType.Type;

        /// <summary>
        /// The text to type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Specifies the event type. For a type action, this property is always set to `type`.<br/>
        /// Default Value: type
        /// </param>
        /// <param name="text">
        /// The text to type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TypeParam(
            string text,
            global::tryAGI.OpenAI.TypeParamType type = global::tryAGI.OpenAI.TypeParamType.Type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeParam" /> class.
        /// </summary>
        public TypeParam()
        {
        }
    }
}