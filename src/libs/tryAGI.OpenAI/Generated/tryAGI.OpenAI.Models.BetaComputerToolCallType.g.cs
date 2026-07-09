
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the computer call. Always `computer_call`.<br/>
    /// Default Value: computer_call
    /// </summary>
    public enum BetaComputerToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        ComputerCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaComputerToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComputerToolCallType value)
        {
            return value switch
            {
                BetaComputerToolCallType.ComputerCall => "computer_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComputerToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "computer_call" => BetaComputerToolCallType.ComputerCall,
                _ => null,
            };
        }
    }
}