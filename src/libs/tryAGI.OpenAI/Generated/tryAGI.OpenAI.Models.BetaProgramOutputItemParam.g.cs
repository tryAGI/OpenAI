
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaProgramOutputItemParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTagParam? Agent { get; set; }

        /// <summary>
        /// The unique ID of this program output item.<br/>
        /// Example: cmo_123
        /// </summary>
        /// <example>cmo_123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The item type. Always `program_output`.<br/>
        /// Default Value: program_output
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaProgramOutputItemParamType.ProgramOutput</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaProgramOutputItemParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaProgramOutputItemParamType Type { get; set; } = global::tryAGI.OpenAI.BetaProgramOutputItemParamType.ProgramOutput;

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
        /// The terminal status of the program output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaProgramOutputItemStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaProgramOutputItemStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaProgramOutputItemParam" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of this program output item.<br/>
        /// Example: cmo_123
        /// </param>
        /// <param name="callId">
        /// The call ID of the program item.
        /// </param>
        /// <param name="result">
        /// The result produced by the program item.
        /// </param>
        /// <param name="status">
        /// The terminal status of the program output.
        /// </param>
        /// <param name="agent"></param>
        /// <param name="type">
        /// The item type. Always `program_output`.<br/>
        /// Default Value: program_output
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaProgramOutputItemParam(
            string id,
            string callId,
            string result,
            global::tryAGI.OpenAI.BetaProgramOutputItemStatus status,
            global::tryAGI.OpenAI.BetaAgentTagParam? agent,
            global::tryAGI.OpenAI.BetaProgramOutputItemParamType type = global::tryAGI.OpenAI.BetaProgramOutputItemParamType.ProgramOutput)
        {
            this.Agent = agent;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaProgramOutputItemParam" /> class.
        /// </summary>
        public BetaProgramOutputItemParam()
        {
        }

    }
}