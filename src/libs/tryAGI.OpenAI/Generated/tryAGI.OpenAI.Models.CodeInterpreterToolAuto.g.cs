
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
        /// Always `auto`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CodeInterpreterToolAutoTypeJsonConverter))]
        public global::tryAGI.OpenAI.CodeInterpreterToolAutoType Type { get; set; }

        /// <summary>
        /// An optional list of uploaded files to make available to your code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_ids")]
        public global::System.Collections.Generic.IList<string>? FileIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterToolAuto" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `auto`.
        /// </param>
        /// <param name="fileIds">
        /// An optional list of uploaded files to make available to your code.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeInterpreterToolAuto(
            global::tryAGI.OpenAI.CodeInterpreterToolAutoType type,
            global::System.Collections.Generic.IList<string>? fileIds)
        {
            this.Type = type;
            this.FileIds = fileIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterToolAuto" /> class.
        /// </summary>
        public CodeInterpreterToolAuto()
        {
        }
    }
}