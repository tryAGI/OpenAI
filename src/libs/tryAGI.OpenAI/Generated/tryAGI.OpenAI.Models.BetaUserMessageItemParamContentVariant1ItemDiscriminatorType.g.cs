
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaUserMessageItemParamContentVariant1ItemDiscriminatorType
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
    public static class BetaUserMessageItemParamContentVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaUserMessageItemParamContentVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                BetaUserMessageItemParamContentVariant1ItemDiscriminatorType.InputFile => "input_file",
                BetaUserMessageItemParamContentVariant1ItemDiscriminatorType.InputImage => "input_image",
                BetaUserMessageItemParamContentVariant1ItemDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaUserMessageItemParamContentVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_file" => BetaUserMessageItemParamContentVariant1ItemDiscriminatorType.InputFile,
                "input_image" => BetaUserMessageItemParamContentVariant1ItemDiscriminatorType.InputImage,
                "input_text" => BetaUserMessageItemParamContentVariant1ItemDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}