
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A grammar defined by the user.
    /// </summary>
    public sealed partial class CustomToolFormatVariant2
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CustomToolFormatVariant2SyntaxJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.CustomToolFormatVariant2Syntax Syntax { get; set; }

        /// <summary>
        /// Grammar format. Always `grammar`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CustomToolFormatVariant2TypeJsonConverter))]
        public global::tryAGI.OpenAI.CustomToolFormatVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomToolFormatVariant2" /> class.
        /// </summary>
        /// <param name="definition">
        /// The grammar definition.
        /// </param>
        /// <param name="syntax">
        /// The syntax of the grammar definition. One of `lark` or `regex`.
        /// </param>
        /// <param name="type">
        /// Grammar format. Always `grammar`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomToolFormatVariant2(
            string definition,
            global::tryAGI.OpenAI.CustomToolFormatVariant2Syntax syntax,
            global::tryAGI.OpenAI.CustomToolFormatVariant2Type type)
        {
            this.Definition = definition ?? throw new global::System.ArgumentNullException(nameof(definition));
            this.Syntax = syntax;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomToolFormatVariant2" /> class.
        /// </summary>
        public CustomToolFormatVariant2()
        {
        }
    }
}