
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DefaultPermissions
    {
        /// <summary>
        /// Default Value: service_account_default
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DefaultPermissionsType.ServiceAccountDefault</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DefaultPermissionsTypeJsonConverter))]
        public global::tryAGI.OpenAI.DefaultPermissionsType Type { get; set; } = global::tryAGI.OpenAI.DefaultPermissionsType.ServiceAccountDefault;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultPermissions" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: service_account_default
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DefaultPermissions(
            global::tryAGI.OpenAI.DefaultPermissionsType type = global::tryAGI.OpenAI.DefaultPermissionsType.ServiceAccountDefault)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultPermissions" /> class.
        /// </summary>
        public DefaultPermissions()
        {
        }

    }
}