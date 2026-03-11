
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Your chosen grammar.
    /// </summary>
    public sealed partial class CustomToolChatCompletionsCustomFormatGrammarFormatGrammar
    {
        /// <summary>
        /// The grammar definition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("definition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Definition { get; set; }

        /// <summary>
        /// The syntax of the grammar definition. One of `lark` or `regex`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("syntax")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntaxJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax Syntax { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomToolChatCompletionsCustomFormatGrammarFormatGrammar" /> class.
        /// </summary>
        /// <param name="definition">
        /// The grammar definition.
        /// </param>
        /// <param name="syntax">
        /// The syntax of the grammar definition. One of `lark` or `regex`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomToolChatCompletionsCustomFormatGrammarFormatGrammar(
            string definition,
            global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax syntax)
        {
            this.Definition = definition ?? throw new global::System.ArgumentNullException(nameof(definition));
            this.Syntax = syntax;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomToolChatCompletionsCustomFormatGrammarFormatGrammar" /> class.
        /// </summary>
        public CustomToolChatCompletionsCustomFormatGrammarFormatGrammar()
        {
        }
    }
}