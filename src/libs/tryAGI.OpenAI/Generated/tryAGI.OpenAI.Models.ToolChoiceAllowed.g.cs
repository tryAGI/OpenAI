
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Constrains the tools available to the model to a pre-defined set.
    /// </summary>
    public sealed partial class ToolChoiceAllowed
    {
        /// <summary>
        /// Constrains the tools available to the model to a pre-defined set.<br/>
        /// `auto` allows the model to pick from among the allowed tools and generate a<br/>
        /// message.<br/>
        /// `required` requires the model to call one or more of the allowed tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ToolChoiceAllowedModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ToolChoiceAllowedMode Mode { get; set; }

        /// <summary>
        /// A list of tool definitions that the model should be allowed to call.<br/>
        /// For the Responses API, the list of tool definitions might look like:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   { "type": "function", "name": "get_weather" },<br/>
        ///   { "type": "mcp", "server_label": "deepwiki" },<br/>
        ///   { "type": "image_generation" }<br/>
        /// ]<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Tools { get; set; }

        /// <summary>
        /// Allowed tool configuration type. Always `allowed_tools`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ToolChoiceAllowedTypeJsonConverter))]
        public global::tryAGI.OpenAI.ToolChoiceAllowedType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoiceAllowed" /> class.
        /// </summary>
        /// <param name="mode">
        /// Constrains the tools available to the model to a pre-defined set.<br/>
        /// `auto` allows the model to pick from among the allowed tools and generate a<br/>
        /// message.<br/>
        /// `required` requires the model to call one or more of the allowed tools.
        /// </param>
        /// <param name="tools">
        /// A list of tool definitions that the model should be allowed to call.<br/>
        /// For the Responses API, the list of tool definitions might look like:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   { "type": "function", "name": "get_weather" },<br/>
        ///   { "type": "mcp", "server_label": "deepwiki" },<br/>
        ///   { "type": "image_generation" }<br/>
        /// ]<br/>
        /// ```
        /// </param>
        /// <param name="type">
        /// Allowed tool configuration type. Always `allowed_tools`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolChoiceAllowed(
            global::tryAGI.OpenAI.ToolChoiceAllowedMode mode,
            global::System.Collections.Generic.IList<object> tools,
            global::tryAGI.OpenAI.ToolChoiceAllowedType type)
        {
            this.Mode = mode;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoiceAllowed" /> class.
        /// </summary>
        public ToolChoiceAllowed()
        {
        }
    }
}