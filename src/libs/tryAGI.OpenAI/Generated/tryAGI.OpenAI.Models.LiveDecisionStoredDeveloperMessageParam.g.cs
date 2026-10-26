
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveDecisionStoredDeveloperMessageParam
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionStoredDeveloperMessageParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionStoredDeveloperMessageParamType? Type { get; set; }

        /// <summary>
        /// Default Value: developer
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDecisionStoredDeveloperMessageParamRole.Developer</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionStoredDeveloperMessageParamRoleJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionStoredDeveloperMessageParamRole Role { get; set; } = global::tryAGI.OpenAI.LiveDecisionStoredDeveloperMessageParamRole.Developer;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionInputTextParam>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionInputTextParam>> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionStoredDeveloperMessageParam" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="content"></param>
        /// <param name="type">
        /// Default Value: message
        /// </param>
        /// <param name="role">
        /// Default Value: developer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDecisionStoredDeveloperMessageParam(
            string id,
            global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionInputTextParam>> content,
            global::tryAGI.OpenAI.LiveDecisionStoredDeveloperMessageParamType? type,
            global::tryAGI.OpenAI.LiveDecisionStoredDeveloperMessageParamRole role = global::tryAGI.OpenAI.LiveDecisionStoredDeveloperMessageParamRole.Developer)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionStoredDeveloperMessageParam" /> class.
        /// </summary>
        public LiveDecisionStoredDeveloperMessageParam()
        {
        }

    }
}