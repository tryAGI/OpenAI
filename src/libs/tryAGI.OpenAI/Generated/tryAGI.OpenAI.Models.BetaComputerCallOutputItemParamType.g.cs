
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the computer tool call output. Always `computer_call_output`.<br/>
    /// Default Value: computer_call_output
    /// </summary>
    public enum BetaComputerCallOutputItemParamType
    {
        /// <summary>
        ///
        /// </summary>
        ComputerCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaComputerCallOutputItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComputerCallOutputItemParamType value)
        {
            return value switch
            {
                BetaComputerCallOutputItemParamType.ComputerCallOutput => "computer_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComputerCallOutputItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "computer_call_output" => BetaComputerCallOutputItemParamType.ComputerCallOutput,
                _ => null,
            };
        }
    }
}