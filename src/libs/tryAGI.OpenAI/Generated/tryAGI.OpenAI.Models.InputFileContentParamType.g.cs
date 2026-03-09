
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the input item. Always `input_file`.<br/>
    /// Default Value: input_file
    /// </summary>
    public enum InputFileContentParamType
    {
        /// <summary>
        /// 
        /// </summary>
        InputFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputFileContentParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputFileContentParamType value)
        {
            return value switch
            {
                InputFileContentParamType.InputFile => "input_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputFileContentParamType? ToEnum(string value)
        {
            return value switch
            {
                "input_file" => InputFileContentParamType.InputFile,
                _ => null,
            };
        }
    }
}