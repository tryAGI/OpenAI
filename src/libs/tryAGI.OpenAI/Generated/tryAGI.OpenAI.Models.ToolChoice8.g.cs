
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Tool selection that the assistant should honor when executing the item.
    /// </summary>
    public sealed partial class ToolChoice8
    {
        /// <summary>
        /// Identifier of the requested tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoice8" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier of the requested tool.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolChoice8(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoice8" /> class.
        /// </summary>
        public ToolChoice8()
        {
        }
    }
}