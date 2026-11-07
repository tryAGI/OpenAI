
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// A message supplied as input to a Realtime response. The role determines the allowed content.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonPolymorphic(
        TypeDiscriminatorPropertyName = "role",
        IgnoreUnrecognizedTypeDiscriminators = true,
        UnknownDerivedTypeHandling = global::System.Text.Json.Serialization.JsonUnknownDerivedTypeHandling.FallBackToBaseType)]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageAssistant), typeDiscriminator: "assistant")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageDeveloper), typeDiscriminator: "developer")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageSystem), typeDiscriminator: "system")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageUser), typeDiscriminator: "user")]
    public partial class RealtimeResponseInputMessage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeResponseInputMessageTypeJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseInputMessage" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeResponseInputMessage(
            global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseInputMessage" /> class.
        /// </summary>
        public RealtimeResponseInputMessage()
        {
        }

    }
}