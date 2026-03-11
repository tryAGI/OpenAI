
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A double click action.
    /// </summary>
    public sealed partial class DoubleClickAction
    {
        /// <summary>
        /// Specifies the event type. For a double click action, this property is always set to `double_click`.<br/>
        /// Default Value: double_click
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DoubleClickActionType.DoubleClick</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DoubleClickActionTypeJsonConverter))]
        public global::tryAGI.OpenAI.DoubleClickActionType Type { get; set; } = global::tryAGI.OpenAI.DoubleClickActionType.DoubleClick;

        /// <summary>
        /// The x-coordinate where the double click occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int X { get; set; }

        /// <summary>
        /// The y-coordinate where the double click occurred.
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
        /// Initializes a new instance of the <see cref="DoubleClickAction" /> class.
        /// </summary>
        /// <param name="type">
        /// Specifies the event type. For a double click action, this property is always set to `double_click`.<br/>
        /// Default Value: double_click
        /// </param>
        /// <param name="x">
        /// The x-coordinate where the double click occurred.
        /// </param>
        /// <param name="y">
        /// The y-coordinate where the double click occurred.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DoubleClickAction(
            int x,
            int y,
            global::tryAGI.OpenAI.DoubleClickActionType type = global::tryAGI.OpenAI.DoubleClickActionType.DoubleClick)
        {
            this.X = x;
            this.Y = y;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleClickAction" /> class.
        /// </summary>
        public DoubleClickAction()
        {
        }
    }
}