
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Instruction for updating an existing file via the apply_patch tool.
    /// </summary>
    public sealed partial class ApplyPatchUpdateFileOperationParam
    {
        /// <summary>
        /// The operation type. Always `update_file`.<br/>
        /// Default Value: update_file
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParamType.UpdateFile</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchUpdateFileOperationParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParamType Type { get; set; } = global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParamType.UpdateFile;

        /// <summary>
        /// Path of the file to update relative to the workspace root.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Unified diff content to apply to the existing file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diff")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Diff { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchUpdateFileOperationParam" /> class.
        /// </summary>
        /// <param name="path">
        /// Path of the file to update relative to the workspace root.
        /// </param>
        /// <param name="diff">
        /// Unified diff content to apply to the existing file.
        /// </param>
        /// <param name="type">
        /// The operation type. Always `update_file`.<br/>
        /// Default Value: update_file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApplyPatchUpdateFileOperationParam(
            string path,
            string diff,
            global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParamType type = global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParamType.UpdateFile)
        {
            this.Type = type;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Diff = diff ?? throw new global::System.ArgumentNullException(nameof(diff));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchUpdateFileOperationParam" /> class.
        /// </summary>
        public ApplyPatchUpdateFileOperationParam()
        {
        }
    }
}