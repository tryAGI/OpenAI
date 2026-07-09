
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaProgramOutput
    {
        /// <summary>
        /// The agent that produced this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTag? Agent { get; set; }

        /// <summary>
        /// The type of the item. Always `program_output`.<br/>
        /// Default Value: program_output
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaProgramOutputType.ProgramOutput</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaProgramOutputTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaProgramOutputType Type { get; set; } = global::tryAGI.OpenAI.BetaProgramOutputType.ProgramOutput;

        /// <summary>
        /// The unique ID of the program output item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The call ID of the program item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// The result produced by the program item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Result { get; set; }

        /// <summary>
        /// The terminal status of the program output item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaProgramOutputStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaProgramOutputStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaProgramOutput" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the program output item.
        /// </param>
        /// <param name="callId">
        /// The call ID of the program item.
        /// </param>
        /// <param name="result">
        /// The result produced by the program item.
        /// </param>
        /// <param name="status">
        /// The terminal status of the program output item.
        /// </param>
        /// <param name="agent">
        /// The agent that produced this item.
        /// </param>
        /// <param name="type">
        /// The type of the item. Always `program_output`.<br/>
        /// Default Value: program_output
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaProgramOutput(
            string id,
            string callId,
            string result,
            global::tryAGI.OpenAI.BetaProgramOutputStatus status,
            global::tryAGI.OpenAI.BetaAgentTag? agent,
            global::tryAGI.OpenAI.BetaProgramOutputType type = global::tryAGI.OpenAI.BetaProgramOutputType.ProgramOutput)
        {
            this.Agent = agent;
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaProgramOutput" /> class.
        /// </summary>
        public BetaProgramOutput()
        {
        }

    }
}