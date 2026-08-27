
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaInputContentDiscriminatorType
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
    public static class BetaInputContentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInputContentDiscriminatorType value)
        {
            return value switch
            {
                BetaInputContentDiscriminatorType.InputFile => "input_file",
                BetaInputContentDiscriminatorType.InputImage => "input_image",
                BetaInputContentDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInputContentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_file" => BetaInputContentDiscriminatorType.InputFile,
                "input_image" => BetaInputContentDiscriminatorType.InputImage,
                "input_text" => BetaInputContentDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}