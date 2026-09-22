
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum InputContentParamDiscriminatorType
    {
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
    public static class InputContentParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputContentParamDiscriminatorType value)
        {
            return value switch
            {
                InputContentParamDiscriminatorType.InputImage => "input_image",
                InputContentParamDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputContentParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => InputContentParamDiscriminatorType.InputImage,
                "input_text" => InputContentParamDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}