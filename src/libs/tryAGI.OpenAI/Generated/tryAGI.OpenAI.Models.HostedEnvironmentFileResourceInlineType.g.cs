
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `inline`.<br/>
    /// Default Value: inline
    /// </summary>
    public enum HostedEnvironmentFileResourceInlineType
    {
        /// <summary>
        ///
        /// </summary>
        Inline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HostedEnvironmentFileResourceInlineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HostedEnvironmentFileResourceInlineType value)
        {
            return value switch
            {
                HostedEnvironmentFileResourceInlineType.Inline => "inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HostedEnvironmentFileResourceInlineType? ToEnum(string value)
        {
            return value switch
            {
                "inline" => HostedEnvironmentFileResourceInlineType.Inline,
                _ => null,
            };
        }
    }
}