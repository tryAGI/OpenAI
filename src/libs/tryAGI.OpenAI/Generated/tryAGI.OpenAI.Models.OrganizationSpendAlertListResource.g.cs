
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Paginated list of organization spend alerts.
    /// </summary>
    public sealed partial class OrganizationSpendAlertListResource
    {
        /// <summary>
        /// Always `list`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OrganizationSpendAlertListResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.OrganizationSpendAlertListResourceObject Object { get; set; }

        /// <summary>
        /// Spend alerts returned in the current page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OrganizationSpendAlert> Data { get; set; }

        /// <summary>
        /// The ID of the first spend alert in this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        public string? FirstId { get; set; }

        /// <summary>
        /// The ID of the last spend alert in this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        public string? LastId { get; set; }

        /// <summary>
        /// Whether more spend alerts are available when paginating.
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
        /// Initializes a new instance of the <see cref="OrganizationSpendAlertListResource" /> class.
        /// </summary>
        /// <param name="data">
        /// Spend alerts returned in the current page.
        /// </param>
        /// <param name="hasMore">
        /// Whether more spend alerts are available when paginating.
        /// </param>
        /// <param name="object">
        /// Always `list`.
        /// </param>
        /// <param name="firstId">
        /// The ID of the first spend alert in this page.
        /// </param>
        /// <param name="lastId">
        /// The ID of the last spend alert in this page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationSpendAlertListResource(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OrganizationSpendAlert> data,
            bool hasMore,
            global::tryAGI.OpenAI.OrganizationSpendAlertListResourceObject @object,
            string? firstId,
            string? lastId)
        {
            this.Object = @object;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FirstId = firstId;
            this.LastId = lastId;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationSpendAlertListResource" /> class.
        /// </summary>
        public OrganizationSpendAlertListResource()
        {
        }

    }
}