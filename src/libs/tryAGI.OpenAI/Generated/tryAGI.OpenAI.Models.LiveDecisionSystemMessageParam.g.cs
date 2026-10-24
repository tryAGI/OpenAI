
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveDecisionSystemMessageParam
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionSystemMessageParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionSystemMessageParamType? Type { get; set; }

        /// <summary>
        /// Default Value: system
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDecisionSystemMessageParamRole.System</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionSystemMessageParamRoleJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionSystemMessageParamRole Role { get; set; } = global::tryAGI.OpenAI.LiveDecisionSystemMessageParamRole.System;

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
        /// Initializes a new instance of the <see cref="LiveDecisionSystemMessageParam" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="id"></param>
        /// <param name="type">
        /// Default Value: message
        /// </param>
        /// <param name="role">
        /// Default Value: system
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDecisionSystemMessageParam(
            global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionInputTextParam>> content,
            string? id,
            global::tryAGI.OpenAI.LiveDecisionSystemMessageParamType? type,
            global::tryAGI.OpenAI.LiveDecisionSystemMessageParamRole role = global::tryAGI.OpenAI.LiveDecisionSystemMessageParamRole.System)
        {
            this.Id = id;
            this.Type = type;
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionSystemMessageParam" /> class.
        /// </summary>
        public LiveDecisionSystemMessageParam()
        {
        }

    }
}