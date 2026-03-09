
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Instruction describing how to create a file via the apply_patch tool.
    /// </summary>
    public sealed partial class ApplyPatchCreateFileOperation
    {
        /// <summary>
        /// Create a new file with the provided diff.<br/>
        /// Default Value: create_file
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ApplyPatchCreateFileOperationType.CreateFile</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchCreateFileOperationTypeJsonConverter))]
        public global::tryAGI.OpenAI.ApplyPatchCreateFileOperationType Type { get; set; } = global::tryAGI.OpenAI.ApplyPatchCreateFileOperationType.CreateFile;

        /// <summary>
        /// Path of the file to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Diff to apply.
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
        /// Initializes a new instance of the <see cref="ApplyPatchCreateFileOperation" /> class.
        /// </summary>
        /// <param name="type">
        /// Create a new file with the provided diff.<br/>
        /// Default Value: create_file
        /// </param>
        /// <param name="path">
        /// Path of the file to create.
        /// </param>
        /// <param name="diff">
        /// Diff to apply.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApplyPatchCreateFileOperation(
            string path,
            string diff,
            global::tryAGI.OpenAI.ApplyPatchCreateFileOperationType type = global::tryAGI.OpenAI.ApplyPatchCreateFileOperationType.CreateFile)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Diff = diff ?? throw new global::System.ArgumentNullException(nameof(diff));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchCreateFileOperation" /> class.
        /// </summary>
        public ApplyPatchCreateFileOperation()
        {
        }
    }
}