
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Always `refusal`.
    /// </summary>
    public enum MessageContentRefusalObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        Refusal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageContentRefusalObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageContentRefusalObjectType value)
        {
            return value switch
            {
                MessageContentRefusalObjectType.Refusal => "refusal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageContentRefusalObjectType? ToEnum(string value)
        {
            return value switch
            {
                "refusal" => MessageContentRefusalObjectType.Refusal,
                _ => null,
            };
        }
    }
}