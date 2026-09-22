
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The archive media type, always `application/zip`.<br/>
    /// Default Value: application/zip
    /// </summary>
    public enum InlineCapabilitySourceParamBase64MediaType
    {
        /// <summary>
        ///
        /// </summary>
        ApplicationZip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InlineCapabilitySourceParamBase64MediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InlineCapabilitySourceParamBase64MediaType value)
        {
            return value switch
            {
                InlineCapabilitySourceParamBase64MediaType.ApplicationZip => "application/zip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InlineCapabilitySourceParamBase64MediaType? ToEnum(string value)
        {
            return value switch
            {
                "application/zip" => InlineCapabilitySourceParamBase64MediaType.ApplicationZip,
                _ => null,
            };
        }
    }
}