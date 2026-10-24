
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveDecisionAssistantMessageParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Default Value: message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionAssistantMessageParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionAssistantMessageParamType? Type { get; set; }

        /// <summary>
        /// Default Value: assistant
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDecisionAssistantMessageParamRole.Assistant</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionAssistantMessageParamRoleJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionAssistantMessageParamRole Role { get; set; } = global::tryAGI.OpenAI.LiveDecisionAssistantMessageParamRole.Assistant;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item2>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item2>> Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phase")]
        public global::tryAGI.OpenAI.LiveMessagePhase? Phase { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionAssistantMessageParam" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="id"></param>
        /// <param name="type">
        /// Default Value: message
        /// </param>
        /// <param name="phase"></param>
        /// <param name="role">
        /// Default Value: assistant
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDecisionAssistantMessageParam(
            global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item2>> content,
            string? id,
            global::tryAGI.OpenAI.LiveDecisionAssistantMessageParamType? type,
            global::tryAGI.OpenAI.LiveMessagePhase? phase,
            global::tryAGI.OpenAI.LiveDecisionAssistantMessageParamRole role = global::tryAGI.OpenAI.LiveDecisionAssistantMessageParamRole.Assistant)
        {
            this.Id = id;
            this.Type = type;
            this.Role = role;
            this.Content = content;
            this.Phase = phase;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionAssistantMessageParam" /> class.
        /// </summary>
        public LiveDecisionAssistantMessageParam()
        {
        }

    }
}