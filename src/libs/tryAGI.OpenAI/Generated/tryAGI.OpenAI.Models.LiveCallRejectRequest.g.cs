
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Parameters used to reject an incoming Live SIP call.
    /// </summary>
    public sealed partial class LiveCallRejectRequest
    {
        /// <summary>
        /// SIP rejection status sent to the caller. This field is required.<br/>
        /// Example: 486
        /// </summary>
        /// <example>486</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StatusCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveCallRejectRequest" /> class.
        /// </summary>
        /// <param name="statusCode">
        /// SIP rejection status sent to the caller. This field is required.<br/>
        /// Example: 486
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveCallRejectRequest(
            int statusCode)
        {
            this.StatusCode = statusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveCallRejectRequest" /> class.
        /// </summary>
        public LiveCallRejectRequest()
        {
        }

    }
}