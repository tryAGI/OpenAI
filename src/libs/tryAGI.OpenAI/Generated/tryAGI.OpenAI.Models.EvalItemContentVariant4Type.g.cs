
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the image input. Always `input_image`.
    /// </summary>
    public enum EvalItemContentVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        InputImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalItemContentVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalItemContentVariant4Type value)
        {
            return value switch
            {
                EvalItemContentVariant4Type.InputImage => "input_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalItemContentVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => EvalItemContentVariant4Type.InputImage,
                _ => null,
            };
        }
    }
}