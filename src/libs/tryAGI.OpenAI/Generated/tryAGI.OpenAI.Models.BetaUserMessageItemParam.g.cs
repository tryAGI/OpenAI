
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaUserMessageItemParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTagParam? Agent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The item type. Always `message`.<br/>
        /// Default Value: message
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaUserMessageItemParamType.Message</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaUserMessageItemParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaUserMessageItemParamType Type { get; set; } = global::tryAGI.OpenAI.BetaUserMessageItemParamType.Message;

        /// <summary>
        /// The message role. Always `user`.<br/>
        /// Default Value: user
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaUserMessageItemParamRole.User</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaUserMessageItemParamRoleJsonConverter))]
        public global::tryAGI.OpenAI.BetaUserMessageItemParamRole Role { get; set; } = global::tryAGI.OpenAI.BetaUserMessageItemParamRole.User;

        /// <summary>
        /// The message content, as an array of content parts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item2>, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item2>, string> Content { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaUserMessageItemParam" /> class.
        /// </summary>
        /// <param name="content">
        /// The message content, as an array of content parts.
        /// </param>
        /// <param name="agent"></param>
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
        public BetaUserMessageItemParam(
            global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item2>, string> content,
            global::tryAGI.OpenAI.BetaAgentTagParam? agent,
            string? id,
            string? status,
            global::tryAGI.OpenAI.BetaUserMessageItemParamType type = global::tryAGI.OpenAI.BetaUserMessageItemParamType.Message,
            global::tryAGI.OpenAI.BetaUserMessageItemParamRole role = global::tryAGI.OpenAI.BetaUserMessageItemParamRole.User)
        {
            this.Agent = agent;
            this.Id = id;
            this.Type = type;
            this.Role = role;
            this.Content = content;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUserMessageItemParam" /> class.
        /// </summary>
        public BetaUserMessageItemParam()
        {
        }

    }
}