
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `inline`.<br/>
    /// Default Value: inline
    /// </summary>
    public enum HostedTemplateFileResourceInlineType
    {
        /// <summary>
        ///
        /// </summary>
        Inline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HostedTemplateFileResourceInlineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HostedTemplateFileResourceInlineType value)
        {
            return value switch
            {
                HostedTemplateFileResourceInlineType.Inline => "inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HostedTemplateFileResourceInlineType? ToEnum(string value)
        {
            return value switch
            {
                "inline" => HostedTemplateFileResourceInlineType.Inline,
                _ => null,
            };
        }
    }
}