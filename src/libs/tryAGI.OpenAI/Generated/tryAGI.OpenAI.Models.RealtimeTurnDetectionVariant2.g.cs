
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Server-side semantic turn detection which uses a model to determine when the user has finished speaking.
    /// </summary>
    public sealed partial class RealtimeTurnDetectionVariant2
    {
        /// <summary>
        /// Whether or not to automatically generate a response when a VAD stop event occurs.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_response")]
        public bool? CreateResponse { get; set; }

        /// <summary>
        /// Used only for `semantic_vad` mode. The eagerness of the model to respond. `low` will wait longer for the user to continue speaking, `high` will respond more quickly. `auto` is the default and is equivalent to `medium`. `low`, `medium`, and `high` have max timeouts of 8s, 4s, and 2s respectively.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eagerness")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTurnDetectionVariant2EagernessJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeTurnDetectionVariant2Eagerness? Eagerness { get; set; }

        /// <summary>
        /// Whether or not to automatically interrupt any ongoing response with output to the default<br/>
        /// conversation (i.e. `conversation` of `auto`) when a VAD start event occurs.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interrupt_response")]
        public bool? InterruptResponse { get; set; }

        /// <summary>
        /// Type of turn detection, `semantic_vad` to turn on Semantic VAD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTurnDetectionVariant2TypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeTurnDetectionVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTurnDetectionVariant2" /> class.
        /// </summary>
        /// <param name="createResponse">
        /// Whether or not to automatically generate a response when a VAD stop event occurs.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="eagerness">
        /// Used only for `semantic_vad` mode. The eagerness of the model to respond. `low` will wait longer for the user to continue speaking, `high` will respond more quickly. `auto` is the default and is equivalent to `medium`. `low`, `medium`, and `high` have max timeouts of 8s, 4s, and 2s respectively.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="interruptResponse">
        /// Whether or not to automatically interrupt any ongoing response with output to the default<br/>
        /// conversation (i.e. `conversation` of `auto`) when a VAD start event occurs.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="type">
        /// Type of turn detection, `semantic_vad` to turn on Semantic VAD.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTurnDetectionVariant2(
            bool? createResponse,
            global::tryAGI.OpenAI.RealtimeTurnDetectionVariant2Eagerness? eagerness,
            bool? interruptResponse,
            global::tryAGI.OpenAI.RealtimeTurnDetectionVariant2Type type)
        {
            this.CreateResponse = createResponse;
            this.Eagerness = eagerness;
            this.InterruptResponse = interruptResponse;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTurnDetectionVariant2" /> class.
        /// </summary>
        public RealtimeTurnDetectionVariant2()
        {
        }
    }
}