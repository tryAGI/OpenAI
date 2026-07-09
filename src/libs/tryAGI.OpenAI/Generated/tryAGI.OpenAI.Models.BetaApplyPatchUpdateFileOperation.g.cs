
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Instruction describing how to update a file via the apply_patch tool.
    /// </summary>
    public sealed partial class BetaApplyPatchUpdateFileOperation
    {
        /// <summary>
        /// Update an existing file with the provided diff.<br/>
        /// Default Value: update_file
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationType.UpdateFile</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchUpdateFileOperationTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationType Type { get; set; } = global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationType.UpdateFile;

        /// <summary>
        /// Path of the file to update.
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
        /// Initializes a new instance of the <see cref="BetaApplyPatchUpdateFileOperation" /> class.
        /// </summary>
        /// <param name="path">
        /// Path of the file to update.
        /// </param>
        /// <param name="diff">
        /// Diff to apply.
        /// </param>
        /// <param name="type">
        /// Update an existing file with the provided diff.<br/>
        /// Default Value: update_file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaApplyPatchUpdateFileOperation(
            string path,
            string diff,
            global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationType type = global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationType.UpdateFile)
        {
            this.Type = type;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Diff = diff ?? throw new global::System.ArgumentNullException(nameof(diff));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaApplyPatchUpdateFileOperation" /> class.
        /// </summary>
        public BetaApplyPatchUpdateFileOperation()
        {
        }

    }
}