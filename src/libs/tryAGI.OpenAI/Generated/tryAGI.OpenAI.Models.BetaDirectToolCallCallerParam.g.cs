
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaDirectToolCallCallerParam
    {
        /// <summary>
        /// The caller type. Always `direct`.<br/>
        /// Default Value: direct
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaDirectToolCallCallerParamType.Direct</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaDirectToolCallCallerParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaDirectToolCallCallerParamType Type { get; set; } = global::tryAGI.OpenAI.BetaDirectToolCallCallerParamType.Direct;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDirectToolCallCallerParam" /> class.
        /// </summary>
        /// <param name="type">
        /// The caller type. Always `direct`.<br/>
        /// Default Value: direct
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDirectToolCallCallerParam(
            global::tryAGI.OpenAI.BetaDirectToolCallCallerParamType type = global::tryAGI.OpenAI.BetaDirectToolCallCallerParamType.Direct)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDirectToolCallCallerParam" /> class.
        /// </summary>
        public BetaDirectToolCallCallerParam()
        {
        }

    }
}