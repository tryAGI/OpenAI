
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum InlineCapabilitySourceParamDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Base64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InlineCapabilitySourceParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InlineCapabilitySourceParamDiscriminatorType value)
        {
            return value switch
            {
                InlineCapabilitySourceParamDiscriminatorType.Base64 => "base64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InlineCapabilitySourceParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => InlineCapabilitySourceParamDiscriminatorType.Base64,
                _ => null,
            };
        }
    }
}