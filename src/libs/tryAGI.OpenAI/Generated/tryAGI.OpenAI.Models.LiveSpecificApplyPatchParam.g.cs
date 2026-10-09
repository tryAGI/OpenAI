
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Forces the model to call the apply_patch tool when executing a tool call.
    /// </summary>
    public sealed partial class LiveSpecificApplyPatchParam
    {
        /// <summary>
        /// The tool to call. Always `apply_patch`.<br/>
        /// Default Value: apply_patch
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveSpecificApplyPatchParamType.ApplyPatch</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveSpecificApplyPatchParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveSpecificApplyPatchParamType Type { get; set; } = global::tryAGI.OpenAI.LiveSpecificApplyPatchParamType.ApplyPatch;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSpecificApplyPatchParam" /> class.
        /// </summary>
        /// <param name="type">
        /// The tool to call. Always `apply_patch`.<br/>
        /// Default Value: apply_patch
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSpecificApplyPatchParam(
            global::tryAGI.OpenAI.LiveSpecificApplyPatchParamType type = global::tryAGI.OpenAI.LiveSpecificApplyPatchParamType.ApplyPatch)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSpecificApplyPatchParam" /> class.
        /// </summary>
        public LiveSpecificApplyPatchParam()
        {
        }

    }
}