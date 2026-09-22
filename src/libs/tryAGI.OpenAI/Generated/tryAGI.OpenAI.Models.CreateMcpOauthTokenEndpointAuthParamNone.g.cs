
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Sends the client ID without a client secret.
    /// </summary>
    public sealed partial class CreateMcpOauthTokenEndpointAuthParamNone
    {
        /// <summary>
        /// The type of the object. Always `none`.<br/>
        /// Default Value: none
        /// </summary>
        /// <default>global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNoneType.None</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateMcpOauthTokenEndpointAuthParamNoneTypeJsonConverter))]
        public global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNoneType Type { get; set; } = global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNoneType.None;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMcpOauthTokenEndpointAuthParamNone" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the object. Always `none`.<br/>
        /// Default Value: none
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateMcpOauthTokenEndpointAuthParamNone(
            global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNoneType type = global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNoneType.None)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMcpOauthTokenEndpointAuthParamNone" /> class.
        /// </summary>
        public CreateMcpOauthTokenEndpointAuthParamNone()
        {
        }

    }
}