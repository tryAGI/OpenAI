
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Replace the secret for an OpenAI-hosted environment credential. The environment variable name and networking configuration remain unchanged.
    /// </summary>
    public sealed partial class RotateVaultCredentialAuthParamEnvironmentVariable
    {
        /// <summary>
        /// The type of the object. Always `environment_variable`.<br/>
        /// Default Value: environment_variable
        /// </summary>
        /// <default>global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariableType.EnvironmentVariable</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RotateVaultCredentialAuthParamEnvironmentVariableTypeJsonConverter))]
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariableType Type { get; set; } = global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariableType.EnvironmentVariable;

        /// <summary>
        /// The write-only replacement secret. Never returned in credential resources or supplied directly to sandbox code. Must be nonempty and must not contain carriage returns, newlines, or NUL bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateVaultCredentialAuthParamEnvironmentVariable" /> class.
        /// </summary>
        /// <param name="secretValue">
        /// The write-only replacement secret. Never returned in credential resources or supplied directly to sandbox code. Must be nonempty and must not contain carriage returns, newlines, or NUL bytes.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `environment_variable`.<br/>
        /// Default Value: environment_variable
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RotateVaultCredentialAuthParamEnvironmentVariable(
            string secretValue,
            global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariableType type = global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariableType.EnvironmentVariable)
        {
            this.Type = type;
            this.SecretValue = secretValue ?? throw new global::System.ArgumentNullException(nameof(secretValue));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateVaultCredentialAuthParamEnvironmentVariable" /> class.
        /// </summary>
        public RotateVaultCredentialAuthParamEnvironmentVariable()
        {
        }

        /// <summary>
        /// Creates a new <see cref="RotateVaultCredentialAuthParamEnvironmentVariable"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static RotateVaultCredentialAuthParamEnvironmentVariable FromSecretValue(string secretValue)
        {
            return new RotateVaultCredentialAuthParamEnvironmentVariable
            {
                SecretValue = secretValue,
            };
        }

    }
}