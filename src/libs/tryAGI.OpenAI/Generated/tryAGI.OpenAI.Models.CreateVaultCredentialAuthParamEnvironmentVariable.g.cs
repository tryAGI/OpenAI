
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An HTTP credential for OpenAI-hosted environments only. The sandbox receives an environment variable containing a placeholder, not the secret. Use the placeholder unchanged in outgoing requests. The egress proxy replaces the placeholder with the secret for allowed HTTPS destinations on ports 443 and 8443. Sandbox code cannot read the real secret or use it for local computation, such as signing a request.
    /// </summary>
    public sealed partial class CreateVaultCredentialAuthParamEnvironmentVariable
    {
        /// <summary>
        /// The type of the object. Always `environment_variable`.<br/>
        /// Default Value: environment_variable
        /// </summary>
        /// <default>global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariableType.EnvironmentVariable</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateVaultCredentialAuthParamEnvironmentVariableTypeJsonConverter))]
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariableType Type { get; set; } = global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariableType.EnvironmentVariable;

        /// <summary>
        /// The environment variable name that receives the placeholder, such as `SERVICE_API_KEY`. Use ASCII letters, digits, and underscores, starting with a letter or underscore. Names starting with `CODEX_` and managed proxy or certificate variable names are reserved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretName { get; set; }

        /// <summary>
        /// The write-only secret to store. Never returned in credential resources or supplied directly to sandbox code. Must be nonempty and must not contain carriage returns, newlines, or NUL bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretValue { get; set; }

        /// <summary>
        /// The destinations where the proxy can substitute this secret. The environment network policy must also allow them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingParamJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.VaultCredentialNetworkingParam Networking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVaultCredentialAuthParamEnvironmentVariable" /> class.
        /// </summary>
        /// <param name="secretName">
        /// The environment variable name that receives the placeholder, such as `SERVICE_API_KEY`. Use ASCII letters, digits, and underscores, starting with a letter or underscore. Names starting with `CODEX_` and managed proxy or certificate variable names are reserved.
        /// </param>
        /// <param name="secretValue">
        /// The write-only secret to store. Never returned in credential resources or supplied directly to sandbox code. Must be nonempty and must not contain carriage returns, newlines, or NUL bytes.
        /// </param>
        /// <param name="networking">
        /// The destinations where the proxy can substitute this secret. The environment network policy must also allow them.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `environment_variable`.<br/>
        /// Default Value: environment_variable
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVaultCredentialAuthParamEnvironmentVariable(
            string secretName,
            string secretValue,
            global::tryAGI.OpenAI.VaultCredentialNetworkingParam networking,
            global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariableType type = global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariableType.EnvironmentVariable)
        {
            this.Type = type;
            this.SecretName = secretName ?? throw new global::System.ArgumentNullException(nameof(secretName));
            this.SecretValue = secretValue ?? throw new global::System.ArgumentNullException(nameof(secretValue));
            this.Networking = networking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVaultCredentialAuthParamEnvironmentVariable" /> class.
        /// </summary>
        public CreateVaultCredentialAuthParamEnvironmentVariable()
        {
        }

    }
}