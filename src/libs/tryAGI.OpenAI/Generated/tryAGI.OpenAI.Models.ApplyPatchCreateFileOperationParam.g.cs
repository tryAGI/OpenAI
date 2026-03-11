
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Instruction for creating a new file via the apply_patch tool.
    /// </summary>
    public sealed partial class ApplyPatchCreateFileOperationParam
    {
        /// <summary>
        /// The operation type. Always `create_file`.<br/>
        /// Default Value: create_file
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParamType.CreateFile</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchCreateFileOperationParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParamType Type { get; set; } = global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParamType.CreateFile;

        /// <summary>
        /// Path of the file to create relative to the workspace root.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Path { get; set; } = default!;

        /// <summary>
        /// Unified diff content to apply when creating the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diff")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Diff { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchCreateFileOperationParam" /> class.
        /// </summary>
        /// <param name="type">
        /// The operation type. Always `create_file`.<br/>
        /// Default Value: create_file
        /// </param>
        /// <param name="path">
        /// Path of the file to create relative to the workspace root.
        /// </param>
        /// <param name="diff">
        /// Unified diff content to apply when creating the file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApplyPatchCreateFileOperationParam(
            string path,
            string diff,
            global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParamType type = global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParamType.CreateFile)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Diff = diff ?? throw new global::System.ArgumentNullException(nameof(diff));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchCreateFileOperationParam" /> class.
        /// </summary>
        public ApplyPatchCreateFileOperationParam()
        {
        }
    }
}