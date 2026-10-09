
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicDecisionsUsageResponseResource
    {
        /// <summary>
        /// Default Value: page
        /// </summary>
        /// <default>global::tryAGI.OpenAI.PublicDecisionsUsageResponseResourceObject.Page</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PublicDecisionsUsageResponseResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.PublicDecisionsUsageResponseResourceObject Object { get; set; } = global::tryAGI.OpenAI.PublicDecisionsUsageResponseResourceObject.Page;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionsUsageBucket> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicDecisionsUsageResponseResource" /> class.
        /// </summary>
        /// <param name="hasMore"></param>
        /// <param name="data"></param>
        /// <param name="nextPage"></param>
        /// <param name="object">
        /// Default Value: page
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicDecisionsUsageResponseResource(
            bool hasMore,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionsUsageBucket> data,
            string? nextPage,
            global::tryAGI.OpenAI.PublicDecisionsUsageResponseResourceObject @object = global::tryAGI.OpenAI.PublicDecisionsUsageResponseResourceObject.Page)
        {
            this.Object = @object;
            this.HasMore = hasMore;
            this.NextPage = nextPage;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicDecisionsUsageResponseResource" /> class.
        /// </summary>
        public PublicDecisionsUsageResponseResource()
        {
        }

    }
}