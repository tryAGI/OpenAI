
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Describes an OpenAI model offering that can be used with the API.
    /// </summary>
    public sealed partial class Model15
    {
        /// <summary>
        /// The model identifier, which can be referenced in the API endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) when the model was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset Created { get; set; }

        /// <summary>
        /// The object type, which is always "model".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ModelObjectJsonConverter))]
        public global::tryAGI.OpenAI.ModelObject Object { get; set; }

        /// <summary>
        /// The organization that owns the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owned_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Model15" /> class.
        /// </summary>
        /// <param name="id">
        /// The model identifier, which can be referenced in the API endpoints.
        /// </param>
        /// <param name="created">
        /// The Unix timestamp (in seconds) when the model was created.
        /// </param>
        /// <param name="object">
        /// The object type, which is always "model".
        /// </param>
        /// <param name="ownedBy">
        /// The organization that owns the model.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Model15(
            string id,
            global::System.DateTimeOffset created,
            string ownedBy,
            global::tryAGI.OpenAI.ModelObject @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Created = created;
            this.OwnedBy = ownedBy ?? throw new global::System.ArgumentNullException(nameof(ownedBy));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Model15" /> class.
        /// </summary>
        public Model15()
        {
        }
    }
}