
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the input item. Always `input_image`.<br/>
    /// Default Value: input_image
    /// </summary>
    public enum InputImageContentParamAutoParamType
    {
        /// <summary>
        /// 
        /// </summary>
        InputImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputImageContentParamAutoParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputImageContentParamAutoParamType value)
        {
            return value switch
            {
                InputImageContentParamAutoParamType.InputImage => "input_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputImageContentParamAutoParamType? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => InputImageContentParamAutoParamType.InputImage,
                _ => null,
            };
        }
    }
}