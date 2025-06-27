
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A click action.
    /// </summary>
    public sealed partial class Click
    {
        /// <summary>
        /// Indicates which mouse button was pressed during the click. One of `left`, `right`, `wheel`, `back`, or `forward`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("button")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ClickButtonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ClickButton Button { get; set; }

        /// <summary>
        /// Specifies the event type. For a click action, this property is <br/>
        /// always set to `click`.<br/>
        /// Default Value: click
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ClickType.Click</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ClickTypeJsonConverter))]
        public global::tryAGI.OpenAI.ClickType Type { get; set; } = global::tryAGI.OpenAI.ClickType.Click;

        /// <summary>
        /// The x-coordinate where the click occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int X { get; set; }

        /// <summary>
        /// The y-coordinate where the click occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Y { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Click" /> class.
        /// </summary>
        /// <param name="button">
        /// Indicates which mouse button was pressed during the click. One of `left`, `right`, `wheel`, `back`, or `forward`.
        /// </param>
        /// <param name="type">
        /// Specifies the event type. For a click action, this property is <br/>
        /// always set to `click`.<br/>
        /// Default Value: click
        /// </param>
        /// <param name="x">
        /// The x-coordinate where the click occurred.
        /// </param>
        /// <param name="y">
        /// The y-coordinate where the click occurred.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Click(
            global::tryAGI.OpenAI.ClickButton button,
            int x,
            int y,
            global::tryAGI.OpenAI.ClickType type = global::tryAGI.OpenAI.ClickType.Click)
        {
            this.Button = button;
            this.X = x;
            this.Y = y;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Click" /> class.
        /// </summary>
        public Click()
        {
        }
    }
}