
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssignedRoleDetailsAssignmentSourcesVariant1Item
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("principal_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PrincipalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("principal_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PrincipalType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignedRoleDetailsAssignmentSourcesVariant1Item" /> class.
        /// </summary>
        /// <param name="principalId"></param>
        /// <param name="principalType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssignedRoleDetailsAssignmentSourcesVariant1Item(
            string principalId,
            string principalType)
        {
            this.PrincipalId = principalId ?? throw new global::System.ArgumentNullException(nameof(principalId));
            this.PrincipalType = principalType ?? throw new global::System.ArgumentNullException(nameof(principalType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignedRoleDetailsAssignmentSourcesVariant1Item" /> class.
        /// </summary>
        public AssignedRoleDetailsAssignmentSourcesVariant1Item()
        {
        }

    }
}