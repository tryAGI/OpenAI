
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A user message submitted to a session.
    /// </summary>
    public sealed partial class InputMessageParam
    {
        /// <summary>
        /// The type of the input item. Always `message`.<br/>
        /// Default Value: message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InputMessageParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.InputMessageParamType? Type { get; set; }

        /// <summary>
        /// The role of the message author. Always `user`.<br/>
        /// Default Value: user
        /// </summary>
        /// <default>global::tryAGI.OpenAI.InputMessageParamRole.User</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InputMessageParamRoleJsonConverter))]
        public global::tryAGI.OpenAI.InputMessageParamRole Role { get; set; } = global::tryAGI.OpenAI.InputMessageParamRole.User;

        /// <summary>
        /// The content of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentParam> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputMessageParam" /> class.
        /// </summary>
        /// <param name="content">
        /// The content of the message.
        /// </param>
        /// <param name="type">
        /// The type of the input item. Always `message`.<br/>
        /// Default Value: message
        /// </param>
        /// <param name="role">
        /// The role of the message author. Always `user`.<br/>
        /// Default Value: user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputMessageParam(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentParam> content,
            global::tryAGI.OpenAI.InputMessageParamType? type,
            global::tryAGI.OpenAI.InputMessageParamRole role = global::tryAGI.OpenAI.InputMessageParamRole.User)
        {
            this.Type = type;
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputMessageParam" /> class.
        /// </summary>
        public InputMessageParam()
        {
        }

    }
}