
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event, always `response.shell_call_command.added`.<br/>
    /// Default Value: response.shell_call_command.added
    /// </summary>
    public enum ResponseShellCallCommandAddedStreamingEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseShellCallCommandAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseShellCallCommandAddedStreamingEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseShellCallCommandAddedStreamingEventType value)
        {
            return value switch
            {
                ResponseShellCallCommandAddedStreamingEventType.ResponseShellCallCommandAdded => "response.shell_call_command.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseShellCallCommandAddedStreamingEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.shell_call_command.added" => ResponseShellCallCommandAddedStreamingEventType.ResponseShellCallCommandAdded,
                _ => null,
            };
        }
    }
}