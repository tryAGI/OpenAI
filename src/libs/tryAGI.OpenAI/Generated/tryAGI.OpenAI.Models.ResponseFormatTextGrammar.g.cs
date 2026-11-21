
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A custom grammar for the model to follow when generating text.<br/>
    /// Learn more in the [custom grammars guide](https://developers.openai.com/api/docs/guides/function-calling#context-free-grammars).
    /// </summary>
    public sealed partial class ResponseFormatTextGrammar
    {
        /// <summary>
        /// The type of response format being defined. Always `grammar`.
        /// </summary>
        /// <default>"grammar"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "grammar";

        /// <summary>
        /// The custom grammar for the model to follow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grammar")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Grammar { get; set; }

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
            string type = "grammar")
        {
            this.Type = type;
            this.Grammar = grammar ?? throw new global::System.ArgumentNullException(nameof(grammar));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormatTextGrammar" /> class.
        /// </summary>
        public ResponseFormatTextGrammar()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ResponseFormatTextGrammar"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ResponseFormatTextGrammar FromGrammar(string grammar)
        {
            return new ResponseFormatTextGrammar
            {
                Grammar = grammar,
            };
        }

    }
}