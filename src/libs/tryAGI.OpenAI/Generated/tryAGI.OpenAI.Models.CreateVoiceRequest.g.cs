
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVoiceRequest
    {
        /// <summary>
        /// The name of the new voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The sample audio recording file. Maximum size is 10 MiB.<br/>
        /// Supported MIME types:<br/>
        /// `audio/mpeg`, `audio/wav`, `audio/x-wav`, `audio/ogg`, `audio/aac`, `audio/flac`, `audio/webm`, `audio/mp4`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_sample")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public byte[] AudioSample { get; set; } = default!;

        /// <summary>
        /// The sample audio recording file. Maximum size is 10 MiB.<br/>
        /// Supported MIME types:<br/>
        /// `audio/mpeg`, `audio/wav`, `audio/x-wav`, `audio/ogg`, `audio/aac`, `audio/flac`, `audio/webm`, `audio/mp4`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_samplename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string AudioSamplename { get; set; } = default!;

        /// <summary>
        /// The consent recording ID (for example, `cons_1234`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Consent { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoiceRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVoiceRequest(
            string name,
            byte[] audioSample,
            string audioSamplename,
            string consent)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AudioSample = audioSample ?? throw new global::System.ArgumentNullException(nameof(audioSample));
            this.AudioSamplename = audioSamplename ?? throw new global::System.ArgumentNullException(nameof(audioSamplename));
            this.Consent = consent ?? throw new global::System.ArgumentNullException(nameof(consent));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoiceRequest" /> class.
        /// </summary>
        public CreateVoiceRequest()
        {
        }
    }
}