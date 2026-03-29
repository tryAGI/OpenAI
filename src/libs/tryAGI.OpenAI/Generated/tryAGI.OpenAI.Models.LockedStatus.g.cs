
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Indicates that a thread is locked and cannot accept new input.
    /// </summary>
    public sealed partial class LockedStatus
    {
        /// <summary>
        /// Status discriminator that is always `locked`.<br/>
        /// Default Value: locked
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LockedStatusType.Locked</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LockedStatusTypeJsonConverter))]
        public global::tryAGI.OpenAI.LockedStatusType Type { get; set; } = global::tryAGI.OpenAI.LockedStatusType.Locked;

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
        /// Initializes a new instance of the <see cref="LockedStatus" /> class.
        /// </summary>
        /// <param name="reason"></param>
        /// <param name="type">
        /// Status discriminator that is always `locked`.<br/>
        /// Default Value: locked
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LockedStatus(
            string? reason,
            global::tryAGI.OpenAI.LockedStatusType type = global::tryAGI.OpenAI.LockedStatusType.Locked)
        {
            this.Type = type;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LockedStatus" /> class.
        /// </summary>
        public LockedStatus()
        {
        }
    }
}