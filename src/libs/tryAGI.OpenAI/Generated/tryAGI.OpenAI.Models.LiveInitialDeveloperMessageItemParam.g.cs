
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A developer message included in the initial text history of a Live session.
    /// </summary>
    public sealed partial class LiveInitialDeveloperMessageItemParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The history item type. Always `message`.<br/>
        /// Default Value: message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveInitialDeveloperMessageItemParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParamType? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::tryAGI.OpenAI.LiveInitialMessageStatus? Status { get; set; }

        /// <summary>
        /// The author of this history message. Always `developer`.<br/>
        /// Default Value: developer
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParamRole.Developer</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveInitialDeveloperMessageItemParamRoleJsonConverter))]
        public global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParamRole Role { get; set; } = global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParamRole.Developer;

        /// <summary>
        /// The message content. Supply exactly one text part for the initial Live conversation history.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveInitialInputTextContentPartParam> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveInitialDeveloperMessageItemParam" /> class.
        /// </summary>
        /// <param name="content">
        /// The message content. Supply exactly one text part for the initial Live conversation history.
        /// </param>
        /// <param name="id"></param>
        /// <param name="type">
        /// The history item type. Always `message`.<br/>
        /// Default Value: message
        /// </param>
        /// <param name="status"></param>
        /// <param name="role">
        /// The author of this history message. Always `developer`.<br/>
        /// Default Value: developer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveInitialDeveloperMessageItemParam(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveInitialInputTextContentPartParam> content,
            string? id,
            global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParamType? type,
            global::tryAGI.OpenAI.LiveInitialMessageStatus? status,
            global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParamRole role = global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParamRole.Developer)
        {
            this.Id = id;
            this.Type = type;
            this.Status = status;
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveInitialDeveloperMessageItemParam" /> class.
        /// </summary>
        public LiveInitialDeveloperMessageItemParam()
        {
        }

    }
}