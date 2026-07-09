
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Program
    {
        /// <summary>
        /// The type of the item. Always `program`.<br/>
        /// Default Value: program
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ProgramType.Program</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ProgramTypeJsonConverter))]
        public global::tryAGI.OpenAI.ProgramType Type { get; set; } = global::tryAGI.OpenAI.ProgramType.Program;

        /// <summary>
        /// The unique ID of the program item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The stable call ID of the program item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// The JavaScript source executed by programmatic tool calling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Opaque program replay fingerprint that must be round-tripped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fingerprint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Fingerprint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Program" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the program item.
        /// </param>
        /// <param name="callId">
        /// The stable call ID of the program item.
        /// </param>
        /// <param name="code">
        /// The JavaScript source executed by programmatic tool calling.
        /// </param>
        /// <param name="fingerprint">
        /// Opaque program replay fingerprint that must be round-tripped.
        /// </param>
        /// <param name="type">
        /// The type of the item. Always `program`.<br/>
        /// Default Value: program
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Program(
            string id,
            string callId,
            string code,
            string fingerprint,
            global::tryAGI.OpenAI.ProgramType type = global::tryAGI.OpenAI.ProgramType.Program)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Fingerprint = fingerprint ?? throw new global::System.ArgumentNullException(nameof(fingerprint));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Program" /> class.
        /// </summary>
        public Program()
        {
        }

    }
}