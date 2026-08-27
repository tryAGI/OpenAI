
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaProgramToolCallCallerParam
    {
        /// <summary>
        /// The caller type. Always `program`.<br/>
        /// Default Value: program
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaProgramToolCallCallerParamType.Program</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaProgramToolCallCallerParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaProgramToolCallCallerParamType Type { get; set; } = global::tryAGI.OpenAI.BetaProgramToolCallCallerParamType.Program;

        /// <summary>
        /// The call ID of the program item that produced this tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caller_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaProgramToolCallCallerParam" /> class.
        /// </summary>
        /// <param name="callerId">
        /// The call ID of the program item that produced this tool call.
        /// </param>
        /// <param name="type">
        /// The caller type. Always `program`.<br/>
        /// Default Value: program
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaProgramToolCallCallerParam(
            string callerId,
            global::tryAGI.OpenAI.BetaProgramToolCallCallerParamType type = global::tryAGI.OpenAI.BetaProgramToolCallCallerParamType.Program)
        {
            this.Type = type;
            this.CallerId = callerId ?? throw new global::System.ArgumentNullException(nameof(callerId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaProgramToolCallCallerParam" /> class.
        /// </summary>
        public BetaProgramToolCallCallerParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaProgramToolCallCallerParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaProgramToolCallCallerParam FromCallerId(string callerId)
        {
            return new BetaProgramToolCallCallerParam
            {
                CallerId = callerId,
            };
        }

    }
}