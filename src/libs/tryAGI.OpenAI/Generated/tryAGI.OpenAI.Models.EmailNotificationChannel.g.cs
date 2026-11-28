
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EmailNotificationChannel
    {
        /// <summary>
        /// Default Value: email
        /// </summary>
        /// <default>global::tryAGI.OpenAI.EmailNotificationChannelType.Email</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EmailNotificationChannelTypeJsonConverter))]
        public global::tryAGI.OpenAI.EmailNotificationChannelType Type { get; set; } = global::tryAGI.OpenAI.EmailNotificationChannelType.Email;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipients")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Recipients { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_prefix")]
        public string? SubjectPrefix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailNotificationChannel" /> class.
        /// </summary>
        /// <param name="recipients"></param>
        /// <param name="subjectPrefix"></param>
        /// <param name="type">
        /// Default Value: email
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmailNotificationChannel(
            global::System.Collections.Generic.IList<string> recipients,
            string? subjectPrefix,
            global::tryAGI.OpenAI.EmailNotificationChannelType type = global::tryAGI.OpenAI.EmailNotificationChannelType.Email)
        {
            this.Type = type;
            this.Recipients = recipients ?? throw new global::System.ArgumentNullException(nameof(recipients));
            this.SubjectPrefix = subjectPrefix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailNotificationChannel" /> class.
        /// </summary>
        public EmailNotificationChannel()
        {
        }

    }
}