
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum InputContentDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        InputFile,
        /// <summary>
        /// 
        /// </summary>
        InputImage,
        /// <summary>
        /// 
        /// </summary>
        InputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputContentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputContentDiscriminatorType value)
        {
            return value switch
            {
                InputContentDiscriminatorType.InputFile => "input_file",
                InputContentDiscriminatorType.InputImage => "input_image",
                InputContentDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputContentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_file" => InputContentDiscriminatorType.InputFile,
                "input_image" => InputContentDiscriminatorType.InputImage,
                "input_text" => InputContentDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}