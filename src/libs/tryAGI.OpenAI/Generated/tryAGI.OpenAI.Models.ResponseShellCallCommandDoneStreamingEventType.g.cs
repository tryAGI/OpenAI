
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event, always `response.shell_call_command.done`.<br/>
    /// Default Value: response.shell_call_command.done
    /// </summary>
    public enum ResponseShellCallCommandDoneStreamingEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseShellCallCommandDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseShellCallCommandDoneStreamingEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseShellCallCommandDoneStreamingEventType value)
        {
            return value switch
            {
                ResponseShellCallCommandDoneStreamingEventType.ResponseShellCallCommandDone => "response.shell_call_command.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseShellCallCommandDoneStreamingEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.shell_call_command.done" => ResponseShellCallCommandDoneStreamingEventType.ResponseShellCallCommandDone,
                _ => null,
            };
        }
    }
}