
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProgramOutputItemParam
    {
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
        /// <default>global::tryAGI.OpenAI.ProgramOutputItemParamType.ProgramOutput</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ProgramOutputItemParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.ProgramOutputItemParamType Type { get; set; } = global::tryAGI.OpenAI.ProgramOutputItemParamType.ProgramOutput;

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ProgramOutputItemStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ProgramOutputItemStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramOutputItemParam" /> class.
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
        /// <param name="type">
        /// The item type. Always `program_output`.<br/>
        /// Default Value: program_output
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProgramOutputItemParam(
            string id,
            string callId,
            string result,
            global::tryAGI.OpenAI.ProgramOutputItemStatus status,
            global::tryAGI.OpenAI.ProgramOutputItemParamType type = global::tryAGI.OpenAI.ProgramOutputItemParamType.ProgramOutput)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramOutputItemParam" /> class.
        /// </summary>
        public ProgramOutputItemParam()
        {
        }

    }
}