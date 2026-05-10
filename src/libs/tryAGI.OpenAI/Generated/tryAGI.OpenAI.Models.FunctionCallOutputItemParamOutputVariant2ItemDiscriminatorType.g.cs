
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType
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
    public static class FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType.InputFile => "input_file",
                FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType.InputImage => "input_image",
                FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_file" => FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType.InputFile,
                "input_image" => FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType.InputImage,
                "input_text" => FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}