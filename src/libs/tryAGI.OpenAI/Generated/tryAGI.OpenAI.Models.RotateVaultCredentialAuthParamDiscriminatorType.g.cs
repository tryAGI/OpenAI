
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum RotateVaultCredentialAuthParamDiscriminatorType
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
    public static class RotateVaultCredentialAuthParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RotateVaultCredentialAuthParamDiscriminatorType value)
        {
            return value switch
            {
                RotateVaultCredentialAuthParamDiscriminatorType.EnvironmentVariable => "environment_variable",
                RotateVaultCredentialAuthParamDiscriminatorType.McpOauth => "mcp_oauth",
                RotateVaultCredentialAuthParamDiscriminatorType.StaticBearer => "static_bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RotateVaultCredentialAuthParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "environment_variable" => RotateVaultCredentialAuthParamDiscriminatorType.EnvironmentVariable,
                "mcp_oauth" => RotateVaultCredentialAuthParamDiscriminatorType.McpOauth,
                "static_bearer" => RotateVaultCredentialAuthParamDiscriminatorType.StaticBearer,
                _ => null,
            };
        }
    }
}