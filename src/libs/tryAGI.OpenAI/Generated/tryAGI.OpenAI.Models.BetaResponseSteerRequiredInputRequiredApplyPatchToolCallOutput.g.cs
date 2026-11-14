
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Supply `status` and optional `output` using the apply patch tool call<br/>
    /// output input schema.
    /// </summary>
    public sealed partial class BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"apply_patch_call_output"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "apply_patch_call_output";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput(
            string callId,
            string type = "apply_patch_call_output")
        {
            this.Type = type;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput" /> class.
        /// </summary>
        public BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput FromCallId(string callId)
        {
            return new BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput
            {
                CallId = callId,
            };
        }

    }
}