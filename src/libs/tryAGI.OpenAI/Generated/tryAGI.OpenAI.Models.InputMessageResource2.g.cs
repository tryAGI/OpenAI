
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A user message recorded in a session.
    /// </summary>
    public sealed partial class InputMessageResource2
    {
        /// <summary>
        /// The type of the input item. Always `message`.<br/>
        /// Default Value: message
        /// </summary>
        /// <default>global::tryAGI.OpenAI.InputMessageResource2Type.Message</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InputMessageResource2TypeJsonConverter))]
        public global::tryAGI.OpenAI.InputMessageResource2Type Type { get; set; } = global::tryAGI.OpenAI.InputMessageResource2Type.Message;

        /// <summary>
        /// The role of the message author. Always `user`.<br/>
        /// Default Value: user
        /// </summary>
        /// <default>global::tryAGI.OpenAI.InputMessageResource2Role.User</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InputMessageResource2RoleJsonConverter))]
        public global::tryAGI.OpenAI.InputMessageResource2Role Role { get; set; } = global::tryAGI.OpenAI.InputMessageResource2Role.User;

        /// <summary>
        /// The content of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentResource> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputMessageResource2" /> class.
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
        public InputMessageResource2(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentResource> content,
            global::tryAGI.OpenAI.InputMessageResource2Type type = global::tryAGI.OpenAI.InputMessageResource2Type.Message,
            global::tryAGI.OpenAI.InputMessageResource2Role role = global::tryAGI.OpenAI.InputMessageResource2Role.User)
        {
            this.Type = type;
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputMessageResource2" /> class.
        /// </summary>
        public InputMessageResource2()
        {
        }

    }
}