
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Parameters used to decline an incoming SIP call handled by the Realtime API.
    /// </summary>
    public sealed partial class RealtimeCallRejectRequest
    {
        /// <summary>
        /// SIP response code to send back to the caller. Defaults to `603` (Decline)<br/>
        /// when omitted.<br/>
        /// Example: 486
        /// </summary>
        /// <example>486</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        public int? StatusCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeCallRejectRequest" /> class.
        /// </summary>
        /// <param name="statusCode">
        /// SIP response code to send back to the caller. Defaults to `603` (Decline)<br/>
        /// when omitted.<br/>
        /// Example: 486
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeCallRejectRequest(
            int? statusCode)
        {
            this.StatusCode = statusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeCallRejectRequest" /> class.
        /// </summary>
        public RealtimeCallRejectRequest()
        {
        }
    }
}