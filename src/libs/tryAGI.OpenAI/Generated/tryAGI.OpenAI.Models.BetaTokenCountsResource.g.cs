
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Example: {"object":"response.input_tokens","input_tokens":123}
    /// </summary>
    public sealed partial class BetaTokenCountsResource
    {
        /// <summary>
        /// Default Value: response.input_tokens
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaTokenCountsResourceObject.ResponseInputTokens</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaTokenCountsResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.BetaTokenCountsResourceObject Object { get; set; } = global::tryAGI.OpenAI.BetaTokenCountsResourceObject.ResponseInputTokens;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTokenCountsResource" /> class.
        /// </summary>
        /// <param name="inputTokens"></param>
        /// <param name="object">
        /// Default Value: response.input_tokens
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTokenCountsResource(
            int inputTokens,
            global::tryAGI.OpenAI.BetaTokenCountsResourceObject @object = global::tryAGI.OpenAI.BetaTokenCountsResourceObject.ResponseInputTokens)
        {
            this.Object = @object;
            this.InputTokens = inputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTokenCountsResource" /> class.
        /// </summary>
        public BetaTokenCountsResource()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaTokenCountsResource"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaTokenCountsResource FromInputTokens(int inputTokens)
        {
            return new BetaTokenCountsResource
            {
                InputTokens = inputTokens,
            };
        }

    }
}