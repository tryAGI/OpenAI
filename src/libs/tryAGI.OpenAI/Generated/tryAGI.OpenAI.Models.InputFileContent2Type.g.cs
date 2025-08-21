
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the input item. Always `input_file`.<br/>
    /// Default Value: input_file
    /// </summary>
    public enum InputFileContent2Type
    {
        /// <summary>
        /// 
        /// </summary>
        InputFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputFileContent2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputFileContent2Type value)
        {
            return value switch
            {
                InputFileContent2Type.InputFile => "input_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputFileContent2Type? ToEnum(string value)
        {
            return value switch
            {
                "input_file" => InputFileContent2Type.InputFile,
                _ => null,
            };
        }
    }
}