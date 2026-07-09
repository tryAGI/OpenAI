
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Instruction for creating a new file via the apply_patch tool.
    /// </summary>
    public sealed partial class BetaApplyPatchCreateFileOperationParam
    {
        /// <summary>
        /// The operation type. Always `create_file`.<br/>
        /// Default Value: create_file
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParamType.CreateFile</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchCreateFileOperationParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParamType Type { get; set; } = global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParamType.CreateFile;

        /// <summary>
        /// Path of the file to create relative to the workspace root.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Unified diff content to apply when creating the file.
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
        /// Initializes a new instance of the <see cref="BetaApplyPatchCreateFileOperationParam" /> class.
        /// </summary>
        /// <param name="path">
        /// Path of the file to create relative to the workspace root.
        /// </param>
        /// <param name="diff">
        /// Unified diff content to apply when creating the file.
        /// </param>
        /// <param name="type">
        /// The operation type. Always `create_file`.<br/>
        /// Default Value: create_file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaApplyPatchCreateFileOperationParam(
            string path,
            string diff,
            global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParamType type = global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParamType.CreateFile)
        {
            this.Type = type;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Diff = diff ?? throw new global::System.ArgumentNullException(nameof(diff));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaApplyPatchCreateFileOperationParam" /> class.
        /// </summary>
        public BetaApplyPatchCreateFileOperationParam()
        {
        }

    }
}