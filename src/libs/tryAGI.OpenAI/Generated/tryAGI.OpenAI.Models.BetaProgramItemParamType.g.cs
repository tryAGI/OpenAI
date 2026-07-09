
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `program`.<br/>
    /// Default Value: program
    /// </summary>
    public enum BetaProgramItemParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Program,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaProgramItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaProgramItemParamType value)
        {
            return value switch
            {
                BetaProgramItemParamType.Program => "program",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaProgramItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "program" => BetaProgramItemParamType.Program,
                _ => null,
            };
        }
    }
}