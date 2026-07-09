
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A grammar defined by the user.
    /// </summary>
    public sealed partial class BetaCustomGrammarFormatParam
    {
        /// <summary>
        /// Grammar format. Always `grammar`.<br/>
        /// Default Value: grammar
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaCustomGrammarFormatParamType.Grammar</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaCustomGrammarFormatParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaCustomGrammarFormatParamType Type { get; set; } = global::tryAGI.OpenAI.BetaCustomGrammarFormatParamType.Grammar;

        /// <summary>
        /// The syntax of the grammar definition. One of `lark` or `regex`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("syntax")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaGrammarSyntax1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaGrammarSyntax1 Syntax { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaCustomGrammarFormatParam" /> class.
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
        public BetaCustomGrammarFormatParam(
            global::tryAGI.OpenAI.BetaGrammarSyntax1 syntax,
            string definition,
            global::tryAGI.OpenAI.BetaCustomGrammarFormatParamType type = global::tryAGI.OpenAI.BetaCustomGrammarFormatParamType.Grammar)
        {
            this.Type = type;
            this.Syntax = syntax;
            this.Definition = definition ?? throw new global::System.ArgumentNullException(nameof(definition));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCustomGrammarFormatParam" /> class.
        /// </summary>
        public BetaCustomGrammarFormatParam()
        {
        }

    }
}