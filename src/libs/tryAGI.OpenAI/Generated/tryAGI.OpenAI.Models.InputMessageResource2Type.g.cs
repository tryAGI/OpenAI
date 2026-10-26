
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the input item. Always `message`.<br/>
    /// Default Value: message
    /// </summary>
    public enum InputMessageResource2Type
    {
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputMessageResource2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputMessageResource2Type value)
        {
            return value switch
            {
                InputMessageResource2Type.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputMessageResource2Type? ToEnum(string value)
        {
            return value switch
            {
                "message" => InputMessageResource2Type.Message,
                _ => null,
            };
        }
    }
}