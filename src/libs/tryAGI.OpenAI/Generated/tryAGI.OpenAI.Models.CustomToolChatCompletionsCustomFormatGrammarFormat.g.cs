
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A grammar defined by the user.
    /// </summary>
    public sealed partial class CustomToolChatCompletionsCustomFormatGrammarFormat
    {
        /// <summary>
        /// Grammar format. Always `grammar`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CustomToolChatCompletionsCustomFormatGrammarFormatTypeJsonConverter))]
        public global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatType Type { get; set; }

        /// <summary>
        /// Your chosen grammar.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grammar")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatGrammar Grammar { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomToolChatCompletionsCustomFormatGrammarFormat" /> class.
        /// </summary>
        /// <param name="type">
        /// Grammar format. Always `grammar`.
        /// </param>
        /// <param name="grammar">
        /// Your chosen grammar.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomToolChatCompletionsCustomFormatGrammarFormat(
            global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatGrammar grammar,
            global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatType type)
        {
            this.Grammar = grammar ?? throw new global::System.ArgumentNullException(nameof(grammar));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomToolChatCompletionsCustomFormatGrammarFormat" /> class.
        /// </summary>
        public CustomToolChatCompletionsCustomFormatGrammarFormat()
        {
        }
    }
}