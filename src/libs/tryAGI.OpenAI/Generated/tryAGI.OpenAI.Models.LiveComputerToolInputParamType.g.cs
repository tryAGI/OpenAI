
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: computer
    /// </summary>
    public enum LiveComputerToolInputParamType
    {
        /// <summary>
        ///
        /// </summary>
        Computer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveComputerToolInputParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveComputerToolInputParamType value)
        {
            return value switch
            {
                LiveComputerToolInputParamType.Computer => "computer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveComputerToolInputParamType? ToEnum(string value)
        {
            return value switch
            {
                "computer" => LiveComputerToolInputParamType.Computer,
                _ => null,
            };
        }
    }
}