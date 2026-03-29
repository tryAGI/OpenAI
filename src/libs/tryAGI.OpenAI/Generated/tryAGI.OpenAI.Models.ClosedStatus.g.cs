
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Indicates that a thread has been closed.
    /// </summary>
    public sealed partial class ClosedStatus
    {
        /// <summary>
        /// Status discriminator that is always `closed`.<br/>
        /// Default Value: closed
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ClosedStatusType.Closed</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ClosedStatusTypeJsonConverter))]
        public global::tryAGI.OpenAI.ClosedStatusType Type { get; set; } = global::tryAGI.OpenAI.ClosedStatusType.Closed;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClosedStatus" /> class.
        /// </summary>
        /// <param name="reason"></param>
        /// <param name="type">
        /// Status discriminator that is always `closed`.<br/>
        /// Default Value: closed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClosedStatus(
            string? reason,
            global::tryAGI.OpenAI.ClosedStatusType type = global::tryAGI.OpenAI.ClosedStatusType.Closed)
        {
            this.Type = type;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClosedStatus" /> class.
        /// </summary>
        public ClosedStatus()
        {
        }
    }
}