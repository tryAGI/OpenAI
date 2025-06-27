
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration for a code interpreter container. Optionally specify the IDs<br/>
    /// of the files to run the code on.
    /// </summary>
    public sealed partial class CodeInterpreterToolAuto
    {
        /// <summary>
        /// An optional list of uploaded files to make available to your code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_ids")]
        public global::System.Collections.Generic.IList<string>? FileIds { get; set; }

        /// <summary>
        /// Always `auto`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CodeInterpreterToolAutoTypeJsonConverter))]
        public global::tryAGI.OpenAI.CodeInterpreterToolAutoType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterToolAuto" /> class.
        /// </summary>
        /// <param name="fileIds">
        /// An optional list of uploaded files to make available to your code.
        /// </param>
        /// <param name="type">
        /// Always `auto`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeInterpreterToolAuto(
            global::System.Collections.Generic.IList<string>? fileIds,
            global::tryAGI.OpenAI.CodeInterpreterToolAutoType type)
        {
            this.FileIds = fileIds;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterToolAuto" /> class.
        /// </summary>
        public CodeInterpreterToolAuto()
        {
        }
    }
}