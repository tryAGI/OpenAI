
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A drag action.
    /// </summary>
    public sealed partial class BetaDragParam
    {
        /// <summary>
        /// Specifies the event type. For a drag action, this property is always set to `drag`.<br/>
        /// Default Value: drag
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaDragParamType.Drag</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaDragParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaDragParamType Type { get; set; } = global::tryAGI.OpenAI.BetaDragParamType.Drag;

        /// <summary>
        /// An array of coordinates representing the path of the drag action. Coordinates will appear as an array of objects, eg<br/>
        /// ```<br/>
        /// [<br/>
        ///   { x: 100, y: 200 },<br/>
        ///   { x: 200, y: 300 }<br/>
        /// ]<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCoordParam> Path { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaDragParam" /> class.
        /// </summary>
        /// <param name="path">
        /// An array of coordinates representing the path of the drag action. Coordinates will appear as an array of objects, eg<br/>
        /// ```<br/>
        /// [<br/>
        ///   { x: 100, y: 200 },<br/>
        ///   { x: 200, y: 300 }<br/>
        /// ]<br/>
        /// ```
        /// </param>
        /// <param name="keys"></param>
        /// <param name="type">
        /// Specifies the event type. For a drag action, this property is always set to `drag`.<br/>
        /// Default Value: drag
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDragParam(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCoordParam> path,
            global::System.Collections.Generic.IList<string>? keys,
            global::tryAGI.OpenAI.BetaDragParamType type = global::tryAGI.OpenAI.BetaDragParamType.Drag)
        {
            this.Type = type;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Keys = keys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDragParam" /> class.
        /// </summary>
        public BetaDragParam()
        {
        }

    }
}