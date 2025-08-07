
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A custom grammar for the model to follow when generating text.<br/>
    /// Learn more in the [custom grammars guide](https://platform.openai.com/docs/guides/custom-grammars).
    /// </summary>
    public sealed partial class ResponseFormatTextGrammar
    {
        /// <summary>
        /// The custom grammar for the model to follow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grammar")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Grammar { get; set; }

        /// <summary>
        /// The type of response format being defined. Always `grammar`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseFormatTextGrammarTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseFormatTextGrammarType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormatTextGrammar" /> class.
        /// </summary>
        /// <param name="grammar">
        /// The custom grammar for the model to follow.
        /// </param>
        /// <param name="type">
        /// The type of response format being defined. Always `grammar`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseFormatTextGrammar(
            string grammar,
            global::tryAGI.OpenAI.ResponseFormatTextGrammarType type)
        {
            this.Grammar = grammar ?? throw new global::System.ArgumentNullException(nameof(grammar));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormatTextGrammar" /> class.
        /// </summary>
        public ResponseFormatTextGrammar()
        {
        }
    }
}