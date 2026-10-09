
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The tool to call. Always `computer`.<br/>
    /// Default Value: computer
    /// </summary>
    public enum LiveSpecificComputerParamType
    {
        /// <summary>
        ///
        /// </summary>
        Computer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSpecificComputerParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSpecificComputerParamType value)
        {
            return value switch
            {
                LiveSpecificComputerParamType.Computer => "computer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSpecificComputerParamType? ToEnum(string value)
        {
            return value switch
            {
                "computer" => LiveSpecificComputerParamType.Computer,
                _ => null,
            };
        }
    }
}