
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Instruction for deleting an existing file via the apply_patch tool.
    /// </summary>
    public sealed partial class BetaApplyPatchDeleteFileOperationParam
    {
        /// <summary>
        /// The operation type. Always `delete_file`.<br/>
        /// Default Value: delete_file
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParamType.DeleteFile</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchDeleteFileOperationParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParamType Type { get; set; } = global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParamType.DeleteFile;

        /// <summary>
        /// Path of the file to delete relative to the workspace root.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaApplyPatchDeleteFileOperationParam" /> class.
        /// </summary>
        /// <param name="path">
        /// Path of the file to delete relative to the workspace root.
        /// </param>
        /// <param name="type">
        /// The operation type. Always `delete_file`.<br/>
        /// Default Value: delete_file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaApplyPatchDeleteFileOperationParam(
            string path,
            global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParamType type = global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParamType.DeleteFile)
        {
            this.Type = type;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaApplyPatchDeleteFileOperationParam" /> class.
        /// </summary>
        public BetaApplyPatchDeleteFileOperationParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaApplyPatchDeleteFileOperationParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaApplyPatchDeleteFileOperationParam FromPath(string path)
        {
            return new BetaApplyPatchDeleteFileOperationParam
            {
                Path = path,
            };
        }

    }
}