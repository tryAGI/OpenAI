
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A drag action.
    /// </summary>
    public sealed partial class DragParam
    {
        /// <summary>
        /// Specifies the event type. For a drag action, this property is always set to `drag`.<br/>
        /// Default Value: drag
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DragParamType.Drag</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DragParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.DragParamType Type { get; set; } = global::tryAGI.OpenAI.DragParamType.Drag;

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
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CoordParam> Path { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DragParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Specifies the event type. For a drag action, this property is always set to `drag`.<br/>
        /// Default Value: drag
        /// </param>
        /// <param name="path">
        /// An array of coordinates representing the path of the drag action. Coordinates will appear as an array of objects, eg<br/>
        /// ```<br/>
        /// [<br/>
        ///   { x: 100, y: 200 },<br/>
        ///   { x: 200, y: 300 }<br/>
        /// ]<br/>
        /// ```
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DragParam(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CoordParam> path,
            global::tryAGI.OpenAI.DragParamType type = global::tryAGI.OpenAI.DragParamType.Drag)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DragParam" /> class.
        /// </summary>
        public DragParam()
        {
        }
    }
}