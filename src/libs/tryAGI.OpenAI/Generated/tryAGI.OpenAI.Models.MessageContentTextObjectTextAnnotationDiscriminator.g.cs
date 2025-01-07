
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageContentTextObjectTextAnnotationDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.MessageContentTextObjectTextAnnotationDiscriminatorTypeJsonConverter))]
        public global::tryAGI.OpenAI.MessageContentTextObjectTextAnnotationDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentTextObjectTextAnnotationDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MessageContentTextObjectTextAnnotationDiscriminator(
            global::tryAGI.OpenAI.MessageContentTextObjectTextAnnotationDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentTextObjectTextAnnotationDiscriminator" /> class.
        /// </summary>
        public MessageContentTextObjectTextAnnotationDiscriminator()
        {
        }
    }
}