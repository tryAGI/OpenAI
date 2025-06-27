
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEvalResponsesRunDataSourceInputMessagesVariant1TemplateItem
    {
        /// <summary>
        /// The content of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// The role of the message (e.g. "system", "assistant", "user").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalResponsesRunDataSourceInputMessagesVariant1TemplateItem" /> class.
        /// </summary>
        /// <param name="content">
        /// The content of the message.
        /// </param>
        /// <param name="role">
        /// The role of the message (e.g. "system", "assistant", "user").
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEvalResponsesRunDataSourceInputMessagesVariant1TemplateItem(
            string content,
            string role)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalResponsesRunDataSourceInputMessagesVariant1TemplateItem" /> class.
        /// </summary>
        public CreateEvalResponsesRunDataSourceInputMessagesVariant1TemplateItem()
        {
        }
    }
}