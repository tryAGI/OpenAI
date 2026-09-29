
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeleteResponseResponse
    {
        /// <summary>
        /// Default Value: response.deleted
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DeleteResponseResponseObject.ResponseDeleted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DeleteResponseResponseObjectJsonConverter))]
        public global::tryAGI.OpenAI.DeleteResponseResponseObject Object { get; set; } = global::tryAGI.OpenAI.DeleteResponseResponseObject.ResponseDeleted;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteResponseResponse" /> class.
        /// </summary>
        /// <param name="deleted"></param>
        /// <param name="id"></param>
        /// <param name="object">
        /// Default Value: response.deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteResponseResponse(
            bool deleted,
            string id,
            global::tryAGI.OpenAI.DeleteResponseResponseObject @object = global::tryAGI.OpenAI.DeleteResponseResponseObject.ResponseDeleted)
        {
            this.Object = @object;
            this.Deleted = deleted;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteResponseResponse" /> class.
        /// </summary>
        public DeleteResponseResponse()
        {
        }

    }
}