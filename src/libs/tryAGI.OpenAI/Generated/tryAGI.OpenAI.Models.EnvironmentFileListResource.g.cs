
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A paginated list of live execution environment files.
    /// </summary>
    public sealed partial class EnvironmentFileListResource
    {
        /// <summary>
        /// The object type. Always `page`.<br/>
        /// Default Value: page
        /// </summary>
        /// <default>global::tryAGI.OpenAI.EnvironmentFilePageObjectResource.Page</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EnvironmentFilePageObjectResourceJsonConverter))]
        public global::tryAGI.OpenAI.EnvironmentFilePageObjectResource Object { get; set; } = global::tryAGI.OpenAI.EnvironmentFilePageObjectResource.Page;

        /// <summary>
        /// Files available on the current page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EnvironmentFileResource> Data { get; set; }

        /// <summary>
        /// The opaque cursor to use when requesting the next page, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// Whether more files follow this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentFileListResource" /> class.
        /// </summary>
        /// <param name="data">
        /// Files available on the current page.
        /// </param>
        /// <param name="hasMore">
        /// Whether more files follow this page.
        /// </param>
        /// <param name="next">
        /// The opaque cursor to use when requesting the next page, if any.
        /// </param>
        /// <param name="object">
        /// The object type. Always `page`.<br/>
        /// Default Value: page
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentFileListResource(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EnvironmentFileResource> data,
            bool hasMore,
            string? next,
            global::tryAGI.OpenAI.EnvironmentFilePageObjectResource @object = global::tryAGI.OpenAI.EnvironmentFilePageObjectResource.Page)
        {
            this.Object = @object;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Next = next;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentFileListResource" /> class.
        /// </summary>
        public EnvironmentFileListResource()
        {
        }

    }
}