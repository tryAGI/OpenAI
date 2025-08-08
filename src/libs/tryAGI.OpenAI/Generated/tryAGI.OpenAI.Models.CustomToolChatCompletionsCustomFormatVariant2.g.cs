
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A grammar defined by the user.
    /// </summary>
    public sealed partial class CustomToolChatCompletionsCustomFormatVariant2
    {
        /// <summary>
        /// Your chosen grammar.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grammar")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatVariant2Grammar Grammar { get; set; }

        /// <summary>
        /// Grammar format. Always `grammar`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CustomToolChatCompletionsCustomFormatVariant2TypeJsonConverter))]
        public global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomToolChatCompletionsCustomFormatVariant2" /> class.
        /// </summary>
        /// <param name="grammar">
        /// Your chosen grammar.
        /// </param>
        /// <param name="type">
        /// Grammar format. Always `grammar`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomToolChatCompletionsCustomFormatVariant2(
            global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatVariant2Grammar grammar,
            global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatVariant2Type type)
        {
            this.Grammar = grammar ?? throw new global::System.ArgumentNullException(nameof(grammar));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomToolChatCompletionsCustomFormatVariant2" /> class.
        /// </summary>
        public CustomToolChatCompletionsCustomFormatVariant2()
        {
        }
    }
}