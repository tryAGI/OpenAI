
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageObjectAttachment
    {
        /// <summary>
        /// The ID of the file to attach to the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// The tools to add this file to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageObjectAttachment" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the file to attach to the message.
        /// </param>
        /// <param name="tools">
        /// The tools to add this file to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageObjectAttachment(
            string? fileId,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>>? tools)
        {
            this.FileId = fileId;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageObjectAttachment" /> class.
        /// </summary>
        public MessageObjectAttachment()
        {
        }
    }
}