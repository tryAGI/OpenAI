
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum CallableToolAllowedCaller
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
    public static class CallableToolAllowedCallerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallableToolAllowedCaller value)
        {
            return value switch
            {
                CallableToolAllowedCaller.Direct => "direct",
                CallableToolAllowedCaller.Programmatic => "programmatic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallableToolAllowedCaller? ToEnum(string value)
        {
            return value switch
            {
                "direct" => CallableToolAllowedCaller.Direct,
                "programmatic" => CallableToolAllowedCaller.Programmatic,
                _ => null,
            };
        }
    }
}