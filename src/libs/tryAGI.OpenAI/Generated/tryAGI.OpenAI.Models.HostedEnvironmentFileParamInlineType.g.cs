
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `inline`.<br/>
    /// Default Value: inline
    /// </summary>
    public enum HostedEnvironmentFileParamInlineType
    {
        /// <summary>
        ///
        /// </summary>
        Inline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HostedEnvironmentFileParamInlineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HostedEnvironmentFileParamInlineType value)
        {
            return value switch
            {
                HostedEnvironmentFileParamInlineType.Inline => "inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HostedEnvironmentFileParamInlineType? ToEnum(string value)
        {
            return value switch
            {
                "inline" => HostedEnvironmentFileParamInlineType.Inline,
                _ => null,
            };
        }
    }
}