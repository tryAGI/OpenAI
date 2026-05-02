
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Controls when the session expires relative to an anchor timestamp.
    /// </summary>
    public sealed partial class ExpiresAfterParam
    {
        /// <summary>
        /// Base timestamp used to calculate expiration. Currently fixed to `created_at`.<br/>
        /// Default Value: created_at
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ExpiresAfterParamAnchor.CreatedAt</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("anchor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ExpiresAfterParamAnchorJsonConverter))]
        public global::tryAGI.OpenAI.ExpiresAfterParamAnchor Anchor { get; set; } = global::tryAGI.OpenAI.ExpiresAfterParamAnchor.CreatedAt;

        /// <summary>
        /// Number of seconds after the anchor when the session expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Seconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpiresAfterParam" /> class.
        /// </summary>
        /// <param name="seconds">
        /// Number of seconds after the anchor when the session expires.
        /// </param>
        /// <param name="anchor">
        /// Base timestamp used to calculate expiration. Currently fixed to `created_at`.<br/>
        /// Default Value: created_at
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExpiresAfterParam(
            long seconds,
            global::tryAGI.OpenAI.ExpiresAfterParamAnchor anchor = global::tryAGI.OpenAI.ExpiresAfterParamAnchor.CreatedAt)
        {
            this.Anchor = anchor;
            this.Seconds = seconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpiresAfterParam" /> class.
        /// </summary>
        public ExpiresAfterParam()
        {
        }
    }
}