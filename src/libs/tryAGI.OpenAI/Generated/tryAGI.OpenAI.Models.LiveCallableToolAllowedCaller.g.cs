
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveCallableToolAllowedCaller
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
    public static class LiveCallableToolAllowedCallerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveCallableToolAllowedCaller value)
        {
            return value switch
            {
                LiveCallableToolAllowedCaller.Direct => "direct",
                LiveCallableToolAllowedCaller.Programmatic => "programmatic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveCallableToolAllowedCaller? ToEnum(string value)
        {
            return value switch
            {
                "direct" => LiveCallableToolAllowedCaller.Direct,
                "programmatic" => LiveCallableToolAllowedCaller.Programmatic,
                _ => null,
            };
        }
    }
}