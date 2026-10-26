
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveDecisionStoredAssistantMessageParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Default Value: message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionStoredAssistantMessageParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionStoredAssistantMessageParamType? Type { get; set; }

        /// <summary>
        /// Default Value: assistant
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDecisionStoredAssistantMessageParamRole.Assistant</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionStoredAssistantMessageParamRoleJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionStoredAssistantMessageParamRole Role { get; set; } = global::tryAGI.OpenAI.LiveDecisionStoredAssistantMessageParamRole.Assistant;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item4>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item4>> Content { get; set; }

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
        /// Initializes a new instance of the <see cref="LiveDecisionStoredAssistantMessageParam" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="content"></param>
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
        public LiveDecisionStoredAssistantMessageParam(
            string id,
            global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item4>> content,
            global::tryAGI.OpenAI.LiveDecisionStoredAssistantMessageParamType? type,
            global::tryAGI.OpenAI.LiveMessagePhase? phase,
            global::tryAGI.OpenAI.LiveDecisionStoredAssistantMessageParamRole role = global::tryAGI.OpenAI.LiveDecisionStoredAssistantMessageParamRole.Assistant)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Role = role;
            this.Content = content;
            this.Phase = phase;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionStoredAssistantMessageParam" /> class.
        /// </summary>
        public LiveDecisionStoredAssistantMessageParam()
        {
        }

    }
}