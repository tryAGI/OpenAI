
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Indicates that the shell call exceeded its configured time limit.
    /// </summary>
    public sealed partial class BetaFunctionShellCallOutputTimeoutOutcome
    {
        /// <summary>
        /// The outcome type. Always `timeout`.<br/>
        /// Default Value: timeout
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeType.Timeout</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputTimeoutOutcomeTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeType Type { get; set; } = global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeType.Timeout;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFunctionShellCallOutputTimeoutOutcome" /> class.
        /// </summary>
        /// <param name="type">
        /// The outcome type. Always `timeout`.<br/>
        /// Default Value: timeout
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaFunctionShellCallOutputTimeoutOutcome(
            global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeType type = global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeType.Timeout)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFunctionShellCallOutputTimeoutOutcome" /> class.
        /// </summary>
        public BetaFunctionShellCallOutputTimeoutOutcome()
        {
        }

    }
}