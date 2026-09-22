
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum UserMessageItemParamContentVariant1ItemDiscriminatorType
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
    public static class UserMessageItemParamContentVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserMessageItemParamContentVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                UserMessageItemParamContentVariant1ItemDiscriminatorType.InputFile => "input_file",
                UserMessageItemParamContentVariant1ItemDiscriminatorType.InputImage => "input_image",
                UserMessageItemParamContentVariant1ItemDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserMessageItemParamContentVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_file" => UserMessageItemParamContentVariant1ItemDiscriminatorType.InputFile,
                "input_image" => UserMessageItemParamContentVariant1ItemDiscriminatorType.InputImage,
                "input_text" => UserMessageItemParamContentVariant1ItemDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}