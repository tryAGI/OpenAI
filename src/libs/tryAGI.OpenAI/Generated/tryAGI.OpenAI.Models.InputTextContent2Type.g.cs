
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the input item. Always `input_text`.<br/>
    /// Default Value: input_text
    /// </summary>
    public enum InputTextContent2Type
    {
        /// <summary>
        /// 
        /// </summary>
        InputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputTextContent2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputTextContent2Type value)
        {
            return value switch
            {
                InputTextContent2Type.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputTextContent2Type? ToEnum(string value)
        {
            return value switch
            {
                "input_text" => InputTextContent2Type.InputText,
                _ => null,
            };
        }
    }
}