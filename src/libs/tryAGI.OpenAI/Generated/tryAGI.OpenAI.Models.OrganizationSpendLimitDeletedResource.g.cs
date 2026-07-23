
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Confirmation payload returned after deleting an organization hard spend limit.
    /// </summary>
    public sealed partial class OrganizationSpendLimitDeletedResource
    {
        /// <summary>
        /// The object type, which is always `organization.spend_limit.deleted`.<br/>
        /// Default Value: organization.spend_limit.deleted
        /// </summary>
        /// <default>global::tryAGI.OpenAI.OrganizationSpendLimitDeletedResourceObject.OrganizationSpendLimitDeleted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OrganizationSpendLimitDeletedResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.OrganizationSpendLimitDeletedResourceObject Object { get; set; } = global::tryAGI.OpenAI.OrganizationSpendLimitDeletedResourceObject.OrganizationSpendLimitDeleted;

        /// <summary>
        /// Whether the hard spend limit was deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationSpendLimitDeletedResource" /> class.
        /// </summary>
        /// <param name="deleted">
        /// Whether the hard spend limit was deleted.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `organization.spend_limit.deleted`.<br/>
        /// Default Value: organization.spend_limit.deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationSpendLimitDeletedResource(
            bool deleted,
            global::tryAGI.OpenAI.OrganizationSpendLimitDeletedResourceObject @object = global::tryAGI.OpenAI.OrganizationSpendLimitDeletedResourceObject.OrganizationSpendLimitDeleted)
        {
            this.Object = @object;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationSpendLimitDeletedResource" /> class.
        /// </summary>
        public OrganizationSpendLimitDeletedResource()
        {
        }

        /// <summary>
        /// Creates a new <see cref="OrganizationSpendLimitDeletedResource"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static OrganizationSpendLimitDeletedResource FromDeleted(bool deleted)
        {
            return new OrganizationSpendLimitDeletedResource
            {
                Deleted = deleted,
            };
        }

    }
}