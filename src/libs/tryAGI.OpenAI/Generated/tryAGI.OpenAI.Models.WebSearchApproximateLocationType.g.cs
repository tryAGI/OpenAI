
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of location approximation. Always `approximate`.<br/>
    /// Default Value: approximate
    /// </summary>
    public enum WebSearchApproximateLocationType
    {
        /// <summary>
        /// 
        /// </summary>
        Approximate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchApproximateLocationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchApproximateLocationType value)
        {
            return value switch
            {
                WebSearchApproximateLocationType.Approximate => "approximate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchApproximateLocationType? ToEnum(string value)
        {
            return value switch
            {
                "approximate" => WebSearchApproximateLocationType.Approximate,
                _ => null,
            };
        }
    }
}