
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A tool that controls a virtual computer. Learn more about the <br/>
    /// [computer tool](/docs/guides/tools-computer-use).
    /// </summary>
    public sealed partial class ComputerTool
    {
        /// <summary>
        /// The type of the computer use tool. Always `computer_use_preview`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerToolTypeJsonConverter))]
        public global::tryAGI.OpenAI.ComputerToolType Type { get; set; }

        /// <summary>
        /// The width of the computer display.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DisplayWidth { get; set; }

        /// <summary>
        /// The height of the computer display.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DisplayHeight { get; set; }

        /// <summary>
        /// The type of computer environment to control.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerToolEnvironmentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ComputerToolEnvironment Environment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerTool" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the computer use tool. Always `computer_use_preview`.
        /// </param>
        /// <param name="displayWidth">
        /// The width of the computer display.
        /// </param>
        /// <param name="displayHeight">
        /// The height of the computer display.
        /// </param>
        /// <param name="environment">
        /// The type of computer environment to control.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerTool(
            double displayWidth,
            double displayHeight,
            global::tryAGI.OpenAI.ComputerToolEnvironment environment,
            global::tryAGI.OpenAI.ComputerToolType type)
        {
            this.DisplayWidth = displayWidth;
            this.DisplayHeight = displayHeight;
            this.Environment = environment;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerTool" /> class.
        /// </summary>
        public ComputerTool()
        {
        }
    }
}