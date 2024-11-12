
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// A session refers to a single WebSocket connection between a client and the server.<br/>
    /// Once a client creates a session, it then sends JSON-formatted events containing text and audio chunks.<br/>
    /// The server will respond in kind with audio containing voice output, a text transcript of that voice output,<br/>
    /// and function calls (if functions are provided by the client).<br/>
    /// A realtime Session represents the overall client-server interaction, and contains default configuration.<br/>
    /// It has a set of default values which can be updated at any time (via session.update) or on a per-response level (via response.create).
    /// </summary>
    public sealed partial class RealtimeSession
    {
        /// <summary>
        /// The unique ID of the session.<br/>
        /// Example: sess_001
        /// </summary>
        /// <example>sess_001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The object type, must be "realtime.session".<br/>
        /// Example: realtime.session
        /// </summary>
        /// <example>realtime.session</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.RealtimeSessionObjectJsonConverter))]
        public global::OpenAI.RealtimeSessionObject? Object { get; set; }

        /// <summary>
        /// The default model used for this session.<br/>
        /// Example: gpt-4o-realtime-preview-2024-10-01
        /// </summary>
        /// <example>gpt-4o-realtime-preview-2024-10-01</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The set of modalities the model can respond with. To disable audio, set this to ["text"].<br/>
        /// Example: [text, audio]
        /// </summary>
        /// <example>[text, audio]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        public global::System.Collections.Generic.IList<string>? Modalities { get; set; }

        /// <summary>
        /// The default system instructions prepended to model calls.<br/>
        /// Example: Your knowledge cutoff is 2023-10. You are a helpful assistant.
        /// </summary>
        /// <example>Your knowledge cutoff is 2023-10. You are a helpful assistant.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// The voice the model uses to respond. Cannot be changed once the model has responded with audio at least once.<br/>
        /// Example: alloy
        /// </summary>
        /// <example>alloy</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.RealtimeSessionVoiceJsonConverter))]
        public global::OpenAI.RealtimeSessionVoice? Voice { get; set; }

        /// <summary>
        /// The format of input/output audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.RealtimeAudioFormatJsonConverter))]
        public global::OpenAI.RealtimeAudioFormat? InputAudioFormat { get; set; }

        /// <summary>
        /// The format of input/output audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_audio_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.RealtimeAudioFormatJsonConverter))]
        public global::OpenAI.RealtimeAudioFormat? OutputAudioFormat { get; set; }

        /// <summary>
        /// Configuration for input audio transcription. Can be set to null to turn off.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_transcription")]
        public global::OpenAI.RealtimeSessionInputAudioTranscription? InputAudioTranscription { get; set; }

        /// <summary>
        /// Configuration for turn detection. Can be set to null to turn off.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_detection")]
        public global::OpenAI.RealtimeSessionTurnDetection? TurnDetection { get; set; }

        /// <summary>
        /// Tools (functions) available to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::OpenAI.RealtimeSessionTool>? Tools { get; set; }

        /// <summary>
        /// How the model chooses tools.<br/>
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.RealtimeSessionToolChoiceJsonConverter))]
        public global::OpenAI.RealtimeSessionToolChoice? ToolChoice { get; set; }

        /// <summary>
        /// Sampling temperature for the model.<br/>
        /// Example: 0.8
        /// </summary>
        /// <example>0.8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Maximum number of output tokens for a single assistant response, inclusive of tool calls. Provide an integer between 1 and 4096 to limit output tokens, or "inf" for the maximum available tokens for a given model. Defaults to "inf".<br/>
        /// Default Value: inf
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.OneOfJsonConverterFactory2))]
        public global::OpenAI.OneOf<int?, global::OpenAI.RealtimeSessionMaxOutputTokens?>? MaxOutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSession" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the session.<br/>
        /// Example: sess_001
        /// </param>
        /// <param name="object">
        /// The object type, must be "realtime.session".<br/>
        /// Example: realtime.session
        /// </param>
        /// <param name="model">
        /// The default model used for this session.<br/>
        /// Example: gpt-4o-realtime-preview-2024-10-01
        /// </param>
        /// <param name="modalities">
        /// The set of modalities the model can respond with. To disable audio, set this to ["text"].<br/>
        /// Example: [text, audio]
        /// </param>
        /// <param name="instructions">
        /// The default system instructions prepended to model calls.<br/>
        /// Example: Your knowledge cutoff is 2023-10. You are a helpful assistant.
        /// </param>
        /// <param name="voice">
        /// The voice the model uses to respond. Cannot be changed once the model has responded with audio at least once.<br/>
        /// Example: alloy
        /// </param>
        /// <param name="inputAudioFormat">
        /// The format of input/output audio.
        /// </param>
        /// <param name="outputAudioFormat">
        /// The format of input/output audio.
        /// </param>
        /// <param name="inputAudioTranscription">
        /// Configuration for input audio transcription. Can be set to null to turn off.
        /// </param>
        /// <param name="turnDetection">
        /// Configuration for turn detection. Can be set to null to turn off.
        /// </param>
        /// <param name="tools">
        /// Tools (functions) available to the model.
        /// </param>
        /// <param name="toolChoice">
        /// How the model chooses tools.<br/>
        /// Example: auto
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature for the model.<br/>
        /// Example: 0.8
        /// </param>
        /// <param name="maxOutputTokens">
        /// Maximum number of output tokens for a single assistant response, inclusive of tool calls. Provide an integer between 1 and 4096 to limit output tokens, or "inf" for the maximum available tokens for a given model. Defaults to "inf".<br/>
        /// Default Value: inf
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeSession(
            string? id,
            global::OpenAI.RealtimeSessionObject? @object,
            string? model,
            global::System.Collections.Generic.IList<string>? modalities,
            string? instructions,
            global::OpenAI.RealtimeSessionVoice? voice,
            global::OpenAI.RealtimeAudioFormat? inputAudioFormat,
            global::OpenAI.RealtimeAudioFormat? outputAudioFormat,
            global::OpenAI.RealtimeSessionInputAudioTranscription? inputAudioTranscription,
            global::OpenAI.RealtimeSessionTurnDetection? turnDetection,
            global::System.Collections.Generic.IList<global::OpenAI.RealtimeSessionTool>? tools,
            global::OpenAI.RealtimeSessionToolChoice? toolChoice,
            double? temperature,
            global::OpenAI.OneOf<int?, global::OpenAI.RealtimeSessionMaxOutputTokens?>? maxOutputTokens)
        {
            this.Id = id;
            this.Object = @object;
            this.Model = model;
            this.Modalities = modalities;
            this.Instructions = instructions;
            this.Voice = voice;
            this.InputAudioFormat = inputAudioFormat;
            this.OutputAudioFormat = outputAudioFormat;
            this.InputAudioTranscription = inputAudioTranscription;
            this.TurnDetection = turnDetection;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Temperature = temperature;
            this.MaxOutputTokens = maxOutputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSession" /> class.
        /// </summary>
        public RealtimeSession()
        {
        }
    }
}