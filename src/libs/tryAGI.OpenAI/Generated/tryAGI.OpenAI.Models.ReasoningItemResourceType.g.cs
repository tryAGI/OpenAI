
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `reasoning`.<br/>
    /// Default Value: reasoning
    /// </summary>
    public enum ReasoningItemResourceType
    {
        /// <summary>
        ///
        /// </summary>
        Reasoning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningItemResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningItemResourceType value)
        {
            return value switch
            {
                ReasoningItemResourceType.Reasoning => "reasoning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningItemResourceType? ToEnum(string value)
        {
            return value switch
            {
                "reasoning" => ReasoningItemResourceType.Reasoning,
                _ => null,
            };
        }
    }
}