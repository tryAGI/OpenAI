
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `response.output_item.done`.
    /// </summary>
    public enum RealtimeBetaServerEventResponseOutputItemDoneType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputItemDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventResponseOutputItemDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventResponseOutputItemDoneType value)
        {
            return value switch
            {
                RealtimeBetaServerEventResponseOutputItemDoneType.ResponseOutputItemDone => "response.output_item.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventResponseOutputItemDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_item.done" => RealtimeBetaServerEventResponseOutputItemDoneType.ResponseOutputItemDone,
                _ => null,
            };
        }
    }
}