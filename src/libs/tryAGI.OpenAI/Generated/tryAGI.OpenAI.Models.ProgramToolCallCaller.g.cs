
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProgramToolCallCaller
    {
        /// <summary>
        /// Default Value: program
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ProgramToolCallCallerType.Program</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ProgramToolCallCallerTypeJsonConverter))]
        public global::tryAGI.OpenAI.ProgramToolCallCallerType Type { get; set; } = global::tryAGI.OpenAI.ProgramToolCallCallerType.Program;

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
        /// Initializes a new instance of the <see cref="ProgramToolCallCaller" /> class.
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
        public ProgramToolCallCaller(
            string callerId,
            global::tryAGI.OpenAI.ProgramToolCallCallerType type = global::tryAGI.OpenAI.ProgramToolCallCallerType.Program)
        {
            this.Type = type;
            this.CallerId = callerId ?? throw new global::System.ArgumentNullException(nameof(callerId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramToolCallCaller" /> class.
        /// </summary>
        public ProgramToolCallCaller()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ProgramToolCallCaller"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ProgramToolCallCaller FromCallerId(string callerId)
        {
            return new ProgramToolCallCaller
            {
                CallerId = callerId,
            };
        }

    }
}