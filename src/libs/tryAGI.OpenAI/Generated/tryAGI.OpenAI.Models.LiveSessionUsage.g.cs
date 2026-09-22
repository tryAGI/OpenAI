
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Cumulative audio duration for a Live session. Values are totals for the session, not increments to sum across usage events.
    /// </summary>
    public sealed partial class LiveSessionUsage
    {
        /// <summary>
        /// The cumulative Live audio duration in seconds. Do not sum this value across usage events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Seconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionUsage" /> class.
        /// </summary>
        /// <param name="seconds">
        /// The cumulative Live audio duration in seconds. Do not sum this value across usage events.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSessionUsage(
            double seconds)
        {
            this.Seconds = seconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionUsage" /> class.
        /// </summary>
        public LiveSessionUsage()
        {
        }

    }
}