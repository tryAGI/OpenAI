
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event, always `response.shell_call_output_content.done`.<br/>
    /// Default Value: response.shell_call_output_content.done
    /// </summary>
    public enum BetaResponseShellCallOutputContentDoneStreamingEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseShellCallOutputContentDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseShellCallOutputContentDoneStreamingEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseShellCallOutputContentDoneStreamingEventType value)
        {
            return value switch
            {
                BetaResponseShellCallOutputContentDoneStreamingEventType.ResponseShellCallOutputContentDone => "response.shell_call_output_content.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseShellCallOutputContentDoneStreamingEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.shell_call_output_content.done" => BetaResponseShellCallOutputContentDoneStreamingEventType.ResponseShellCallOutputContentDone,
                _ => null,
            };
        }
    }
}