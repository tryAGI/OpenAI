
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event, always `response.shell_call_command.done`.<br/>
    /// Default Value: response.shell_call_command.done
    /// </summary>
    public enum BetaResponseShellCallCommandDoneStreamingEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseShellCallCommandDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseShellCallCommandDoneStreamingEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseShellCallCommandDoneStreamingEventType value)
        {
            return value switch
            {
                BetaResponseShellCallCommandDoneStreamingEventType.ResponseShellCallCommandDone => "response.shell_call_command.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseShellCallCommandDoneStreamingEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.shell_call_command.done" => BetaResponseShellCallCommandDoneStreamingEventType.ResponseShellCallCommandDone,
                _ => null,
            };
        }
    }
}