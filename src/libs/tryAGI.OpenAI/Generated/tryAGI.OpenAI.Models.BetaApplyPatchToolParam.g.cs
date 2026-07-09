
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Allows the assistant to create, delete, or update files using unified diffs.
    /// </summary>
    public sealed partial class BetaApplyPatchToolParam
    {
        /// <summary>
        /// The type of the tool. Always `apply_patch`.<br/>
        /// Default Value: apply_patch
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaApplyPatchToolParamType.ApplyPatch</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchToolParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaApplyPatchToolParamType Type { get; set; } = global::tryAGI.OpenAI.BetaApplyPatchToolParamType.ApplyPatch;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_callers")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCallableToolAllowedCaller>? AllowedCallers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaApplyPatchToolParam" /> class.
        /// </summary>
        /// <param name="allowedCallers"></param>
        /// <param name="type">
        /// The type of the tool. Always `apply_patch`.<br/>
        /// Default Value: apply_patch
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaApplyPatchToolParam(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCallableToolAllowedCaller>? allowedCallers,
            global::tryAGI.OpenAI.BetaApplyPatchToolParamType type = global::tryAGI.OpenAI.BetaApplyPatchToolParamType.ApplyPatch)
        {
            this.Type = type;
            this.AllowedCallers = allowedCallers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaApplyPatchToolParam" /> class.
        /// </summary>
        public BetaApplyPatchToolParam()
        {
        }

    }
}