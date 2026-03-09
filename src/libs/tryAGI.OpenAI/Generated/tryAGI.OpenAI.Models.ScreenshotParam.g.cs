
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A screenshot action.
    /// </summary>
    public sealed partial class ScreenshotParam
    {
        /// <summary>
        /// Specifies the event type. For a screenshot action, this property is always set to `screenshot`.<br/>
        /// Default Value: screenshot
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ScreenshotParamType.Screenshot</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ScreenshotParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.ScreenshotParamType Type { get; set; } = global::tryAGI.OpenAI.ScreenshotParamType.Screenshot;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenshotParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Specifies the event type. For a screenshot action, this property is always set to `screenshot`.<br/>
        /// Default Value: screenshot
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScreenshotParam(
            global::tryAGI.OpenAI.ScreenshotParamType type = global::tryAGI.OpenAI.ScreenshotParamType.Screenshot)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenshotParam" /> class.
        /// </summary>
        public ScreenshotParam()
        {
        }
    }
}