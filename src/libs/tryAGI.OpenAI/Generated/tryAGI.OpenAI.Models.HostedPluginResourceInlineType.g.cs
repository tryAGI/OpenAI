
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `inline`.<br/>
    /// Default Value: inline
    /// </summary>
    public enum HostedPluginResourceInlineType
    {
        /// <summary>
        ///
        /// </summary>
        Inline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HostedPluginResourceInlineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HostedPluginResourceInlineType value)
        {
            return value switch
            {
                HostedPluginResourceInlineType.Inline => "inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HostedPluginResourceInlineType? ToEnum(string value)
        {
            return value switch
            {
                "inline" => HostedPluginResourceInlineType.Inline,
                _ => null,
            };
        }
    }
}