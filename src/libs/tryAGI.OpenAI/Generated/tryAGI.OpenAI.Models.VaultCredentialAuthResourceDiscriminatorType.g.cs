
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum VaultCredentialAuthResourceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        EnvironmentVariable,
        /// <summary>
        ///
        /// </summary>
        McpOauth,
        /// <summary>
        ///
        /// </summary>
        StaticBearer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VaultCredentialAuthResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VaultCredentialAuthResourceDiscriminatorType value)
        {
            return value switch
            {
                VaultCredentialAuthResourceDiscriminatorType.EnvironmentVariable => "environment_variable",
                VaultCredentialAuthResourceDiscriminatorType.McpOauth => "mcp_oauth",
                VaultCredentialAuthResourceDiscriminatorType.StaticBearer => "static_bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VaultCredentialAuthResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "environment_variable" => VaultCredentialAuthResourceDiscriminatorType.EnvironmentVariable,
                "mcp_oauth" => VaultCredentialAuthResourceDiscriminatorType.McpOauth,
                "static_bearer" => VaultCredentialAuthResourceDiscriminatorType.StaticBearer,
                _ => null,
            };
        }
    }
}