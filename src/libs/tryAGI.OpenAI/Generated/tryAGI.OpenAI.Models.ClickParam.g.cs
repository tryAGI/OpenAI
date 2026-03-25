
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A click action.
    /// </summary>
    public sealed partial class ClickParam
    {
        /// <summary>
        /// Specifies the event type. For a click action, this property is always `click`.<br/>
        /// Default Value: click
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ClickParamType.Click</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ClickParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.ClickParamType Type { get; set; } = global::tryAGI.OpenAI.ClickParamType.Click;

        /// <summary>
        /// Indicates which mouse button was pressed during the click. One of `left`, `right`, `wheel`, `back`, or `forward`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("button")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ClickButtonTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ClickButtonType Button { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        public global::System.Collections.Generic.IList<string>? Keys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClickParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Specifies the event type. For a click action, this property is always `click`.<br/>
        /// Default Value: click
        /// </param>
        /// <param name="button">
        /// Indicates which mouse button was pressed during the click. One of `left`, `right`, `wheel`, `back`, or `forward`.
        /// </param>
        /// <param name="x">
        /// The x-coordinate where the click occurred.
        /// </param>
        /// <param name="y">
        /// The y-coordinate where the click occurred.
        /// </param>
        /// <param name="keys"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClickParam(
            global::tryAGI.OpenAI.ClickButtonType button,
            int x,
            int y,
            global::System.Collections.Generic.IList<string>? keys,
            global::tryAGI.OpenAI.ClickParamType type = global::tryAGI.OpenAI.ClickParamType.Click)
        {
            this.Button = button;
            this.X = x;
            this.Y = y;
            this.Type = type;
            this.Keys = keys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClickParam" /> class.
        /// </summary>
        public ClickParam()
        {
        }
    }
}