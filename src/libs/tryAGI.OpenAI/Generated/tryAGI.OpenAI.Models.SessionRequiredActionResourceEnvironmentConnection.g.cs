
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Reconnect a session environment.
    /// </summary>
    public sealed partial class SessionRequiredActionResourceEnvironmentConnection
    {
        /// <summary>
        /// The type of the object. Always `environment_connection`.<br/>
        /// Default Value: environment_connection
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnectionType.EnvironmentConnection</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionRequiredActionResourceEnvironmentConnectionTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnectionType Type { get; set; } = global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnectionType.EnvironmentConnection;

        /// <summary>
        /// The ID of the environment to reconnect.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvironmentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionRequiredActionResourceEnvironmentConnection" /> class.
        /// </summary>
        /// <param name="environmentId">
        /// The ID of the environment to reconnect.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `environment_connection`.<br/>
        /// Default Value: environment_connection
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionRequiredActionResourceEnvironmentConnection(
            string environmentId,
            global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnectionType type = global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnectionType.EnvironmentConnection)
        {
            this.Type = type;
            this.EnvironmentId = environmentId ?? throw new global::System.ArgumentNullException(nameof(environmentId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionRequiredActionResourceEnvironmentConnection" /> class.
        /// </summary>
        public SessionRequiredActionResourceEnvironmentConnection()
        {
        }

        /// <summary>
        /// Creates a new <see cref="SessionRequiredActionResourceEnvironmentConnection"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static SessionRequiredActionResourceEnvironmentConnection FromEnvironmentId(string environmentId)
        {
            return new SessionRequiredActionResourceEnvironmentConnection
            {
                EnvironmentId = environmentId,
            };
        }

    }
}