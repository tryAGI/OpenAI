
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// JSON object response format. An older method of generating JSON responses.<br/>
    /// Using `json_schema` is recommended for models that support it. Note that the<br/>
    /// model will not generate JSON without a system or user message instructing it<br/>
    /// to do so.
    /// </summary>
    public sealed partial class BetaResponseFormatJsonObject
    {
        /// <summary>
        /// The type of response format being defined. Always `json_object`.
        /// </summary>
        /// <default>"json_object"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "json_object";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseFormatJsonObject" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of response format being defined. Always `json_object`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseFormatJsonObject(
            string type = "json_object")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseFormatJsonObject" /> class.
        /// </summary>
        public BetaResponseFormatJsonObject()
        {
        }

    }
}