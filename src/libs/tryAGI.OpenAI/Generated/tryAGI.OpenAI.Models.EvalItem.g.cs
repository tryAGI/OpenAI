
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A message input to the model with a role indicating instruction following<br/>
    /// hierarchy. Instructions given with the `developer` or `system` role take<br/>
    /// precedence over instructions given with the `user` role. Messages with the<br/>
    /// `assistant` role are presumed to have been generated by the model in previous<br/>
    /// interactions.
    /// </summary>
    public sealed partial class EvalItem
    {
        /// <summary>
        /// Inputs to the model - can contain template strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::tryAGI.OpenAI.InputTextContent, global::tryAGI.OpenAI.EvalItemContentVariant3, global::tryAGI.OpenAI.EvalItemContentVariant4, byte[]>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.InputTextContent, global::tryAGI.OpenAI.EvalItemContentVariant3, global::tryAGI.OpenAI.EvalItemContentVariant4, byte[]> Content { get; set; }

        /// <summary>
        /// The role of the message input. One of `user`, `assistant`, `system`, or<br/>
        /// `developer`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EvalItemRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.EvalItemRole Role { get; set; }

        /// <summary>
        /// The type of the message input. Always `message`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EvalItemTypeJsonConverter))]
        public global::tryAGI.OpenAI.EvalItemType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalItem" /> class.
        /// </summary>
        /// <param name="content">
        /// Inputs to the model - can contain template strings.
        /// </param>
        /// <param name="role">
        /// The role of the message input. One of `user`, `assistant`, `system`, or<br/>
        /// `developer`.
        /// </param>
        /// <param name="type">
        /// The type of the message input. Always `message`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalItem(
            global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.InputTextContent, global::tryAGI.OpenAI.EvalItemContentVariant3, global::tryAGI.OpenAI.EvalItemContentVariant4, byte[]> content,
            global::tryAGI.OpenAI.EvalItemRole role,
            global::tryAGI.OpenAI.EvalItemType? type)
        {
            this.Content = content;
            this.Role = role;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalItem" /> class.
        /// </summary>
        public EvalItem()
        {
        }
    }
}