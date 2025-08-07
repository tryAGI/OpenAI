
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Constrains the tools available to the model to a pre-defined set.
    /// </summary>
    public sealed partial class ChatCompletionAllowedTools
    {
        /// <summary>
        /// Constrains the tools available to the model to a pre-defined set.<br/>
        /// `auto` allows the model to pick from among the allowed tools and generate a<br/>
        /// message.<br/>
        /// `required` requires the model to call one or more of the allowed tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionAllowedToolsModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ChatCompletionAllowedToolsMode Mode { get; set; }

        /// <summary>
        /// A list of tool definitions that the model should be allowed to call.<br/>
        /// For the Chat Completions API, the list of tool definitions might look like:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   { "type": "function", "function": { "name": "get_weather" } },<br/>
        ///   { "type": "function", "function": { "name": "get_time" } }<br/>
        /// ]<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionAllowedTools" /> class.
        /// </summary>
        /// <param name="mode">
        /// Constrains the tools available to the model to a pre-defined set.<br/>
        /// `auto` allows the model to pick from among the allowed tools and generate a<br/>
        /// message.<br/>
        /// `required` requires the model to call one or more of the allowed tools.
        /// </param>
        /// <param name="tools">
        /// A list of tool definitions that the model should be allowed to call.<br/>
        /// For the Chat Completions API, the list of tool definitions might look like:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   { "type": "function", "function": { "name": "get_weather" } },<br/>
        ///   { "type": "function", "function": { "name": "get_time" } }<br/>
        /// ]<br/>
        /// ```
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionAllowedTools(
            global::tryAGI.OpenAI.ChatCompletionAllowedToolsMode mode,
            global::System.Collections.Generic.IList<object> tools)
        {
            this.Mode = mode;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionAllowedTools" /> class.
        /// </summary>
        public ChatCompletionAllowedTools()
        {
        }
    }
}