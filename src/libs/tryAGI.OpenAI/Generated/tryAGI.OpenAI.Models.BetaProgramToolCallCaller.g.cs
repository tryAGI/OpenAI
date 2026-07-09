
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaProgramToolCallCaller
    {
        /// <summary>
        /// Default Value: program
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaProgramToolCallCallerType.Program</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaProgramToolCallCallerTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaProgramToolCallCallerType Type { get; set; } = global::tryAGI.OpenAI.BetaProgramToolCallCallerType.Program;

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
        /// Initializes a new instance of the <see cref="BetaProgramToolCallCaller" /> class.
        /// </summary>
        /// <param name="callerId">
        /// The call ID of the program item that produced this tool call.
        /// </param>
        /// <param name="type">
        /// Default Value: program
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaProgramToolCallCaller(
            string callerId,
            global::tryAGI.OpenAI.BetaProgramToolCallCallerType type = global::tryAGI.OpenAI.BetaProgramToolCallCallerType.Program)
        {
            this.Type = type;
            this.CallerId = callerId ?? throw new global::System.ArgumentNullException(nameof(callerId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaProgramToolCallCaller" /> class.
        /// </summary>
        public BetaProgramToolCallCaller()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaProgramToolCallCaller"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaProgramToolCallCaller FromCallerId(string callerId)
        {
            return new BetaProgramToolCallCaller
            {
                CallerId = callerId,
            };
        }

    }
}