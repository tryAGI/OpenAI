
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CSAMCategoryAppliedInputTypes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("likely-csam")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> LikelyCsam { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("likely-csam/gen-ai")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> LikelyCsamGenAi { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CSAMCategoryAppliedInputTypes" /> class.
        /// </summary>
        /// <param name="likelyCsam"></param>
        /// <param name="likelyCsamGenAi"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CSAMCategoryAppliedInputTypes(
            global::System.Collections.Generic.IList<string> likelyCsam,
            global::System.Collections.Generic.IList<string> likelyCsamGenAi)
        {
            this.LikelyCsam = likelyCsam ?? throw new global::System.ArgumentNullException(nameof(likelyCsam));
            this.LikelyCsamGenAi = likelyCsamGenAi ?? throw new global::System.ArgumentNullException(nameof(likelyCsamGenAi));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CSAMCategoryAppliedInputTypes" /> class.
        /// </summary>
        public CSAMCategoryAppliedInputTypes()
        {
        }

    }
}