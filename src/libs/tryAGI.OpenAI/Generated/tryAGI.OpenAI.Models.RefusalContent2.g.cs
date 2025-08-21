
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RefusalContent2
    {
        /// <summary>
        /// The refusal explanation from the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refusal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Refusal { get; set; }

        /// <summary>
        /// The type of the refusal. Always `refusal`.<br/>
        /// Default Value: refusal
        /// </summary>
        /// <default>global::tryAGI.OpenAI.RefusalContent2Type.Refusal</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RefusalContent2TypeJsonConverter))]
        public global::tryAGI.OpenAI.RefusalContent2Type Type { get; set; } = global::tryAGI.OpenAI.RefusalContent2Type.Refusal;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RefusalContent2" /> class.
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
        public RefusalContent2(
            string refusal,
            global::tryAGI.OpenAI.RefusalContent2Type type = global::tryAGI.OpenAI.RefusalContent2Type.Refusal)
        {
            this.Refusal = refusal ?? throw new global::System.ArgumentNullException(nameof(refusal));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefusalContent2" /> class.
        /// </summary>
        public RefusalContent2()
        {
        }
    }
}