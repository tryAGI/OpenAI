
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum PersistedMcpTransportResourceDiscriminatorType
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
    public static class PersistedMcpTransportResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PersistedMcpTransportResourceDiscriminatorType value)
        {
            return value switch
            {
                PersistedMcpTransportResourceDiscriminatorType.Http => "http",
                PersistedMcpTransportResourceDiscriminatorType.Stdio => "stdio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PersistedMcpTransportResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "http" => PersistedMcpTransportResourceDiscriminatorType.Http,
                "stdio" => PersistedMcpTransportResourceDiscriminatorType.Stdio,
                _ => null,
            };
        }
    }
}