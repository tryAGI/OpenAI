
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
    public enum ResponsePropertiesTruncation
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
    public static class ResponsePropertiesTruncationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsePropertiesTruncation value)
        {
            return value switch
            {
                ResponsePropertiesTruncation.Auto => "auto",
                ResponsePropertiesTruncation.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsePropertiesTruncation? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResponsePropertiesTruncation.Auto,
                "disabled" => ResponsePropertiesTruncation.Disabled,
                _ => null,
            };
        }
    }
}