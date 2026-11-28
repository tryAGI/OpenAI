
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configure email notifications when the spend limit is reached. Leave this out to keep the current settings, or send null to reset to owner-only notifications.
    /// </summary>
    public sealed partial class SpendLimitEmailNotificationChannelParams
    {
        /// <summary>
        /// Default Value: email
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SpendLimitEmailNotificationChannelParamsType.Email</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SpendLimitEmailNotificationChannelParamsTypeJsonConverter))]
        public global::tryAGI.OpenAI.SpendLimitEmailNotificationChannelParamsType Type { get; set; } = global::tryAGI.OpenAI.SpendLimitEmailNotificationChannelParamsType.Email;

        /// <summary>
        /// Additional email recipients. Omit to keep them unchanged; send [] to clear them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipients")]
        public global::System.Collections.Generic.IList<string>? Recipients { get; set; }

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
        /// Initializes a new instance of the <see cref="SpendLimitEmailNotificationChannelParams" /> class.
        /// </summary>
        /// <param name="recipients">
        /// Additional email recipients. Omit to keep them unchanged; send [] to clear them.
        /// </param>
        /// <param name="subjectPrefix"></param>
        /// <param name="type">
        /// Default Value: email
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpendLimitEmailNotificationChannelParams(
            global::System.Collections.Generic.IList<string>? recipients,
            string? subjectPrefix,
            global::tryAGI.OpenAI.SpendLimitEmailNotificationChannelParamsType type = global::tryAGI.OpenAI.SpendLimitEmailNotificationChannelParamsType.Email)
        {
            this.Type = type;
            this.Recipients = recipients;
            this.SubjectPrefix = subjectPrefix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendLimitEmailNotificationChannelParams" /> class.
        /// </summary>
        public SpendLimitEmailNotificationChannelParams()
        {
        }

    }
}