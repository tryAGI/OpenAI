
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InviteDeleteResponse
    {
        /// <summary>
        /// The object type, which is always `organization.invite.deleted`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InviteDeleteResponseObjectJsonConverter))]
        public global::tryAGI.OpenAI.InviteDeleteResponseObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="InviteDeleteResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type, which is always `organization.invite.deleted`
        /// </param>
        /// <param name="id"></param>
        /// <param name="deleted"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public InviteDeleteResponse(
            string id,
            bool deleted,
            global::tryAGI.OpenAI.InviteDeleteResponseObject @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Deleted = deleted;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteDeleteResponse" /> class.
        /// </summary>
        public InviteDeleteResponse()
        {
        }
    }
}