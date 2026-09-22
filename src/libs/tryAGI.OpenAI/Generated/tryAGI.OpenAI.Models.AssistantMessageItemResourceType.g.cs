
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `message`.<br/>
    /// Default Value: message
    /// </summary>
    public enum AssistantMessageItemResourceType
    {
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantMessageItemResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantMessageItemResourceType value)
        {
            return value switch
            {
                AssistantMessageItemResourceType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantMessageItemResourceType? ToEnum(string value)
        {
            return value switch
            {
                "message" => AssistantMessageItemResourceType.Message,
                _ => null,
            };
        }
    }
}