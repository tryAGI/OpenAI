
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaDirectToolCallCaller
    {
        /// <summary>
        /// Default Value: direct
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaDirectToolCallCallerType.Direct</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaDirectToolCallCallerTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaDirectToolCallCallerType Type { get; set; } = global::tryAGI.OpenAI.BetaDirectToolCallCallerType.Direct;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDirectToolCallCaller" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: direct
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDirectToolCallCaller(
            global::tryAGI.OpenAI.BetaDirectToolCallCallerType type = global::tryAGI.OpenAI.BetaDirectToolCallCallerType.Direct)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDirectToolCallCaller" /> class.
        /// </summary>
        public BetaDirectToolCallCaller()
        {
        }

    }
}