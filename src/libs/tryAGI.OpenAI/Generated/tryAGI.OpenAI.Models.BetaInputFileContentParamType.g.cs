
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the input item. Always `input_file`.<br/>
    /// Default Value: input_file
    /// </summary>
    public enum BetaInputFileContentParamType
    {
        /// <summary>
        ///
        /// </summary>
        InputFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaInputFileContentParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInputFileContentParamType value)
        {
            return value switch
            {
                BetaInputFileContentParamType.InputFile => "input_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInputFileContentParamType? ToEnum(string value)
        {
            return value switch
            {
                "input_file" => BetaInputFileContentParamType.InputFile,
                _ => null,
            };
        }
    }
}