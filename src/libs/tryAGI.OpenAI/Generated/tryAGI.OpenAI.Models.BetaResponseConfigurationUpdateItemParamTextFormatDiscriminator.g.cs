
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaResponseConfigurationUpdateItemParamTextFormatDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaResponseConfigurationUpdateItemParamTextFormatDiscriminatorTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamTextFormatDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseConfigurationUpdateItemParamTextFormatDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseConfigurationUpdateItemParamTextFormatDiscriminator(
            global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamTextFormatDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseConfigurationUpdateItemParamTextFormatDiscriminator" /> class.
        /// </summary>
        public BetaResponseConfigurationUpdateItemParamTextFormatDiscriminator()
        {
        }

    }
}