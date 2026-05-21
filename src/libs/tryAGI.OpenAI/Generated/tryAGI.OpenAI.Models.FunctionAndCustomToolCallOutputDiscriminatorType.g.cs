
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionAndCustomToolCallOutputDiscriminatorType
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
    public static class FunctionAndCustomToolCallOutputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionAndCustomToolCallOutputDiscriminatorType value)
        {
            return value switch
            {
                FunctionAndCustomToolCallOutputDiscriminatorType.InputFile => "input_file",
                FunctionAndCustomToolCallOutputDiscriminatorType.InputImage => "input_image",
                FunctionAndCustomToolCallOutputDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionAndCustomToolCallOutputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_file" => FunctionAndCustomToolCallOutputDiscriminatorType.InputFile,
                "input_image" => FunctionAndCustomToolCallOutputDiscriminatorType.InputImage,
                "input_text" => FunctionAndCustomToolCallOutputDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}