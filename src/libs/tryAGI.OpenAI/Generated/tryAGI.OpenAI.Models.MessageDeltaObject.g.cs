
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents a message delta i.e. any changed fields on a message during streaming.
    /// </summary>
    public sealed partial class MessageDeltaObject
    {
        /// <summary>
        /// The identifier of the message, which can be referenced in API endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, which is always `thread.message.delta`.
        /// </summary>
        /// <default>"thread.message.delta"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "thread.message.delta";

        /// <summary>
        /// The delta containing the fields that have changed on the Message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.MessageDeltaObjectDelta Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaObject" /> class.
        /// </summary>
        /// <param name="id">
        /// The identifier of the message, which can be referenced in API endpoints.
        /// </param>
        /// <param name="delta">
        /// The delta containing the fields that have changed on the Message.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `thread.message.delta`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageDeltaObject(
            string id,
            global::tryAGI.OpenAI.MessageDeltaObjectDelta delta,
            string @object = "thread.message.delta")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaObject" /> class.
        /// </summary>
        public MessageDeltaObject()
        {
        }

    }
}