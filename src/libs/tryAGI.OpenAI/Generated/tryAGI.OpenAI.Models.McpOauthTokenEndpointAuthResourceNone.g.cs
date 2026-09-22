
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Sends the client ID without a client secret.
    /// </summary>
    public sealed partial class McpOauthTokenEndpointAuthResourceNone
    {
        /// <summary>
        /// The type of the object. Always `none`.<br/>
        /// Default Value: none
        /// </summary>
        /// <default>global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNoneType.None</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.McpOauthTokenEndpointAuthResourceNoneTypeJsonConverter))]
        public global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNoneType Type { get; set; } = global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNoneType.None;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpOauthTokenEndpointAuthResourceNone" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the object. Always `none`.<br/>
        /// Default Value: none
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpOauthTokenEndpointAuthResourceNone(
            global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNoneType type = global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNoneType.None)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpOauthTokenEndpointAuthResourceNone" /> class.
        /// </summary>
        public McpOauthTokenEndpointAuthResourceNone()
        {
        }

    }
}