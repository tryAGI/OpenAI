
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RealtimeResponseInputMessageFields
    {
        /// <summary>
        /// An optional client ID. The value `root` is reserved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseInputMessageFieldsTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageFieldsType Type { get; set; }

        /// <summary>
        /// Optional input status. Omission or null defaults to completed.<br/>
        /// Default Value: completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseInputMessageFieldsStatusJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageFieldsStatus? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseInputMessageFields" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content"></param>
        /// <param name="id">
        /// An optional client ID. The value `root` is reserved.
        /// </param>
        /// <param name="type"></param>
        /// <param name="status">
        /// Optional input status. Omission or null defaults to completed.<br/>
        /// Default Value: completed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeResponseInputMessageFields(
            string role,
            byte[] content,
            string? id,
            global::tryAGI.OpenAI.RealtimeResponseInputMessageFieldsType type,
            global::tryAGI.OpenAI.RealtimeResponseInputMessageFieldsStatus? status)
        {
            this.Id = id;
            this.Type = type;
            this.Status = status;
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseInputMessageFields" /> class.
        /// </summary>
        public RealtimeResponseInputMessageFields()
        {
        }

    }
}