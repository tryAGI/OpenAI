
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RealtimeResponseInputMessageAssistantVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeResponseInputMessageAssistantVariant2RoleJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageAssistantVariant2Role? Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageAssistantVariant2ContentItem>? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseInputMessageAssistantVariant2" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeResponseInputMessageAssistantVariant2(
            global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageAssistantVariant2Role? role,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageAssistantVariant2ContentItem>? content)
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseInputMessageAssistantVariant2" /> class.
        /// </summary>
        public RealtimeResponseInputMessageAssistantVariant2()
        {
        }

    }
}