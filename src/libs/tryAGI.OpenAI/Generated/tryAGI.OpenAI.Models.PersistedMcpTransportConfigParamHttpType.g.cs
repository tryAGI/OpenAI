
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `http`.<br/>
    /// Default Value: http
    /// </summary>
    public enum PersistedMcpTransportConfigParamHttpType
    {
        /// <summary>
        ///
        /// </summary>
        Http,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PersistedMcpTransportConfigParamHttpTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PersistedMcpTransportConfigParamHttpType value)
        {
            return value switch
            {
                PersistedMcpTransportConfigParamHttpType.Http => "http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PersistedMcpTransportConfigParamHttpType? ToEnum(string value)
        {
            return value switch
            {
                "http" => PersistedMcpTransportConfigParamHttpType.Http,
                _ => null,
            };
        }
    }
}