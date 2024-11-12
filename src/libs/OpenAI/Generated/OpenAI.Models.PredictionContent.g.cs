
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Static predicted output content, such as the content of a text file that is<br/>
    /// being regenerated.
    /// </summary>
    public sealed partial class PredictionContent
    {
        /// <summary>
        /// The type of the predicted content you want to provide. This type is<br/>
        /// currently always `content`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.PredictionContentTypeJsonConverter))]
        public global::OpenAI.PredictionContentType Type { get; set; }

        /// <summary>
        /// The content that should be matched when generating a model response.<br/>
        /// If generated tokens would match this content, the entire model response<br/>
        /// can be returned much more quickly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.OneOfJsonConverterFactory2))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionRequestMessageContentPartText>> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionContent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the predicted content you want to provide. This type is<br/>
        /// currently always `content`.
        /// </param>
        /// <param name="content">
        /// The content that should be matched when generating a model response.<br/>
        /// If generated tokens would match this content, the entire model response<br/>
        /// can be returned much more quickly.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PredictionContent(
            global::OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionRequestMessageContentPartText>> content,
            global::OpenAI.PredictionContentType type)
        {
            this.Content = content;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionContent" /> class.
        /// </summary>
        public PredictionContent()
        {
        }
    }
}