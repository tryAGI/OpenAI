
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunStepDetailsToolCallsFileSearchObject
    {
        /// <summary>
        /// For now, this is always going to be an empty object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_search")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectFileSearch FileSearch { get; set; }

        /// <summary>
        /// The ID of the tool call object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The type of tool call. This is always going to be `file_search` for this type of tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeJsonConverter))]
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsFileSearchObject" /> class.
        /// </summary>
        /// <param name="fileSearch">
        /// For now, this is always going to be an empty object.
        /// </param>
        /// <param name="id">
        /// The ID of the tool call object.
        /// </param>
        /// <param name="type">
        /// The type of tool call. This is always going to be `file_search` for this type of tool call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStepDetailsToolCallsFileSearchObject(
            global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectFileSearch fileSearch,
            string id,
            global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectType type)
        {
            this.FileSearch = fileSearch ?? throw new global::System.ArgumentNullException(nameof(fileSearch));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsFileSearchObject" /> class.
        /// </summary>
        public RunStepDetailsToolCallsFileSearchObject()
        {
        }
    }
}