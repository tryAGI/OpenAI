
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Confirmation payload returned after deleting a project hard spend limit.
    /// </summary>
    public sealed partial class ProjectSpendLimitDeletedResource
    {
        /// <summary>
        /// The object type, which is always `project.spend_limit.deleted`.<br/>
        /// Default Value: project.spend_limit.deleted
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ProjectSpendLimitDeletedResourceObject.ProjectSpendLimitDeleted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ProjectSpendLimitDeletedResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.ProjectSpendLimitDeletedResourceObject Object { get; set; } = global::tryAGI.OpenAI.ProjectSpendLimitDeletedResourceObject.ProjectSpendLimitDeleted;

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
        /// Initializes a new instance of the <see cref="ProjectSpendLimitDeletedResource" /> class.
        /// </summary>
        /// <param name="deleted">
        /// Whether the hard spend limit was deleted.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `project.spend_limit.deleted`.<br/>
        /// Default Value: project.spend_limit.deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectSpendLimitDeletedResource(
            bool deleted,
            global::tryAGI.OpenAI.ProjectSpendLimitDeletedResourceObject @object = global::tryAGI.OpenAI.ProjectSpendLimitDeletedResourceObject.ProjectSpendLimitDeleted)
        {
            this.Object = @object;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSpendLimitDeletedResource" /> class.
        /// </summary>
        public ProjectSpendLimitDeletedResource()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ProjectSpendLimitDeletedResource"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ProjectSpendLimitDeletedResource FromDeleted(bool deleted)
        {
            return new ProjectSpendLimitDeletedResource
            {
                Deleted = deleted,
            };
        }

    }
}