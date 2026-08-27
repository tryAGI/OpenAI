
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaCallableToolAllowedCaller
    {
        /// <summary>
        ///
        /// </summary>
        Direct,
        /// <summary>
        ///
        /// </summary>
        Programmatic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCallableToolAllowedCallerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCallableToolAllowedCaller value)
        {
            return value switch
            {
                BetaCallableToolAllowedCaller.Direct => "direct",
                BetaCallableToolAllowedCaller.Programmatic => "programmatic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCallableToolAllowedCaller? ToEnum(string value)
        {
            return value switch
            {
                "direct" => BetaCallableToolAllowedCaller.Direct,
                "programmatic" => BetaCallableToolAllowedCaller.Programmatic,
                _ => null,
            };
        }
    }
}