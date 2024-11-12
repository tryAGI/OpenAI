
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseFormatJsonObject
    {
        /// <summary>
        /// The type of response format being defined: `json_object`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.ResponseFormatJsonObjectTypeJsonConverter))]
        public global::OpenAI.ResponseFormatJsonObjectType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormatJsonObject" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of response format being defined: `json_object`
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ResponseFormatJsonObject(
            global::OpenAI.ResponseFormatJsonObjectType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormatJsonObject" /> class.
        /// </summary>
        public ResponseFormatJsonObject()
        {
        }
    }
}