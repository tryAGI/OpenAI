
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveAllowedToolsChoiceParam
    {
        /// <summary>
        /// The tool choice type. Always `allowed_tools`.<br/>
        /// Default Value: allowed_tools
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamType.AllowedTools</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveAllowedToolsChoiceParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamType Type { get; set; } = global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamType.AllowedTools;

        /// <summary>
        /// The tools that the delegated Responses model may call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem15> Tools { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public global::tryAGI.OpenAI.LiveToolChoiceValueEnum? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveAllowedToolsChoiceParam" /> class.
        /// </summary>
        /// <param name="tools">
        /// The tools that the delegated Responses model may call.
        /// </param>
        /// <param name="mode"></param>
        /// <param name="type">
        /// The tool choice type. Always `allowed_tools`.<br/>
        /// Default Value: allowed_tools
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveAllowedToolsChoiceParam(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem15> tools,
            global::tryAGI.OpenAI.LiveToolChoiceValueEnum? mode,
            global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamType type = global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamType.AllowedTools)
        {
            this.Type = type;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveAllowedToolsChoiceParam" /> class.
        /// </summary>
        public LiveAllowedToolsChoiceParam()
        {
        }

    }
}