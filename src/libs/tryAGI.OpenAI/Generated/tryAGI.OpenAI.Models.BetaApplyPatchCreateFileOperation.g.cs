
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Instruction describing how to create a file via the apply_patch tool.
    /// </summary>
    public sealed partial class BetaApplyPatchCreateFileOperation
    {
        /// <summary>
        /// Create a new file with the provided diff.<br/>
        /// Default Value: create_file
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationType.CreateFile</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchCreateFileOperationTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationType Type { get; set; } = global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationType.CreateFile;

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
        /// Initializes a new instance of the <see cref="BetaApplyPatchCreateFileOperation" /> class.
        /// </summary>
        /// <param name="path">
        /// Path of the file to create.
        /// </param>
        /// <param name="diff">
        /// Diff to apply.
        /// </param>
        /// <param name="type">
        /// Create a new file with the provided diff.<br/>
        /// Default Value: create_file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaApplyPatchCreateFileOperation(
            string path,
            string diff,
            global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationType type = global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationType.CreateFile)
        {
            this.Type = type;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Diff = diff ?? throw new global::System.ArgumentNullException(nameof(diff));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaApplyPatchCreateFileOperation" /> class.
        /// </summary>
        public BetaApplyPatchCreateFileOperation()
        {
        }

    }
}