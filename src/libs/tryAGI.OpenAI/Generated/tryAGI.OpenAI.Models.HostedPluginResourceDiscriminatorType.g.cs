
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum HostedPluginResourceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Inline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HostedPluginResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HostedPluginResourceDiscriminatorType value)
        {
            return value switch
            {
                HostedPluginResourceDiscriminatorType.Inline => "inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HostedPluginResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "inline" => HostedPluginResourceDiscriminatorType.Inline,
                _ => null,
            };
        }
    }
}