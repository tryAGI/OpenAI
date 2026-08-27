
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DirectToolCallCaller
    {
        /// <summary>
        /// Default Value: direct
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DirectToolCallCallerType.Direct</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DirectToolCallCallerTypeJsonConverter))]
        public global::tryAGI.OpenAI.DirectToolCallCallerType Type { get; set; } = global::tryAGI.OpenAI.DirectToolCallCallerType.Direct;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectToolCallCaller" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: direct
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DirectToolCallCaller(
            global::tryAGI.OpenAI.DirectToolCallCallerType type = global::tryAGI.OpenAI.DirectToolCallCallerType.Direct)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectToolCallCaller" /> class.
        /// </summary>
        public DirectToolCallCaller()
        {
        }

    }
}