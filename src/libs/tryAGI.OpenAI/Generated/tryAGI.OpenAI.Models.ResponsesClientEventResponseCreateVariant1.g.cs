
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesClientEventResponseCreateVariant1
    {
        /// <summary>
        /// The type of the client event. Always `response.create`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponsesClientEventResponseCreateVariant1TypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesClientEventResponseCreateVariant1" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the client event. Always `response.create`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesClientEventResponseCreateVariant1(
            global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesClientEventResponseCreateVariant1" /> class.
        /// </summary>
        public ResponsesClientEventResponseCreateVariant1()
        {
        }
    }
}