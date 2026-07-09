
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A tool that controls a virtual computer. Learn more about the [computer tool](https://platform.openai.com/docs/guides/tools-computer-use).
    /// </summary>
    public sealed partial class BetaComputerTool
    {
        /// <summary>
        /// The type of the computer tool. Always `computer`.<br/>
        /// Default Value: computer
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaComputerToolType.Computer</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaComputerToolTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaComputerToolType Type { get; set; } = global::tryAGI.OpenAI.BetaComputerToolType.Computer;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComputerTool" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the computer tool. Always `computer`.<br/>
        /// Default Value: computer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaComputerTool(
            global::tryAGI.OpenAI.BetaComputerToolType type = global::tryAGI.OpenAI.BetaComputerToolType.Computer)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComputerTool" /> class.
        /// </summary>
        public BetaComputerTool()
        {
        }

    }
}