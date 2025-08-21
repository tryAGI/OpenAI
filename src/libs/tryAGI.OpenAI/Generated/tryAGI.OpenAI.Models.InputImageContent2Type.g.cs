
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the input item. Always `input_image`.<br/>
    /// Default Value: input_image
    /// </summary>
    public enum InputImageContent2Type
    {
        /// <summary>
        /// 
        /// </summary>
        InputImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputImageContent2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputImageContent2Type value)
        {
            return value switch
            {
                InputImageContent2Type.InputImage => "input_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputImageContent2Type? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => InputImageContent2Type.InputImage,
                _ => null,
            };
        }
    }
}