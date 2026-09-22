
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `http`.<br/>
    /// Default Value: http
    /// </summary>
    public enum McpTransportConfigParamHttpType
    {
        /// <summary>
        ///
        /// </summary>
        Http,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpTransportConfigParamHttpTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpTransportConfigParamHttpType value)
        {
            return value switch
            {
                McpTransportConfigParamHttpType.Http => "http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpTransportConfigParamHttpType? ToEnum(string value)
        {
            return value switch
            {
                "http" => McpTransportConfigParamHttpType.Http,
                _ => null,
            };
        }
    }
}