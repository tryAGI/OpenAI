
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Indicates that a thread is active.
    /// </summary>
    public sealed partial class ActiveStatus
    {
        /// <summary>
        /// Status discriminator that is always `active`.<br/>
        /// Default Value: active
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ActiveStatusType.Active</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ActiveStatusTypeJsonConverter))]
        public global::tryAGI.OpenAI.ActiveStatusType Type { get; set; } = global::tryAGI.OpenAI.ActiveStatusType.Active;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveStatus" /> class.
        /// </summary>
        /// <param name="type">
        /// Status discriminator that is always `active`.<br/>
        /// Default Value: active
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActiveStatus(
            global::tryAGI.OpenAI.ActiveStatusType type = global::tryAGI.OpenAI.ActiveStatusType.Active)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveStatus" /> class.
        /// </summary>
        public ActiveStatus()
        {
        }
    }
}