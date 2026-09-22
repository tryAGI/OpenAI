
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum PersistedMcpTransportConfigParamDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Http,
        /// <summary>
        ///
        /// </summary>
        Stdio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PersistedMcpTransportConfigParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PersistedMcpTransportConfigParamDiscriminatorType value)
        {
            return value switch
            {
                PersistedMcpTransportConfigParamDiscriminatorType.Http => "http",
                PersistedMcpTransportConfigParamDiscriminatorType.Stdio => "stdio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PersistedMcpTransportConfigParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "http" => PersistedMcpTransportConfigParamDiscriminatorType.Http,
                "stdio" => PersistedMcpTransportConfigParamDiscriminatorType.Stdio,
                _ => null,
            };
        }
    }
}