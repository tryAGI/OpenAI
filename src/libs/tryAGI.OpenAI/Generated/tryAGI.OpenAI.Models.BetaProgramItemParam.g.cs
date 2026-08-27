
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaProgramItemParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTagParam? Agent { get; set; }

        /// <summary>
        /// The unique ID of this program item.<br/>
        /// Example: cm_123
        /// </summary>
        /// <example>cm_123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The item type. Always `program`.<br/>
        /// Default Value: program
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaProgramItemParamType.Program</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaProgramItemParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaProgramItemParamType Type { get; set; } = global::tryAGI.OpenAI.BetaProgramItemParamType.Program;

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
        /// Initializes a new instance of the <see cref="BetaProgramItemParam" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of this program item.<br/>
        /// Example: cm_123
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
        /// <param name="agent"></param>
        /// <param name="type">
        /// The item type. Always `program`.<br/>
        /// Default Value: program
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaProgramItemParam(
            string id,
            string callId,
            string code,
            string fingerprint,
            global::tryAGI.OpenAI.BetaAgentTagParam? agent,
            global::tryAGI.OpenAI.BetaProgramItemParamType type = global::tryAGI.OpenAI.BetaProgramItemParamType.Program)
        {
            this.Agent = agent;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Fingerprint = fingerprint ?? throw new global::System.ArgumentNullException(nameof(fingerprint));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaProgramItemParam" /> class.
        /// </summary>
        public BetaProgramItemParam()
        {
        }

    }
}