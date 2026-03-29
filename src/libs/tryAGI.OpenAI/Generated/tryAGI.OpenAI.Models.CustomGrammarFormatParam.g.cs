
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A grammar defined by the user.
    /// </summary>
    public sealed partial class CustomGrammarFormatParam
    {
        /// <summary>
        /// Grammar format. Always `grammar`.<br/>
        /// Default Value: grammar
        /// </summary>
        /// <default>global::tryAGI.OpenAI.CustomGrammarFormatParamType.Grammar</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CustomGrammarFormatParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.CustomGrammarFormatParamType Type { get; set; } = global::tryAGI.OpenAI.CustomGrammarFormatParamType.Grammar;

        /// <summary>
        /// The syntax of the grammar definition. One of `lark` or `regex`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("syntax")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.GrammarSyntax1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.GrammarSyntax1 Syntax { get; set; }

        /// <summary>
        /// The grammar definition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("definition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Definition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomGrammarFormatParam" /> class.
        /// </summary>
        /// <param name="syntax">
        /// The syntax of the grammar definition. One of `lark` or `regex`.
        /// </param>
        /// <param name="definition">
        /// The grammar definition.
        /// </param>
        /// <param name="type">
        /// Grammar format. Always `grammar`.<br/>
        /// Default Value: grammar
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomGrammarFormatParam(
            global::tryAGI.OpenAI.GrammarSyntax1 syntax,
            string definition,
            global::tryAGI.OpenAI.CustomGrammarFormatParamType type = global::tryAGI.OpenAI.CustomGrammarFormatParamType.Grammar)
        {
            this.Type = type;
            this.Syntax = syntax;
            this.Definition = definition ?? throw new global::System.ArgumentNullException(nameof(definition));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomGrammarFormatParam" /> class.
        /// </summary>
        public CustomGrammarFormatParam()
        {
        }
    }
}