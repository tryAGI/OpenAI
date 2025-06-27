
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateModelResponsePropertiesVariant2
    {
        /// <summary>
        /// An integer between 0 and 20 specifying the number of most likely tokens to<br/>
        /// return at each token position, each with an associated log probability.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public int? TopLogprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelResponsePropertiesVariant2" /> class.
        /// </summary>
        /// <param name="topLogprobs">
        /// An integer between 0 and 20 specifying the number of most likely tokens to<br/>
        /// return at each token position, each with an associated log probability.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModelResponsePropertiesVariant2(
            int? topLogprobs)
        {
            this.TopLogprobs = topLogprobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelResponsePropertiesVariant2" /> class.
        /// </summary>
        public CreateModelResponsePropertiesVariant2()
        {
        }
    }
}