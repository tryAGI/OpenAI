
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `input_image`.<br/>
    /// Default Value: input_image
    /// </summary>
    public enum InputContentParamInputImageType
    {
        /// <summary>
        ///
        /// </summary>
        InputImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputContentParamInputImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputContentParamInputImageType value)
        {
            return value switch
            {
                InputContentParamInputImageType.InputImage => "input_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputContentParamInputImageType? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => InputContentParamInputImageType.InputImage,
                _ => null,
            };
        }
    }
}