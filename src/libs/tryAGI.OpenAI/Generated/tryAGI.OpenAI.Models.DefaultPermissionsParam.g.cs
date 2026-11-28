
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DefaultPermissionsParam
    {
        /// <summary>
        /// Default Value: service_account_default
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DefaultPermissionsParamType.ServiceAccountDefault</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DefaultPermissionsParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.DefaultPermissionsParamType Type { get; set; } = global::tryAGI.OpenAI.DefaultPermissionsParamType.ServiceAccountDefault;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultPermissionsParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: service_account_default
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DefaultPermissionsParam(
            global::tryAGI.OpenAI.DefaultPermissionsParamType type = global::tryAGI.OpenAI.DefaultPermissionsParamType.ServiceAccountDefault)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultPermissionsParam" /> class.
        /// </summary>
        public DefaultPermissionsParam()
        {
        }

    }
}