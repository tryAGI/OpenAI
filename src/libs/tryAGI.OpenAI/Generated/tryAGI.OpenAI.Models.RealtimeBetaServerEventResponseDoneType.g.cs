
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `response.done`.
    /// </summary>
    public enum RealtimeBetaServerEventResponseDoneType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventResponseDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventResponseDoneType value)
        {
            return value switch
            {
                RealtimeBetaServerEventResponseDoneType.ResponseDone => "response.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventResponseDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.done" => RealtimeBetaServerEventResponseDoneType.ResponseDone,
                _ => null,
            };
        }
    }
}