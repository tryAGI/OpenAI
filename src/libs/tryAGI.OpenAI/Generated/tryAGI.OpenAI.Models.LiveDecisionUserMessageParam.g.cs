
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveDecisionUserMessageParam
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionUserMessageParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionUserMessageParamType? Type { get; set; }

        /// <summary>
        /// The message role. Always `user`.<br/>
        /// Default Value: user
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDecisionUserMessageParamRole.User</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionUserMessageParamRoleJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionUserMessageParamRole Role { get; set; } = global::tryAGI.OpenAI.LiveDecisionUserMessageParamRole.User;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item>> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionUserMessageParam" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="id"></param>
        /// <param name="type">
        /// Default Value: message
        /// </param>
        /// <param name="role">
        /// The message role. Always `user`.<br/>
        /// Default Value: user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDecisionUserMessageParam(
            global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item>> content,
            string? id,
            global::tryAGI.OpenAI.LiveDecisionUserMessageParamType? type,
            global::tryAGI.OpenAI.LiveDecisionUserMessageParamRole role = global::tryAGI.OpenAI.LiveDecisionUserMessageParamRole.User)
        {
            this.Id = id;
            this.Type = type;
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionUserMessageParam" /> class.
        /// </summary>
        public LiveDecisionUserMessageParam()
        {
        }

    }
}