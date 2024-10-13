
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The event type, must be "response.output_item.done".<br/>
    /// Example: response.output_item.done
    /// </summary>
    public enum RealtimeResponseOutputItemDoneType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputItemDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseOutputItemDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseOutputItemDoneType value)
        {
            return value switch
            {
                RealtimeResponseOutputItemDoneType.ResponseOutputItemDone => "response.output_item.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseOutputItemDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_item.done" => RealtimeResponseOutputItemDoneType.ResponseOutputItemDone,
                _ => null,
            };
        }
    }
}