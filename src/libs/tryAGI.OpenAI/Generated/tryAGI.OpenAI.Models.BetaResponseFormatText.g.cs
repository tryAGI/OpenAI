
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default response format. Used to generate text responses.
    /// </summary>
    public sealed partial class BetaResponseFormatText
    {
        /// <summary>
        /// The type of response format being defined. Always `text`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaResponseFormatTextTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaResponseFormatTextType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseFormatText" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of response format being defined. Always `text`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseFormatText(
            global::tryAGI.OpenAI.BetaResponseFormatTextType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseFormatText" /> class.
        /// </summary>
        public BetaResponseFormatText()
        {
        }

    }
}