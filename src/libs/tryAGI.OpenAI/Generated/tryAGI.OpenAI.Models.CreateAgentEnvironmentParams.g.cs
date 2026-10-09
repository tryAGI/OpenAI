
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Parameters for creating an execution environment before its sessions.
    /// </summary>
    public sealed partial class CreateAgentEnvironmentParams
    {
        /// <summary>
        /// The required hosting type and its configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.CreateEnvironmentParamOpenaiHosted Environment { get; set; }

        /// <summary>
        /// The IDs of up to 10 vaults made available to an OpenAI-hosted environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_ids")]
        public global::System.Collections.Generic.IList<string>? VaultIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentEnvironmentParams" /> class.
        /// </summary>
        /// <param name="environment">
        /// The required hosting type and its configuration.
        /// </param>
        /// <param name="vaultIds">
        /// The IDs of up to 10 vaults made available to an OpenAI-hosted environment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentEnvironmentParams(
            global::tryAGI.OpenAI.CreateEnvironmentParamOpenaiHosted environment,
            global::System.Collections.Generic.IList<string>? vaultIds)
        {
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
            this.VaultIds = vaultIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentEnvironmentParams" /> class.
        /// </summary>
        public CreateAgentEnvironmentParams()
        {
        }

    }
}