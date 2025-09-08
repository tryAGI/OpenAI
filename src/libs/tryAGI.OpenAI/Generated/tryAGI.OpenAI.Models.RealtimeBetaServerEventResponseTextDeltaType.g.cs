
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `response.output_text.delta`.
    /// </summary>
    public enum RealtimeBetaServerEventResponseTextDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputTextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventResponseTextDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventResponseTextDeltaType value)
        {
            return value switch
            {
                RealtimeBetaServerEventResponseTextDeltaType.ResponseOutputTextDelta => "response.output_text.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventResponseTextDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_text.delta" => RealtimeBetaServerEventResponseTextDeltaType.ResponseOutputTextDelta,
                _ => null,
            };
        }
    }
}