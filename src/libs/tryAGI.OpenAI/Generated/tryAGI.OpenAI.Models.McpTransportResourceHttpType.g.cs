
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `http`.<br/>
    /// Default Value: http
    /// </summary>
    public enum McpTransportResourceHttpType
    {
        /// <summary>
        ///
        /// </summary>
        Http,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpTransportResourceHttpTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpTransportResourceHttpType value)
        {
            return value switch
            {
                McpTransportResourceHttpType.Http => "http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpTransportResourceHttpType? ToEnum(string value)
        {
            return value switch
            {
                "http" => McpTransportResourceHttpType.Http,
                _ => null,
            };
        }
    }
}