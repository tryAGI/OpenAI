
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Allows the assistant to create, delete, or update files using unified diffs.
    /// </summary>
    public sealed partial class ApplyPatchToolParam
    {
        /// <summary>
        /// The type of the tool. Always `apply_patch`.<br/>
        /// Default Value: apply_patch
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ApplyPatchToolParamType.ApplyPatch</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.ApplyPatchToolParamType Type { get; set; } = global::tryAGI.OpenAI.ApplyPatchToolParamType.ApplyPatch;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_callers")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CallableToolAllowedCaller>? AllowedCallers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchToolParam" /> class.
        /// </summary>
        /// <param name="allowedCallers"></param>
        /// <param name="type">
        /// The type of the tool. Always `apply_patch`.<br/>
        /// Default Value: apply_patch
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApplyPatchToolParam(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CallableToolAllowedCaller>? allowedCallers,
            global::tryAGI.OpenAI.ApplyPatchToolParamType type = global::tryAGI.OpenAI.ApplyPatchToolParamType.ApplyPatch)
        {
            this.Type = type;
            this.AllowedCallers = allowedCallers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchToolParam" /> class.
        /// </summary>
        public ApplyPatchToolParam()
        {
        }

    }
}