
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Indicates that the shell call exceeded its configured time limit.
    /// </summary>
    public sealed partial class FunctionShellCallOutputTimeoutOutcomeParam
    {
        /// <summary>
        /// The outcome type. Always `timeout`.<br/>
        /// Default Value: timeout
        /// </summary>
        /// <default>global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParamType.Timeout</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputTimeoutOutcomeParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParamType Type { get; set; } = global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParamType.Timeout;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionShellCallOutputTimeoutOutcomeParam" /> class.
        /// </summary>
        /// <param name="type">
        /// The outcome type. Always `timeout`.<br/>
        /// Default Value: timeout
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionShellCallOutputTimeoutOutcomeParam(
            global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParamType type = global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParamType.Timeout)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionShellCallOutputTimeoutOutcomeParam" /> class.
        /// </summary>
        public FunctionShellCallOutputTimeoutOutcomeParam()
        {
        }
    }
}