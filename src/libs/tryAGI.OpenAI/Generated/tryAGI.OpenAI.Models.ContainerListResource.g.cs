
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContainerListResource
    {
        /// <summary>
        /// A list of containers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContainerResource> Data { get; set; }

        /// <summary>
        /// The ID of the first container in the list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FirstId { get; set; }

        /// <summary>
        /// Whether there are more containers available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// The ID of the last container in the list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastId { get; set; }

        /// <summary>
        /// The type of object returned, must be 'list'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ContainerListResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.ContainerListResourceObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerListResource" /> class.
        /// </summary>
        /// <param name="data">
        /// A list of containers.
        /// </param>
        /// <param name="firstId">
        /// The ID of the first container in the list.
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more containers available.
        /// </param>
        /// <param name="lastId">
        /// The ID of the last container in the list.
        /// </param>
        /// <param name="object">
        /// The type of object returned, must be 'list'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContainerListResource(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContainerResource> data,
            string firstId,
            bool hasMore,
            string lastId,
            global::tryAGI.OpenAI.ContainerListResourceObject @object)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FirstId = firstId ?? throw new global::System.ArgumentNullException(nameof(firstId));
            this.HasMore = hasMore;
            this.LastId = lastId ?? throw new global::System.ArgumentNullException(nameof(lastId));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerListResource" /> class.
        /// </summary>
        public ContainerListResource()
        {
        }
    }
}