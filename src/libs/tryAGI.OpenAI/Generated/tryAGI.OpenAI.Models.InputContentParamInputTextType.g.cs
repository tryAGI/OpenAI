
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `input_text`.<br/>
    /// Default Value: input_text
    /// </summary>
    public enum InputContentParamInputTextType
    {
        /// <summary>
        ///
        /// </summary>
        InputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputContentParamInputTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputContentParamInputTextType value)
        {
            return value switch
            {
                InputContentParamInputTextType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputContentParamInputTextType? ToEnum(string value)
        {
            return value switch
            {
                "input_text" => InputContentParamInputTextType.InputText,
                _ => null,
            };
        }
    }
}