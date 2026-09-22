
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `none`.<br/>
    /// Default Value: none
    /// </summary>
    public enum McpOauthTokenEndpointAuthResourceNoneType
    {
        /// <summary>
        ///
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpOauthTokenEndpointAuthResourceNoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpOauthTokenEndpointAuthResourceNoneType value)
        {
            return value switch
            {
                McpOauthTokenEndpointAuthResourceNoneType.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpOauthTokenEndpointAuthResourceNoneType? ToEnum(string value)
        {
            return value switch
            {
                "none" => McpOauthTokenEndpointAuthResourceNoneType.None,
                _ => null,
            };
        }
    }
}