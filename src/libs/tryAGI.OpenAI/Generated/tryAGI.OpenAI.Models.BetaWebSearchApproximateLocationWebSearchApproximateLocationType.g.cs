
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of location approximation. Always `approximate`.<br/>
    /// Default Value: approximate
    /// </summary>
    public enum BetaWebSearchApproximateLocationWebSearchApproximateLocationType
    {
        /// <summary>
        /// 
        /// </summary>
        Approximate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaWebSearchApproximateLocationWebSearchApproximateLocationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWebSearchApproximateLocationWebSearchApproximateLocationType value)
        {
            return value switch
            {
                BetaWebSearchApproximateLocationWebSearchApproximateLocationType.Approximate => "approximate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWebSearchApproximateLocationWebSearchApproximateLocationType? ToEnum(string value)
        {
            return value switch
            {
                "approximate" => BetaWebSearchApproximateLocationWebSearchApproximateLocationType.Approximate,
                _ => null,
            };
        }
    }
}