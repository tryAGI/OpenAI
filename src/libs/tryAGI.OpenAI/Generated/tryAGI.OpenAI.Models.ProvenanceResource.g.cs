
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProvenanceResource
    {
        /// <summary>
        /// The object type. Always `content_provenance_check` for this endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ProvenanceCheckObjectJsonConverter))]
        public global::tryAGI.OpenAI.ProvenanceCheckObject Object { get; set; }

        /// <summary>
        /// The Unix timestamp, in seconds, when the provenance check was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// The provenance results that apply to the uploaded file. Image results include C2PA and SynthID; audio results include SynthID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResultsItem2> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvenanceResource" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The Unix timestamp, in seconds, when the provenance check was created.
        /// </param>
        /// <param name="results">
        /// The provenance results that apply to the uploaded file. Image results include C2PA and SynthID; audio results include SynthID.
        /// </param>
        /// <param name="object">
        /// The object type. Always `content_provenance_check` for this endpoint.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProvenanceResource(
            int createdAt,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResultsItem2> results,
            global::tryAGI.OpenAI.ProvenanceCheckObject @object)
        {
            this.Object = @object;
            this.CreatedAt = createdAt;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvenanceResource" /> class.
        /// </summary>
        public ProvenanceResource()
        {
        }

    }
}