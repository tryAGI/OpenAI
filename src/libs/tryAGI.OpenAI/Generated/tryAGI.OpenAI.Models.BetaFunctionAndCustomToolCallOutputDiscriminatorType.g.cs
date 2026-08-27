
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaFunctionAndCustomToolCallOutputDiscriminatorType
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
    public static class BetaFunctionAndCustomToolCallOutputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFunctionAndCustomToolCallOutputDiscriminatorType value)
        {
            return value switch
            {
                BetaFunctionAndCustomToolCallOutputDiscriminatorType.InputFile => "input_file",
                BetaFunctionAndCustomToolCallOutputDiscriminatorType.InputImage => "input_image",
                BetaFunctionAndCustomToolCallOutputDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFunctionAndCustomToolCallOutputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_file" => BetaFunctionAndCustomToolCallOutputDiscriminatorType.InputFile,
                "input_image" => BetaFunctionAndCustomToolCallOutputDiscriminatorType.InputImage,
                "input_text" => BetaFunctionAndCustomToolCallOutputDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}