
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: direct
    /// </summary>
    public enum DirectToolCallCallerType
    {
        /// <summary>
        /// 
        /// </summary>
        Direct,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DirectToolCallCallerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DirectToolCallCallerType value)
        {
            return value switch
            {
                DirectToolCallCallerType.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DirectToolCallCallerType? ToEnum(string value)
        {
            return value switch
            {
                "direct" => DirectToolCallCallerType.Direct,
                _ => null,
            };
        }
    }
}