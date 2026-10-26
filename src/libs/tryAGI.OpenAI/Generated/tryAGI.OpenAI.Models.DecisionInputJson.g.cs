
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A JSON object or an array of objects rendered as text. Nested values may be any JSON value. Limited to 32 container levels, 10,000 values, and 256 KiB of compact UTF-8 JSON.
    /// </summary>
    public sealed partial class DecisionInputJson
    {
        /// <summary>
        /// Default Value: input_json
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DecisionInputJsonType.InputJson</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionInputJsonTypeJsonConverter))]
        public global::tryAGI.OpenAI.DecisionInputJsonType Type { get; set; } = global::tryAGI.OpenAI.DecisionInputJsonType.InputJson;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<object, global::System.Collections.Generic.IList<object>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<object, global::System.Collections.Generic.IList<object>> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionInputJson" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type">
        /// Default Value: input_json
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionInputJson(
            global::tryAGI.OpenAI.OneOf<object, global::System.Collections.Generic.IList<object>> data,
            global::tryAGI.OpenAI.DecisionInputJsonType type = global::tryAGI.OpenAI.DecisionInputJsonType.InputJson)
        {
            this.Type = type;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionInputJson" /> class.
        /// </summary>
        public DecisionInputJson()
        {
        }

    }
}