
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Example: {"object":"response.input_tokens","input_tokens":123}
    /// </summary>
    public sealed partial class TokenCountsResource
    {
        /// <summary>
        /// Default Value: response.input_tokens
        /// </summary>
        /// <default>global::tryAGI.OpenAI.TokenCountsResourceObject.ResponseInputTokens</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.TokenCountsResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.TokenCountsResourceObject Object { get; set; } = global::tryAGI.OpenAI.TokenCountsResourceObject.ResponseInputTokens;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int InputTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenCountsResource" /> class.
        /// </summary>
        /// <param name="object">
        /// Default Value: response.input_tokens
        /// </param>
        /// <param name="inputTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenCountsResource(
            int inputTokens,
            global::tryAGI.OpenAI.TokenCountsResourceObject @object = global::tryAGI.OpenAI.TokenCountsResourceObject.ResponseInputTokens)
        {
            this.InputTokens = inputTokens;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenCountsResource" /> class.
        /// </summary>
        public TokenCountsResource()
        {
        }
    }
}