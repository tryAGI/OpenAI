
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event, always `response.shell_call_output_content.delta`.<br/>
    /// Default Value: response.shell_call_output_content.delta
    /// </summary>
    public enum ResponseShellCallOutputContentDeltaStreamingEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseShellCallOutputContentDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseShellCallOutputContentDeltaStreamingEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseShellCallOutputContentDeltaStreamingEventType value)
        {
            return value switch
            {
                ResponseShellCallOutputContentDeltaStreamingEventType.ResponseShellCallOutputContentDelta => "response.shell_call_output_content.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseShellCallOutputContentDeltaStreamingEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.shell_call_output_content.delta" => ResponseShellCallOutputContentDeltaStreamingEventType.ResponseShellCallOutputContentDelta,
                _ => null,
            };
        }
    }
}