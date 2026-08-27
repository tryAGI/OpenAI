
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DirectToolCallCallerParam
    {
        /// <summary>
        /// The caller type. Always `direct`.<br/>
        /// Default Value: direct
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DirectToolCallCallerParamType.Direct</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DirectToolCallCallerParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.DirectToolCallCallerParamType Type { get; set; } = global::tryAGI.OpenAI.DirectToolCallCallerParamType.Direct;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectToolCallCallerParam" /> class.
        /// </summary>
        /// <param name="type">
        /// The caller type. Always `direct`.<br/>
        /// Default Value: direct
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DirectToolCallCallerParam(
            global::tryAGI.OpenAI.DirectToolCallCallerParamType type = global::tryAGI.OpenAI.DirectToolCallCallerParamType.Direct)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectToolCallCallerParam" /> class.
        /// </summary>
        public DirectToolCallCallerParam()
        {
        }

    }
}