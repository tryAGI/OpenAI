
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the image input. Always `input_image`.
    /// </summary>
    public enum EvalItemInputImageType
    {
        /// <summary>
        /// 
        /// </summary>
        InputImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalItemInputImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalItemInputImageType value)
        {
            return value switch
            {
                EvalItemInputImageType.InputImage => "input_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalItemInputImageType? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => EvalItemInputImageType.InputImage,
                _ => null,
            };
        }
    }
}