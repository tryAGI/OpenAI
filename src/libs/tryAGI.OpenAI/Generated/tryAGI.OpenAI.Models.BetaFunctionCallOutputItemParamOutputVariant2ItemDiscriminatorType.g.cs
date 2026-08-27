
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType
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
    public static class BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType.InputFile => "input_file",
                BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType.InputImage => "input_image",
                BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_file" => BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType.InputFile,
                "input_image" => BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType.InputImage,
                "input_text" => BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}