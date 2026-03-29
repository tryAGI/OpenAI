
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Instruction describing how to delete a file via the apply_patch tool.
    /// </summary>
    public sealed partial class ApplyPatchDeleteFileOperation
    {
        /// <summary>
        /// Delete the specified file.<br/>
        /// Default Value: delete_file
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationType.DeleteFile</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchDeleteFileOperationTypeJsonConverter))]
        public global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationType Type { get; set; } = global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationType.DeleteFile;

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
        /// Initializes a new instance of the <see cref="ApplyPatchDeleteFileOperation" /> class.
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
        public ApplyPatchDeleteFileOperation(
            string path,
            global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationType type = global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationType.DeleteFile)
        {
            this.Type = type;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchDeleteFileOperation" /> class.
        /// </summary>
        public ApplyPatchDeleteFileOperation()
        {
        }
    }
}