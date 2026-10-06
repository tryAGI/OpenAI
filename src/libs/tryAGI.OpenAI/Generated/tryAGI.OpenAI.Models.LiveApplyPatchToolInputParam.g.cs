
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveApplyPatchToolInputParam
    {
        /// <summary>
        /// Default Value: apply_patch
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveApplyPatchToolInputParamType.ApplyPatch</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveApplyPatchToolInputParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveApplyPatchToolInputParamType Type { get; set; } = global::tryAGI.OpenAI.LiveApplyPatchToolInputParamType.ApplyPatch;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveApplyPatchToolInputParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: apply_patch
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveApplyPatchToolInputParam(
            global::tryAGI.OpenAI.LiveApplyPatchToolInputParamType type = global::tryAGI.OpenAI.LiveApplyPatchToolInputParamType.ApplyPatch)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveApplyPatchToolInputParam" /> class.
        /// </summary>
        public LiveApplyPatchToolInputParam()
        {
        }

    }
}