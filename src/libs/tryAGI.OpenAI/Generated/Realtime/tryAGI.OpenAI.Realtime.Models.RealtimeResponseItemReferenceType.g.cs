
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// The type of this item. Always `item_reference`.
    /// </summary>
    public enum RealtimeResponseItemReferenceType
    {
        /// <summary>
        ///
        /// </summary>
        ItemReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseItemReferenceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseItemReferenceType value)
        {
            return value switch
            {
                RealtimeResponseItemReferenceType.ItemReference => "item_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseItemReferenceType? ToEnum(string value)
        {
            return value switch
            {
                "item_reference" => RealtimeResponseItemReferenceType.ItemReference,
                _ => null,
            };
        }
    }
}