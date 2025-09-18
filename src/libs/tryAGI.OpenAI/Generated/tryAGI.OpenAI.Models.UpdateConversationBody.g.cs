
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateConversationBody
    {
        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be         useful for storing additional information about the object in a structured         format, and querying for objects via API or the dashboard.<br/>
        ///         Keys are strings with a maximum length of 64 characters. Values are strings         with a maximum length of 512 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConversationBody" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be         useful for storing additional information about the object in a structured         format, and querying for objects via API or the dashboard.<br/>
        ///         Keys are strings with a maximum length of 64 characters. Values are strings         with a maximum length of 512 characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateConversationBody(
            global::System.Collections.Generic.Dictionary<string, string> metadata)
        {
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConversationBody" /> class.
        /// </summary>
        public UpdateConversationBody()
        {
        }
    }
}