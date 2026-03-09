
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the input item. Always `input_text`.<br/>
    /// Default Value: input_text
    /// </summary>
    public enum InputTextContentParamType
    {
        /// <summary>
        /// 
        /// </summary>
        InputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputTextContentParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputTextContentParamType value)
        {
            return value switch
            {
                InputTextContentParamType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputTextContentParamType? ToEnum(string value)
        {
            return value switch
            {
                "input_text" => InputTextContentParamType.InputText,
                _ => null,
            };
        }
    }
}