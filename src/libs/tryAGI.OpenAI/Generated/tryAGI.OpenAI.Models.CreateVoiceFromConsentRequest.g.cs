
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Creates a voice from a consent recording and an audio sample. Requires multipart/form-data.
    /// </summary>
    public sealed partial class CreateVoiceFromConsentRequest
    {
        /// <summary>
        /// The voice creation method. Defaults to `audio_sample` when omitted.<br/>
        /// Default Value: audio_sample
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateVoiceFromConsentRequestTypeJsonConverter))]
        public global::tryAGI.OpenAI.CreateVoiceFromConsentRequestType? Type { get; set; }

        /// <summary>
        /// The name of the new voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The sample audio recording file. Maximum size is 10 MiB.<br/>
        /// Supported MIME types:<br/>
        /// `audio/mpeg`, `audio/wav`, `audio/x-wav`, `audio/ogg`, `audio/aac`, `audio/flac`, `audio/webm`, `audio/mp4`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_sample")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] AudioSample { get; set; }

        /// <summary>
        /// The sample audio recording file. Maximum size is 10 MiB.<br/>
        /// Supported MIME types:<br/>
        /// `audio/mpeg`, `audio/wav`, `audio/x-wav`, `audio/ogg`, `audio/aac`, `audio/flac`, `audio/webm`, `audio/mp4`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_samplename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioSamplename { get; set; }

        /// <summary>
        /// The consent recording ID (for example, `cons_1234`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Consent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoiceFromConsentRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the new voice.
        /// </param>
        /// <param name="audioSample">
        /// The sample audio recording file. Maximum size is 10 MiB.<br/>
        /// Supported MIME types:<br/>
        /// `audio/mpeg`, `audio/wav`, `audio/x-wav`, `audio/ogg`, `audio/aac`, `audio/flac`, `audio/webm`, `audio/mp4`.
        /// </param>
        /// <param name="audioSamplename">
        /// The sample audio recording file. Maximum size is 10 MiB.<br/>
        /// Supported MIME types:<br/>
        /// `audio/mpeg`, `audio/wav`, `audio/x-wav`, `audio/ogg`, `audio/aac`, `audio/flac`, `audio/webm`, `audio/mp4`.
        /// </param>
        /// <param name="consent">
        /// The consent recording ID (for example, `cons_1234`).
        /// </param>
        /// <param name="type">
        /// The voice creation method. Defaults to `audio_sample` when omitted.<br/>
        /// Default Value: audio_sample
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVoiceFromConsentRequest(
            string name,
            byte[] audioSample,
            string audioSamplename,
            string consent,
            global::tryAGI.OpenAI.CreateVoiceFromConsentRequestType? type)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AudioSample = audioSample ?? throw new global::System.ArgumentNullException(nameof(audioSample));
            this.AudioSamplename = audioSamplename ?? throw new global::System.ArgumentNullException(nameof(audioSamplename));
            this.Consent = consent ?? throw new global::System.ArgumentNullException(nameof(consent));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoiceFromConsentRequest" /> class.
        /// </summary>
        public CreateVoiceFromConsentRequest()
        {
        }

    }
}