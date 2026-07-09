
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProgramOutput
    {
        /// <summary>
        /// The type of the item. Always `program_output`.<br/>
        /// Default Value: program_output
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ProgramOutputType.ProgramOutput</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ProgramOutputTypeJsonConverter))]
        public global::tryAGI.OpenAI.ProgramOutputType Type { get; set; } = global::tryAGI.OpenAI.ProgramOutputType.ProgramOutput;

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ProgramOutputStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ProgramOutputStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramOutput" /> class.
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
        /// <param name="type">
        /// The type of the item. Always `program_output`.<br/>
        /// Default Value: program_output
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProgramOutput(
            string id,
            string callId,
            string result,
            global::tryAGI.OpenAI.ProgramOutputStatus status,
            global::tryAGI.OpenAI.ProgramOutputType type = global::tryAGI.OpenAI.ProgramOutputType.ProgramOutput)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramOutput" /> class.
        /// </summary>
        public ProgramOutput()
        {
        }

    }
}