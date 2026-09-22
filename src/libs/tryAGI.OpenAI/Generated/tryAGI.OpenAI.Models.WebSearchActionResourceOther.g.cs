
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Another web search action.
    /// </summary>
    public sealed partial class WebSearchActionResourceOther
    {
        /// <summary>
        /// The type of the object. Always `other`.<br/>
        /// Default Value: other
        /// </summary>
        /// <default>global::tryAGI.OpenAI.WebSearchActionResourceOtherType.Other</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchActionResourceOtherTypeJsonConverter))]
        public global::tryAGI.OpenAI.WebSearchActionResourceOtherType Type { get; set; } = global::tryAGI.OpenAI.WebSearchActionResourceOtherType.Other;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchActionResourceOther" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the object. Always `other`.<br/>
        /// Default Value: other
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchActionResourceOther(
            global::tryAGI.OpenAI.WebSearchActionResourceOtherType type = global::tryAGI.OpenAI.WebSearchActionResourceOtherType.Other)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchActionResourceOther" /> class.
        /// </summary>
        public WebSearchActionResourceOther()
        {
        }

    }
}