
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A refusal from the model.
    /// </summary>
    public sealed partial class RefusalContent
    {
        /// <summary>
        /// The type of the refusal. Always `refusal`.<br/>
        /// Default Value: refusal
        /// </summary>
        /// <default>global::tryAGI.OpenAI.RefusalContentType.Refusal</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RefusalContentTypeJsonConverter))]
        public global::tryAGI.OpenAI.RefusalContentType Type { get; set; } = global::tryAGI.OpenAI.RefusalContentType.Refusal;

        /// <summary>
        /// The refusal explanationfrom the model.
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
        /// Initializes a new instance of the <see cref="RefusalContent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the refusal. Always `refusal`.<br/>
        /// Default Value: refusal
        /// </param>
        /// <param name="refusal">
        /// The refusal explanationfrom the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RefusalContent(
            string refusal,
            global::tryAGI.OpenAI.RefusalContentType type = global::tryAGI.OpenAI.RefusalContentType.Refusal)
        {
            this.Refusal = refusal ?? throw new global::System.ArgumentNullException(nameof(refusal));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefusalContent" /> class.
        /// </summary>
        public RefusalContent()
        {
        }
    }
}