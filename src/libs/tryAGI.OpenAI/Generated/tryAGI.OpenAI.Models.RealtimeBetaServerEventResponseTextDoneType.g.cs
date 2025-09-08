
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `response.output_text.done`.
    /// </summary>
    public enum RealtimeBetaServerEventResponseTextDoneType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputTextDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventResponseTextDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventResponseTextDoneType value)
        {
            return value switch
            {
                RealtimeBetaServerEventResponseTextDoneType.ResponseOutputTextDone => "response.output_text.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventResponseTextDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_text.done" => RealtimeBetaServerEventResponseTextDoneType.ResponseOutputTextDone,
                _ => null,
            };
        }
    }
}