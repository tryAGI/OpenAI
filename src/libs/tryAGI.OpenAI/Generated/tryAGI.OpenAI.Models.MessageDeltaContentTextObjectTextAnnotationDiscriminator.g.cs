
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageDeltaContentTextObjectTextAnnotationDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentTextObjectTextAnnotationDiscriminatorTypeJsonConverter))]
        public global::tryAGI.OpenAI.MessageDeltaContentTextObjectTextAnnotationDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentTextObjectTextAnnotationDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MessageDeltaContentTextObjectTextAnnotationDiscriminator(
            global::tryAGI.OpenAI.MessageDeltaContentTextObjectTextAnnotationDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentTextObjectTextAnnotationDiscriminator" /> class.
        /// </summary>
        public MessageDeltaContentTextObjectTextAnnotationDiscriminator()
        {
        }
    }
}