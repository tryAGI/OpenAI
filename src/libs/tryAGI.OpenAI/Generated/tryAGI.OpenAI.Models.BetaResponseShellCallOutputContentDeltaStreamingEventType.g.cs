
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event, always `response.shell_call_output_content.delta`.<br/>
    /// Default Value: response.shell_call_output_content.delta
    /// </summary>
    public enum BetaResponseShellCallOutputContentDeltaStreamingEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseShellCallOutputContentDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseShellCallOutputContentDeltaStreamingEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseShellCallOutputContentDeltaStreamingEventType value)
        {
            return value switch
            {
                BetaResponseShellCallOutputContentDeltaStreamingEventType.ResponseShellCallOutputContentDelta => "response.shell_call_output_content.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseShellCallOutputContentDeltaStreamingEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.shell_call_output_content.delta" => BetaResponseShellCallOutputContentDeltaStreamingEventType.ResponseShellCallOutputContentDelta,
                _ => null,
            };
        }
    }
}