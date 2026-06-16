
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The truncation strategy to use for the model response.<br/>
    /// - `auto`: If the input to this Response exceeds<br/>
    ///   the model's context window size, the model will truncate the<br/>
    ///   response to fit the context window by dropping items from the beginning of the conversation.<br/>
    /// - `disabled` (default): If the input size will exceed the context window<br/>
    ///   size for a model, the request will fail with a 400 error.<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CreateResponseVariant3Truncation2
    {
        /// <summary>
        /// If the input to this Response exceeds
        /// </summary>
        Auto,
        /// <summary>
        /// If the input size will exceed the context window
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateResponseVariant3Truncation2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResponseVariant3Truncation2 value)
        {
            return value switch
            {
                CreateResponseVariant3Truncation2.Auto => "auto",
                CreateResponseVariant3Truncation2.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResponseVariant3Truncation2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateResponseVariant3Truncation2.Auto,
                "disabled" => CreateResponseVariant3Truncation2.Disabled,
                _ => null,
            };
        }
    }
}