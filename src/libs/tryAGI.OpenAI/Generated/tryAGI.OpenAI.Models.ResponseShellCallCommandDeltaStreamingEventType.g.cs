
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event, always `response.shell_call_command.delta`.<br/>
    /// Default Value: response.shell_call_command.delta
    /// </summary>
    public enum ResponseShellCallCommandDeltaStreamingEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseShellCallCommandDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseShellCallCommandDeltaStreamingEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseShellCallCommandDeltaStreamingEventType value)
        {
            return value switch
            {
                ResponseShellCallCommandDeltaStreamingEventType.ResponseShellCallCommandDelta => "response.shell_call_command.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseShellCallCommandDeltaStreamingEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.shell_call_command.delta" => ResponseShellCallCommandDeltaStreamingEventType.ResponseShellCallCommandDelta,
                _ => null,
            };
        }
    }
}