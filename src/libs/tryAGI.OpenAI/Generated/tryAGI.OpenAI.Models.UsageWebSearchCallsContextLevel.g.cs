
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsageWebSearchCallsContextLevel
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageWebSearchCallsContextLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageWebSearchCallsContextLevel value)
        {
            return value switch
            {
                UsageWebSearchCallsContextLevel.High => "high",
                UsageWebSearchCallsContextLevel.Low => "low",
                UsageWebSearchCallsContextLevel.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageWebSearchCallsContextLevel? ToEnum(string value)
        {
            return value switch
            {
                "high" => UsageWebSearchCallsContextLevel.High,
                "low" => UsageWebSearchCallsContextLevel.Low,
                "medium" => UsageWebSearchCallsContextLevel.Medium,
                _ => null,
            };
        }
    }
}