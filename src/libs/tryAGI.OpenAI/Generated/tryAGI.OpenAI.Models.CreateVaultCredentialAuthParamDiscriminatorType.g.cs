
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateVaultCredentialAuthParamDiscriminatorType
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
    public static class CreateVaultCredentialAuthParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVaultCredentialAuthParamDiscriminatorType value)
        {
            return value switch
            {
                CreateVaultCredentialAuthParamDiscriminatorType.EnvironmentVariable => "environment_variable",
                CreateVaultCredentialAuthParamDiscriminatorType.McpOauth => "mcp_oauth",
                CreateVaultCredentialAuthParamDiscriminatorType.StaticBearer => "static_bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVaultCredentialAuthParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "environment_variable" => CreateVaultCredentialAuthParamDiscriminatorType.EnvironmentVariable,
                "mcp_oauth" => CreateVaultCredentialAuthParamDiscriminatorType.McpOauth,
                "static_bearer" => CreateVaultCredentialAuthParamDiscriminatorType.StaticBearer,
                _ => null,
            };
        }
    }
}