
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Email notification settings for a spend alert.
    /// </summary>
    public sealed partial class SpendAlertNotificationChannel
    {
        /// <summary>
        /// The notification channel type. Currently only `email` is supported.
        /// </summary>
        /// <default>"email"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "email";

        /// <summary>
        /// Email addresses that receive the spend alert notification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipients")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Recipients { get; set; }

        /// <summary>
        /// Optional subject prefix for alert emails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_prefix")]
        public string? SubjectPrefix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendAlertNotificationChannel" /> class.
        /// </summary>
        /// <param name="recipients">
        /// Email addresses that receive the spend alert notification.
        /// </param>
        /// <param name="subjectPrefix">
        /// Optional subject prefix for alert emails.
        /// </param>
        /// <param name="type">
        /// The notification channel type. Currently only `email` is supported.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpendAlertNotificationChannel(
            global::System.Collections.Generic.IList<string> recipients,
            string? subjectPrefix,
            string type = "email")
        {
            this.Type = type;
            this.Recipients = recipients ?? throw new global::System.ArgumentNullException(nameof(recipients));
            this.SubjectPrefix = subjectPrefix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendAlertNotificationChannel" /> class.
        /// </summary>
        public SpendAlertNotificationChannel()
        {
        }

    }
}