
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Configuration for the response.
    /// </summary>
    public sealed partial class RealtimeResponseCreateResponse
    {
        /// <summary>
        /// The modalities for the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        public global::System.Collections.Generic.IList<global::OpenAI.RealtimeResponseCreateResponseModalitie>? Modalities { get; set; }

        /// <summary>
        /// Instructions for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// The voice the model uses to respond.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.RealtimeResponseCreateResponseVoiceJsonConverter))]
        public global::OpenAI.RealtimeResponseCreateResponseVoice? Voice { get; set; }

        /// <summary>
        /// The format of input/output audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_audio_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.RealtimeAudioFormatJsonConverter))]
        public global::OpenAI.RealtimeAudioFormat? OutputAudioFormat { get; set; }

        /// <summary>
        /// Tools (functions) available to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::OpenAI.RealtimeResponseCreateResponseTool>? Tools { get; set; }

        /// <summary>
        /// How the model chooses tools. <br/>
        /// Options are "auto", "none", "required", or specify a function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.OneOfJsonConverter<global::OpenAI.RealtimeResponseCreateResponseToolChoice?, string>))]
        public global::OpenAI.OneOf<global::OpenAI.RealtimeResponseCreateResponseToolChoice?, string>? ToolChoice { get; set; }

        /// <summary>
        /// Sampling temperature.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Maximum number of output tokens for a single assistant response, inclusive of tool calls. Provide an integer between 1 and 4096 to limit output tokens, or "inf" for the maximum available tokens for a given model. Defaults to "inf".<br/>
        /// Default Value: inf
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.OneOfJsonConverter<int?, global::OpenAI.RealtimeResponseCreateResponseMaxOutputTokens?>))]
        public global::OpenAI.OneOf<int?, global::OpenAI.RealtimeResponseCreateResponseMaxOutputTokens?>? MaxOutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseCreateResponse" /> class.
        /// </summary>
        /// <param name="modalities">
        /// The modalities for the response.
        /// </param>
        /// <param name="instructions">
        /// Instructions for the model.
        /// </param>
        /// <param name="voice">
        /// The voice the model uses to respond.
        /// </param>
        /// <param name="outputAudioFormat">
        /// The format of input/output audio.
        /// </param>
        /// <param name="tools">
        /// Tools (functions) available to the model.
        /// </param>
        /// <param name="toolChoice">
        /// How the model chooses tools. <br/>
        /// Options are "auto", "none", "required", or specify a function.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature.
        /// </param>
        /// <param name="maxOutputTokens">
        /// Maximum number of output tokens for a single assistant response, inclusive of tool calls. Provide an integer between 1 and 4096 to limit output tokens, or "inf" for the maximum available tokens for a given model. Defaults to "inf".<br/>
        /// Default Value: inf
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeResponseCreateResponse(
            global::System.Collections.Generic.IList<global::OpenAI.RealtimeResponseCreateResponseModalitie>? modalities,
            string? instructions,
            global::OpenAI.RealtimeResponseCreateResponseVoice? voice,
            global::OpenAI.RealtimeAudioFormat? outputAudioFormat,
            global::System.Collections.Generic.IList<global::OpenAI.RealtimeResponseCreateResponseTool>? tools,
            global::OpenAI.OneOf<global::OpenAI.RealtimeResponseCreateResponseToolChoice?, string>? toolChoice,
            double? temperature,
            global::OpenAI.OneOf<int?, global::OpenAI.RealtimeResponseCreateResponseMaxOutputTokens?>? maxOutputTokens)
        {
            this.Modalities = modalities;
            this.Instructions = instructions;
            this.Voice = voice;
            this.OutputAudioFormat = outputAudioFormat;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Temperature = temperature;
            this.MaxOutputTokens = maxOutputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseCreateResponse" /> class.
        /// </summary>
        public RealtimeResponseCreateResponse()
        {
        }
    }
}