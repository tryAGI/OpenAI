
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum HostedPluginParamDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Inline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HostedPluginParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HostedPluginParamDiscriminatorType value)
        {
            return value switch
            {
                HostedPluginParamDiscriminatorType.Inline => "inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HostedPluginParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "inline" => HostedPluginParamDiscriminatorType.Inline,
                _ => null,
            };
        }
    }
}