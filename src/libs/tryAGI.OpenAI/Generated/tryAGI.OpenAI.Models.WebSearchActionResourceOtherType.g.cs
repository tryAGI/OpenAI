
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `other`.<br/>
    /// Default Value: other
    /// </summary>
    public enum WebSearchActionResourceOtherType
    {
        /// <summary>
        ///
        /// </summary>
        Other,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchActionResourceOtherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchActionResourceOtherType value)
        {
            return value switch
            {
                WebSearchActionResourceOtherType.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchActionResourceOtherType? ToEnum(string value)
        {
            return value switch
            {
                "other" => WebSearchActionResourceOtherType.Other,
                _ => null,
            };
        }
    }
}