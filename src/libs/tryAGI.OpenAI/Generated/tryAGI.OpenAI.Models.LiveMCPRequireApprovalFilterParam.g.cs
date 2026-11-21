
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveMCPRequireApprovalFilterParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("always")]
        public global::tryAGI.OpenAI.LiveMCPToolFilterParam? Always { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("never")]
        public global::tryAGI.OpenAI.LiveMCPToolFilterParam? Never { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveMCPRequireApprovalFilterParam" /> class.
        /// </summary>
        /// <param name="always"></param>
        /// <param name="never"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveMCPRequireApprovalFilterParam(
            global::tryAGI.OpenAI.LiveMCPToolFilterParam? always,
            global::tryAGI.OpenAI.LiveMCPToolFilterParam? never)
        {
            this.Always = always;
            this.Never = never;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveMCPRequireApprovalFilterParam" /> class.
        /// </summary>
        public LiveMCPRequireApprovalFilterParam()
        {
        }

    }
}