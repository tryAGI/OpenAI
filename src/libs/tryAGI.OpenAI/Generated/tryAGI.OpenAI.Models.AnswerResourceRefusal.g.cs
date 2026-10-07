
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The model declined to answer this question. Other questions in the same request can still receive answers.
    /// </summary>
    public sealed partial class AnswerResourceRefusal
    {
        /// <summary>
        /// The type of the object. Always `refusal`.<br/>
        /// Default Value: refusal
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AnswerResourceRefusalType.Refusal</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnswerResourceRefusalTypeJsonConverter))]
        public global::tryAGI.OpenAI.AnswerResourceRefusalType Type { get; set; } = global::tryAGI.OpenAI.AnswerResourceRefusalType.Refusal;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerResourceRefusal" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type">
        /// The type of the object. Always `refusal`.<br/>
        /// Default Value: refusal
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnswerResourceRefusal(
            string? name,
            global::tryAGI.OpenAI.AnswerResourceRefusalType type = global::tryAGI.OpenAI.AnswerResourceRefusalType.Refusal)
        {
            this.Type = type;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerResourceRefusal" /> class.
        /// </summary>
        public AnswerResourceRefusal()
        {
        }

    }
}