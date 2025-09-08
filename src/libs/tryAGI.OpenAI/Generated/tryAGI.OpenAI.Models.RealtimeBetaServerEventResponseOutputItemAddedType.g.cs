
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `response.output_item.added`.
    /// </summary>
    public enum RealtimeBetaServerEventResponseOutputItemAddedType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputItemAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventResponseOutputItemAddedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventResponseOutputItemAddedType value)
        {
            return value switch
            {
                RealtimeBetaServerEventResponseOutputItemAddedType.ResponseOutputItemAdded => "response.output_item.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventResponseOutputItemAddedType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_item.added" => RealtimeBetaServerEventResponseOutputItemAddedType.ResponseOutputItemAdded,
                _ => null,
            };
        }
    }
}