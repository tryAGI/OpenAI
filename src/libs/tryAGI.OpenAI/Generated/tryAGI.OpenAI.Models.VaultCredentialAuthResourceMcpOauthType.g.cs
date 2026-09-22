
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `mcp_oauth`.<br/>
    /// Default Value: mcp_oauth
    /// </summary>
    public enum VaultCredentialAuthResourceMcpOauthType
    {
        /// <summary>
        ///
        /// </summary>
        McpOauth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VaultCredentialAuthResourceMcpOauthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VaultCredentialAuthResourceMcpOauthType value)
        {
            return value switch
            {
                VaultCredentialAuthResourceMcpOauthType.McpOauth => "mcp_oauth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VaultCredentialAuthResourceMcpOauthType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_oauth" => VaultCredentialAuthResourceMcpOauthType.McpOauth,
                _ => null,
            };
        }
    }
}