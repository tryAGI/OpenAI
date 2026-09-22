
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Delegate tasks to your application. The Live session emits delegation events that your backend handles.
    /// </summary>
    public sealed partial class LiveClientDelegationParam
    {
        /// <summary>
        /// The delegation owner. Always `client` for tasks handled by your application.<br/>
        /// Default Value: client
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveClientDelegationParamType.Client</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveClientDelegationParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveClientDelegationParamType Type { get; set; } = global::tryAGI.OpenAI.LiveClientDelegationParamType.Client;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveClientDelegationParam" /> class.
        /// </summary>
        /// <param name="type">
        /// The delegation owner. Always `client` for tasks handled by your application.<br/>
        /// Default Value: client
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveClientDelegationParam(
            global::tryAGI.OpenAI.LiveClientDelegationParamType type = global::tryAGI.OpenAI.LiveClientDelegationParamType.Client)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveClientDelegationParam" /> class.
        /// </summary>
        public LiveClientDelegationParam()
        {
        }

    }
}