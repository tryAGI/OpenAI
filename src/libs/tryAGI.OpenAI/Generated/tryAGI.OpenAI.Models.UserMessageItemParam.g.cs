
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserMessageItemParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The item type. Always `message`.<br/>
        /// Default Value: message
        /// </summary>
        /// <default>global::tryAGI.OpenAI.UserMessageItemParamType.Message</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UserMessageItemParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.UserMessageItemParamType Type { get; set; } = global::tryAGI.OpenAI.UserMessageItemParamType.Message;

        /// <summary>
        /// The message role. Always `user`.<br/>
        /// Default Value: user
        /// </summary>
        /// <default>global::tryAGI.OpenAI.UserMessageItemParamRole.User</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UserMessageItemParamRoleJsonConverter))]
        public global::tryAGI.OpenAI.UserMessageItemParamRole Role { get; set; } = global::tryAGI.OpenAI.UserMessageItemParamRole.User;

        /// <summary>
        /// The message content, as an array of content parts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item>, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item>, string> Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMessageItemParam" /> class.
        /// </summary>
        /// <param name="content">
        /// The message content, as an array of content parts.
        /// </param>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="type">
        /// The item type. Always `message`.<br/>
        /// Default Value: message
        /// </param>
        /// <param name="role">
        /// The message role. Always `user`.<br/>
        /// Default Value: user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserMessageItemParam(
            global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item>, string> content,
            string? id,
            string? status,
            global::tryAGI.OpenAI.UserMessageItemParamType type = global::tryAGI.OpenAI.UserMessageItemParamType.Message,
            global::tryAGI.OpenAI.UserMessageItemParamRole role = global::tryAGI.OpenAI.UserMessageItemParamRole.User)
        {
            this.Id = id;
            this.Type = type;
            this.Role = role;
            this.Content = content;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMessageItemParam" /> class.
        /// </summary>
        public UserMessageItemParam()
        {
        }

    }
}