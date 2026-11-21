
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Cumulative billable duration for a Live session. Eligible WebRTC sessions also report the active and paused breakdown. Do not sum values across usage events.
    /// </summary>
    public sealed partial class LiveSessionUsage
    {
        /// <summary>
        /// The cumulative billable duration in whole seconds. When present, the active and paused breakdown adds up to this total.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Seconds { get; set; }

        /// <summary>
        /// The remaining billable seconds attributed to active audio and any unused prepaid duration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_seconds")]
        public int? ActiveSeconds { get; set; }

        /// <summary>
        /// Billable time attributed to paused inference at the configured rate, rounded down to whole seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paused_seconds")]
        public int? PausedSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionUsage" /> class.
        /// </summary>
        /// <param name="seconds">
        /// The cumulative billable duration in whole seconds. When present, the active and paused breakdown adds up to this total.
        /// </param>
        /// <param name="activeSeconds">
        /// The remaining billable seconds attributed to active audio and any unused prepaid duration.
        /// </param>
        /// <param name="pausedSeconds">
        /// Billable time attributed to paused inference at the configured rate, rounded down to whole seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSessionUsage(
            int seconds,
            int? activeSeconds,
            int? pausedSeconds)
        {
            this.Seconds = seconds;
            this.ActiveSeconds = activeSeconds;
            this.PausedSeconds = pausedSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionUsage" /> class.
        /// </summary>
        public LiveSessionUsage()
        {
        }

    }
}