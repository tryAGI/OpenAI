
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `environment_variable`.<br/>
    /// Default Value: environment_variable
    /// </summary>
    public enum CreateVaultCredentialAuthParamEnvironmentVariableType
    {
        /// <summary>
        ///
        /// </summary>
        EnvironmentVariable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVaultCredentialAuthParamEnvironmentVariableTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVaultCredentialAuthParamEnvironmentVariableType value)
        {
            return value switch
            {
                CreateVaultCredentialAuthParamEnvironmentVariableType.EnvironmentVariable => "environment_variable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVaultCredentialAuthParamEnvironmentVariableType? ToEnum(string value)
        {
            return value switch
            {
                "environment_variable" => CreateVaultCredentialAuthParamEnvironmentVariableType.EnvironmentVariable,
                _ => null,
            };
        }
    }
}