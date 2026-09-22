
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Identifies the stored Live session whose conversation and configuration are used to create a fork.
    /// </summary>
    public sealed partial class LiveForkPathParams
    {
        /// <summary>
        /// The ID of the stored Live session to fork.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveForkPathParams" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// The ID of the stored Live session to fork.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveForkPathParams(
            string sessionId)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveForkPathParams" /> class.
        /// </summary>
        public LiveForkPathParams()
        {
        }

    }
}