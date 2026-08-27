
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A mouse move action.
    /// </summary>
    public sealed partial class BetaMoveParam
    {
        /// <summary>
        /// Specifies the event type. For a move action, this property is always set to `move`.<br/>
        /// Default Value: move
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaMoveParamType.Move</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaMoveParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaMoveParamType Type { get; set; } = global::tryAGI.OpenAI.BetaMoveParamType.Move;

        /// <summary>
        /// The x-coordinate to move to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int X { get; set; }

        /// <summary>
        /// The y-coordinate to move to.
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
        /// Initializes a new instance of the <see cref="BetaMoveParam" /> class.
        /// </summary>
        /// <param name="x">
        /// The x-coordinate to move to.
        /// </param>
        /// <param name="y">
        /// The y-coordinate to move to.
        /// </param>
        /// <param name="keys"></param>
        /// <param name="type">
        /// Specifies the event type. For a move action, this property is always set to `move`.<br/>
        /// Default Value: move
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMoveParam(
            int x,
            int y,
            global::System.Collections.Generic.IList<string>? keys,
            global::tryAGI.OpenAI.BetaMoveParamType type = global::tryAGI.OpenAI.BetaMoveParamType.Move)
        {
            this.Type = type;
            this.X = x;
            this.Y = y;
            this.Keys = keys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMoveParam" /> class.
        /// </summary>
        public BetaMoveParam()
        {
        }

    }
}