
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The delta containing the fields that have changed on the Message.
    /// </summary>
    public sealed partial class MessageDeltaObjectDelta
    {
        /// <summary>
        /// The entity that produced the message. One of `user` or `assistant`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.MessageDeltaObjectDeltaRoleJsonConverter))]
        public global::tryAGI.OpenAI.MessageDeltaObjectDeltaRole? Role { get; set; }

        /// <summary>
        /// The content of the message in array of text and/or images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem>? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaObjectDelta" /> class.
        /// </summary>
        /// <param name="role">
        /// The entity that produced the message. One of `user` or `assistant`.
        /// </param>
        /// <param name="content">
        /// The content of the message in array of text and/or images.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MessageDeltaObjectDelta(
            global::tryAGI.OpenAI.MessageDeltaObjectDeltaRole? role,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem>? content)
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaObjectDelta" /> class.
        /// </summary>
        public MessageDeltaObjectDelta()
        {
        }
    }
}