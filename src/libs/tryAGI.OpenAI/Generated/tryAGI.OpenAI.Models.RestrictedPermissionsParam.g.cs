
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RestrictedPermissionsParam
    {
        /// <summary>
        /// Default Value: restricted
        /// </summary>
        /// <default>global::tryAGI.OpenAI.RestrictedPermissionsParamType.Restricted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RestrictedPermissionsParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.RestrictedPermissionsParamType Type { get; set; } = global::tryAGI.OpenAI.RestrictedPermissionsParamType.Restricted;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictedPermissionsParam" /> class.
        /// </summary>
        /// <param name="scopes"></param>
        /// <param name="type">
        /// Default Value: restricted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RestrictedPermissionsParam(
            global::System.Collections.Generic.IList<string> scopes,
            global::tryAGI.OpenAI.RestrictedPermissionsParamType type = global::tryAGI.OpenAI.RestrictedPermissionsParamType.Restricted)
        {
            this.Type = type;
            this.Scopes = scopes ?? throw new global::System.ArgumentNullException(nameof(scopes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictedPermissionsParam" /> class.
        /// </summary>
        public RestrictedPermissionsParam()
        {
        }

    }
}