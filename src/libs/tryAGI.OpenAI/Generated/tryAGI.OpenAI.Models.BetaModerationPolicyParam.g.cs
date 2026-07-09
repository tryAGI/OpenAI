
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The policy to apply to moderated response input and output.
    /// </summary>
    public sealed partial class BetaModerationPolicyParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::tryAGI.OpenAI.BetaModerationConfigParam? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::tryAGI.OpenAI.BetaModerationConfigParam? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaModerationPolicyParam" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaModerationPolicyParam(
            global::tryAGI.OpenAI.BetaModerationConfigParam? input,
            global::tryAGI.OpenAI.BetaModerationConfigParam? output)
        {
            this.Input = input;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaModerationPolicyParam" /> class.
        /// </summary>
        public BetaModerationPolicyParam()
        {
        }

    }
}