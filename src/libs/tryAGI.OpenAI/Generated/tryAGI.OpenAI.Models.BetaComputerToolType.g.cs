
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the computer tool. Always `computer`.<br/>
    /// Default Value: computer
    /// </summary>
    public enum BetaComputerToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Computer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaComputerToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComputerToolType value)
        {
            return value switch
            {
                BetaComputerToolType.Computer => "computer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComputerToolType? ToEnum(string value)
        {
            return value switch
            {
                "computer" => BetaComputerToolType.Computer,
                _ => null,
            };
        }
    }
}