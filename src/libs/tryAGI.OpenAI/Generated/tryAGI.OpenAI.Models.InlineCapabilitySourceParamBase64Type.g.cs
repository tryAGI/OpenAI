
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `base64`.<br/>
    /// Default Value: base64
    /// </summary>
    public enum InlineCapabilitySourceParamBase64Type
    {
        /// <summary>
        ///
        /// </summary>
        Base64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InlineCapabilitySourceParamBase64TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InlineCapabilitySourceParamBase64Type value)
        {
            return value switch
            {
                InlineCapabilitySourceParamBase64Type.Base64 => "base64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InlineCapabilitySourceParamBase64Type? ToEnum(string value)
        {
            return value switch
            {
                "base64" => InlineCapabilitySourceParamBase64Type.Base64,
                _ => null,
            };
        }
    }
}