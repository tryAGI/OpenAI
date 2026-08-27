
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: program
    /// </summary>
    public enum BetaProgramToolCallCallerType
    {
        /// <summary>
        ///
        /// </summary>
        Program,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaProgramToolCallCallerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaProgramToolCallCallerType value)
        {
            return value switch
            {
                BetaProgramToolCallCallerType.Program => "program",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaProgramToolCallCallerType? ToEnum(string value)
        {
            return value switch
            {
                "program" => BetaProgramToolCallCallerType.Program,
                _ => null,
            };
        }
    }
}