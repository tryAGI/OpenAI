
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaToolCallCallerDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Direct,
        /// <summary>
        /// 
        /// </summary>
        Program,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaToolCallCallerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaToolCallCallerDiscriminatorType value)
        {
            return value switch
            {
                BetaToolCallCallerDiscriminatorType.Direct => "direct",
                BetaToolCallCallerDiscriminatorType.Program => "program",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaToolCallCallerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "direct" => BetaToolCallCallerDiscriminatorType.Direct,
                "program" => BetaToolCallCallerDiscriminatorType.Program,
                _ => null,
            };
        }
    }
}