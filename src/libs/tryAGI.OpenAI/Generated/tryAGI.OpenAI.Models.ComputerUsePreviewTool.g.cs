
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A tool that controls a virtual computer. Learn more about the [computer tool](https://platform.openai.com/docs/guides/tools-computer-use).
    /// </summary>
    public sealed partial class ComputerUsePreviewTool
    {
        /// <summary>
        /// The height of the computer display.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DisplayHeight { get; set; }

        /// <summary>
        /// The width of the computer display.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DisplayWidth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerEnvironmentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ComputerEnvironment Environment { get; set; }

        /// <summary>
        /// The type of the computer use tool. Always `computer_use_preview`.<br/>
        /// Default Value: computer_use_preview
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ComputerUsePreviewToolType.ComputerUsePreview</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerUsePreviewToolTypeJsonConverter))]
        public global::tryAGI.OpenAI.ComputerUsePreviewToolType Type { get; set; } = global::tryAGI.OpenAI.ComputerUsePreviewToolType.ComputerUsePreview;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUsePreviewTool" /> class.
        /// </summary>
        /// <param name="displayHeight">
        /// The height of the computer display.
        /// </param>
        /// <param name="displayWidth">
        /// The width of the computer display.
        /// </param>
        /// <param name="environment"></param>
        /// <param name="type">
        /// The type of the computer use tool. Always `computer_use_preview`.<br/>
        /// Default Value: computer_use_preview
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerUsePreviewTool(
            int displayHeight,
            int displayWidth,
            global::tryAGI.OpenAI.ComputerEnvironment environment,
            global::tryAGI.OpenAI.ComputerUsePreviewToolType type = global::tryAGI.OpenAI.ComputerUsePreviewToolType.ComputerUsePreview)
        {
            this.DisplayHeight = displayHeight;
            this.DisplayWidth = displayWidth;
            this.Environment = environment;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUsePreviewTool" /> class.
        /// </summary>
        public ComputerUsePreviewTool()
        {
        }
    }
}