
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be "response.output_item.added".<br/>
    /// Example: response.output_item.added
    /// </summary>
    public enum RealtimeResponseOutputItemAddedType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputItemAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseOutputItemAddedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseOutputItemAddedType value)
        {
            return value switch
            {
                RealtimeResponseOutputItemAddedType.ResponseOutputItemAdded => "response.output_item.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseOutputItemAddedType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_item.added" => RealtimeResponseOutputItemAddedType.ResponseOutputItemAdded,
                _ => null,
            };
        }
    }
}