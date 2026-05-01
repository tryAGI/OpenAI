
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminApiKeysDeleteResponse
    {
        /// <summary>
        /// Example: key_abc
        /// </summary>
        /// <example>key_abc</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Example: organization.admin_api_key.deleted
        /// </summary>
        /// <example>organization.admin_api_key.deleted</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AdminApiKeysDeleteResponseObjectJsonConverter))]
        public global::tryAGI.OpenAI.AdminApiKeysDeleteResponseObject Object { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminApiKeysDeleteResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: key_abc
        /// </param>
        /// <param name="deleted">
        /// Example: true
        /// </param>
        /// <param name="object">
        /// Example: organization.admin_api_key.deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminApiKeysDeleteResponse(
            string id,
            bool deleted,
            global::tryAGI.OpenAI.AdminApiKeysDeleteResponseObject @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminApiKeysDeleteResponse" /> class.
        /// </summary>
        public AdminApiKeysDeleteResponse()
        {
        }
    }
}