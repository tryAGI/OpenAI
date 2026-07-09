
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Instruction describing how to delete a file via the apply_patch tool.
    /// </summary>
    public sealed partial class BetaApplyPatchDeleteFileOperation
    {
        /// <summary>
        /// Delete the specified file.<br/>
        /// Default Value: delete_file
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationType.DeleteFile</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchDeleteFileOperationTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationType Type { get; set; } = global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationType.DeleteFile;

        /// <summary>
        /// Path of the file to delete.
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
        /// Initializes a new instance of the <see cref="BetaApplyPatchDeleteFileOperation" /> class.
        /// </summary>
        /// <param name="path">
        /// Path of the file to delete.
        /// </param>
        /// <param name="type">
        /// Delete the specified file.<br/>
        /// Default Value: delete_file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaApplyPatchDeleteFileOperation(
            string path,
            global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationType type = global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationType.DeleteFile)
        {
            this.Type = type;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaApplyPatchDeleteFileOperation" /> class.
        /// </summary>
        public BetaApplyPatchDeleteFileOperation()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaApplyPatchDeleteFileOperation"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaApplyPatchDeleteFileOperation FromPath(string path)
        {
            return new BetaApplyPatchDeleteFileOperation
            {
                Path = path,
            };
        }

    }
}