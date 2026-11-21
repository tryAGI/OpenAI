
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RealtimeResponseInputMessageUserVariant2ContentItemDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseInputMessageUserVariant2ContentItemDiscriminatorTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageUserVariant2ContentItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseInputMessageUserVariant2ContentItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeResponseInputMessageUserVariant2ContentItemDiscriminator(
            global::tryAGI.OpenAI.RealtimeResponseInputMessageUserVariant2ContentItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseInputMessageUserVariant2ContentItemDiscriminator" /> class.
        /// </summary>
        public RealtimeResponseInputMessageUserVariant2ContentItemDiscriminator()
        {
        }

    }
}