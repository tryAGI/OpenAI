
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of location approximation. Always `approximate`.<br/>
    /// Default Value: approximate
    /// </summary>
    public enum WebSearchApproximateLocationWebSearchApproximateLocation1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Approximate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchApproximateLocationWebSearchApproximateLocation1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchApproximateLocationWebSearchApproximateLocation1Type value)
        {
            return value switch
            {
                WebSearchApproximateLocationWebSearchApproximateLocation1Type.Approximate => "approximate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchApproximateLocationWebSearchApproximateLocation1Type? ToEnum(string value)
        {
            return value switch
            {
                "approximate" => WebSearchApproximateLocationWebSearchApproximateLocation1Type.Approximate,
                _ => null,
            };
        }
    }
}