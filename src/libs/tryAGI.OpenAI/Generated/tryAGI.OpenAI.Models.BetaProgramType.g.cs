
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `program`.<br/>
    /// Default Value: program
    /// </summary>
    public enum BetaProgramType
    {
        /// <summary>
        ///
        /// </summary>
        Program,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaProgramTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaProgramType value)
        {
            return value switch
            {
                BetaProgramType.Program => "program",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaProgramType? ToEnum(string value)
        {
            return value switch
            {
                "program" => BetaProgramType.Program,
                _ => null,
            };
        }
    }
}