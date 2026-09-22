
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Metadata for an HTTP credential used only in OpenAI-hosted environments. Sandbox code receives a placeholder. The proxy substitutes the secret for allowed HTTPS destinations on ports 443 and 8443. The real secret is not available to sandbox code for local computation and is never returned in this resource.
    /// </summary>
    public sealed partial class VaultCredentialAuthResourceEnvironmentVariable
    {
        /// <summary>
        /// The type of the object. Always `environment_variable`.<br/>
        /// Default Value: environment_variable
        /// </summary>
        /// <default>global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariableType.EnvironmentVariable</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VaultCredentialAuthResourceEnvironmentVariableTypeJsonConverter))]
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariableType Type { get; set; } = global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariableType.EnvironmentVariable;

        /// <summary>
        /// The environment variable name that receives the placeholder in the sandbox.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretName { get; set; }

        /// <summary>
        /// The destinations where the proxy can substitute the secret, subject to the environment network policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.VaultCredentialNetworkingResource Networking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultCredentialAuthResourceEnvironmentVariable" /> class.
        /// </summary>
        /// <param name="secretName">
        /// The environment variable name that receives the placeholder in the sandbox.
        /// </param>
        /// <param name="networking">
        /// The destinations where the proxy can substitute the secret, subject to the environment network policy.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `environment_variable`.<br/>
        /// Default Value: environment_variable
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultCredentialAuthResourceEnvironmentVariable(
            string secretName,
            global::tryAGI.OpenAI.VaultCredentialNetworkingResource networking,
            global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariableType type = global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariableType.EnvironmentVariable)
        {
            this.Type = type;
            this.SecretName = secretName ?? throw new global::System.ArgumentNullException(nameof(secretName));
            this.Networking = networking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultCredentialAuthResourceEnvironmentVariable" /> class.
        /// </summary>
        public VaultCredentialAuthResourceEnvironmentVariable()
        {
        }

    }
}