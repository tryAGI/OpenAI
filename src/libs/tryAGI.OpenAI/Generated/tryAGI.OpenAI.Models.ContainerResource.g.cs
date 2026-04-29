
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContainerResource
    {
        /// <summary>
        /// Unique identifier for the container.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The type of this object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; }

        /// <summary>
        /// Name of the container.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Unix timestamp (in seconds) when the container was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// Status of the container (e.g., active, deleted).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Unix timestamp (in seconds) when the container was last active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_active_at")]
        public int? LastActiveAt { get; set; }

        /// <summary>
        /// The container will expire after this time period.<br/>
        /// The anchor is the reference point for the expiration.<br/>
        /// The minutes is the number of minutes after the anchor before the container expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_after")]
        public global::tryAGI.OpenAI.ContainerResourceExpiresAfter? ExpiresAfter { get; set; }

        /// <summary>
        /// The memory limit configured for the container.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_limit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ContainerResourceMemoryLimitJsonConverter))]
        public global::tryAGI.OpenAI.ContainerResourceMemoryLimit? MemoryLimit { get; set; }

        /// <summary>
        /// Network access policy for the container.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("network_policy")]
        public global::tryAGI.OpenAI.ContainerResourceNetworkPolicy? NetworkPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerResource" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the container.
        /// </param>
        /// <param name="object">
        /// The type of this object.
        /// </param>
        /// <param name="name">
        /// Name of the container.
        /// </param>
        /// <param name="createdAt">
        /// Unix timestamp (in seconds) when the container was created.
        /// </param>
        /// <param name="status">
        /// Status of the container (e.g., active, deleted).
        /// </param>
        /// <param name="lastActiveAt">
        /// Unix timestamp (in seconds) when the container was last active.
        /// </param>
        /// <param name="expiresAfter">
        /// The container will expire after this time period.<br/>
        /// The anchor is the reference point for the expiration.<br/>
        /// The minutes is the number of minutes after the anchor before the container expires.
        /// </param>
        /// <param name="memoryLimit">
        /// The memory limit configured for the container.
        /// </param>
        /// <param name="networkPolicy">
        /// Network access policy for the container.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContainerResource(
            string id,
            string @object,
            string name,
            int createdAt,
            string status,
            int? lastActiveAt,
            global::tryAGI.OpenAI.ContainerResourceExpiresAfter? expiresAfter,
            global::tryAGI.OpenAI.ContainerResourceMemoryLimit? memoryLimit,
            global::tryAGI.OpenAI.ContainerResourceNetworkPolicy? networkPolicy)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.LastActiveAt = lastActiveAt;
            this.ExpiresAfter = expiresAfter;
            this.MemoryLimit = memoryLimit;
            this.NetworkPolicy = networkPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerResource" /> class.
        /// </summary>
        public ContainerResource()
        {
        }
    }
}