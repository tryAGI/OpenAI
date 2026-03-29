
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A collection of keypresses the model would like to perform.
    /// </summary>
    public sealed partial class KeyPressAction
    {
        /// <summary>
        /// Specifies the event type. For a keypress action, this property is always set to `keypress`.<br/>
        /// Default Value: keypress
        /// </summary>
        /// <default>global::tryAGI.OpenAI.KeyPressActionType.Keypress</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.KeyPressActionTypeJsonConverter))]
        public global::tryAGI.OpenAI.KeyPressActionType Type { get; set; } = global::tryAGI.OpenAI.KeyPressActionType.Keypress;

        /// <summary>
        /// The combination of keys the model is requesting to be pressed. This is an array of strings, each representing a key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Keys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyPressAction" /> class.
        /// </summary>
        /// <param name="keys">
        /// The combination of keys the model is requesting to be pressed. This is an array of strings, each representing a key.
        /// </param>
        /// <param name="type">
        /// Specifies the event type. For a keypress action, this property is always set to `keypress`.<br/>
        /// Default Value: keypress
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeyPressAction(
            global::System.Collections.Generic.IList<string> keys,
            global::tryAGI.OpenAI.KeyPressActionType type = global::tryAGI.OpenAI.KeyPressActionType.Keypress)
        {
            this.Type = type;
            this.Keys = keys ?? throw new global::System.ArgumentNullException(nameof(keys));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyPressAction" /> class.
        /// </summary>
        public KeyPressAction()
        {
        }
    }
}