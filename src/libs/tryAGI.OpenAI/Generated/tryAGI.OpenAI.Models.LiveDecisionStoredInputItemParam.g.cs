
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveDecisionStoredInputItemParam
    {
        /// <summary>
        /// The ID of the stored Decision input item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Default Value: message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionStoredInputItemParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamType? Type { get; set; }

        /// <summary>
        /// The message role. Always `user`.<br/>
        /// Default Value: user
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamRole.User</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionStoredInputItemParamRoleJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamRole Role { get; set; } = global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamRole.User;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item2>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item2>> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionStoredInputItemParam" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the stored Decision input item.
        /// </param>
        /// <param name="content"></param>
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
        public LiveDecisionStoredInputItemParam(
            string id,
            global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant2Item2>> content,
            global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamType? type,
            global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamRole role = global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamRole.User)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionStoredInputItemParam" /> class.
        /// </summary>
        public LiveDecisionStoredInputItemParam()
        {
        }

    }
}