
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVoiceConsentRequest
    {
        /// <summary>
        /// The label to use for this consent recording.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The consent audio recording file. Maximum size is 10 MiB.<br/>
        /// Supported MIME types:<br/>
        /// `audio/mpeg`, `audio/wav`, `audio/x-wav`, `audio/ogg`, `audio/aac`, `audio/flac`, `audio/webm`, `audio/mp4`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recording")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Recording { get; set; }

        /// <summary>
        /// The consent audio recording file. Maximum size is 10 MiB.<br/>
        /// Supported MIME types:<br/>
        /// `audio/mpeg`, `audio/wav`, `audio/x-wav`, `audio/ogg`, `audio/aac`, `audio/flac`, `audio/webm`, `audio/mp4`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recordingname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Recordingname { get; set; }

        /// <summary>
        /// The BCP 47 language tag for the consent phrase (for example, `en-US`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoiceConsentRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The label to use for this consent recording.
        /// </param>
        /// <param name="recording">
        /// The consent audio recording file. Maximum size is 10 MiB.<br/>
        /// Supported MIME types:<br/>
        /// `audio/mpeg`, `audio/wav`, `audio/x-wav`, `audio/ogg`, `audio/aac`, `audio/flac`, `audio/webm`, `audio/mp4`.
        /// </param>
        /// <param name="recordingname">
        /// The consent audio recording file. Maximum size is 10 MiB.<br/>
        /// Supported MIME types:<br/>
        /// `audio/mpeg`, `audio/wav`, `audio/x-wav`, `audio/ogg`, `audio/aac`, `audio/flac`, `audio/webm`, `audio/mp4`.
        /// </param>
        /// <param name="language">
        /// The BCP 47 language tag for the consent phrase (for example, `en-US`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVoiceConsentRequest(
            string name,
            byte[] recording,
            string recordingname,
            string language)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Recording = recording ?? throw new global::System.ArgumentNullException(nameof(recording));
            this.Recordingname = recordingname ?? throw new global::System.ArgumentNullException(nameof(recordingname));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoiceConsentRequest" /> class.
        /// </summary>
        public CreateVoiceConsentRequest()
        {
        }
    }
}