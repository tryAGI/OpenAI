
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The current state of a session environment.
    /// </summary>
    public sealed partial class SessionEnvironmentStateResource
    {
        /// <summary>
        /// The public ID of the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The environment type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// The environment's connection status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionEnvironmentStatusResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.SessionEnvironmentStatusResource Status { get; set; }

        /// <summary>
        /// The error reported while preparing the environment, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::tryAGI.OpenAI.SessionEnvironmentErrorResource? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEnvironmentStateResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The public ID of the environment.
        /// </param>
        /// <param name="type">
        /// The environment type.
        /// </param>
        /// <param name="status">
        /// The environment's connection status.
        /// </param>
        /// <param name="error">
        /// The error reported while preparing the environment, if any.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionEnvironmentStateResource(
            string id,
            string type,
            global::tryAGI.OpenAI.SessionEnvironmentStatusResource status,
            global::tryAGI.OpenAI.SessionEnvironmentErrorResource? error)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Status = status;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEnvironmentStateResource" /> class.
        /// </summary>
        public SessionEnvironmentStateResource()
        {
        }

    }
}