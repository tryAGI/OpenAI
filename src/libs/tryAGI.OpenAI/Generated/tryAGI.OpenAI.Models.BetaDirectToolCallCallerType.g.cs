
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: direct
    /// </summary>
    public enum BetaDirectToolCallCallerType
    {
        /// <summary>
        /// 
        /// </summary>
        Direct,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaDirectToolCallCallerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaDirectToolCallCallerType value)
        {
            return value switch
            {
                BetaDirectToolCallCallerType.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaDirectToolCallCallerType? ToEnum(string value)
        {
            return value switch
            {
                "direct" => BetaDirectToolCallCallerType.Direct,
                _ => null,
            };
        }
    }
}