
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateContainerBody
    {
        /// <summary>
        /// Container expiration time in seconds relative to the 'anchor' time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_after")]
        public global::tryAGI.OpenAI.CreateContainerBodyExpiresAfter? ExpiresAfter { get; set; }

        /// <summary>
        /// IDs of files to copy to the container.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_ids")]
        public global::System.Collections.Generic.IList<string>? FileIds { get; set; }

        /// <summary>
        /// Name of the container to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContainerBody" /> class.
        /// </summary>
        /// <param name="expiresAfter">
        /// Container expiration time in seconds relative to the 'anchor' time.
        /// </param>
        /// <param name="fileIds">
        /// IDs of files to copy to the container.
        /// </param>
        /// <param name="name">
        /// Name of the container to create.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateContainerBody(
            string name,
            global::tryAGI.OpenAI.CreateContainerBodyExpiresAfter? expiresAfter,
            global::System.Collections.Generic.IList<string>? fileIds)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ExpiresAfter = expiresAfter;
            this.FileIds = fileIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContainerBody" /> class.
        /// </summary>
        public CreateContainerBody()
        {
        }
    }
}