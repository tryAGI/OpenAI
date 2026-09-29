
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaDeleteResponseResponse
    {
        /// <summary>
        /// Default Value: response.deleted
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaDeleteResponseResponseObject.ResponseDeleted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaDeleteResponseResponseObjectJsonConverter))]
        public global::tryAGI.OpenAI.BetaDeleteResponseResponseObject Object { get; set; } = global::tryAGI.OpenAI.BetaDeleteResponseResponseObject.ResponseDeleted;

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
        /// Initializes a new instance of the <see cref="BetaDeleteResponseResponse" /> class.
        /// </summary>
        /// <param name="deleted"></param>
        /// <param name="id"></param>
        /// <param name="object">
        /// Default Value: response.deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDeleteResponseResponse(
            bool deleted,
            string id,
            global::tryAGI.OpenAI.BetaDeleteResponseResponseObject @object = global::tryAGI.OpenAI.BetaDeleteResponseResponseObject.ResponseDeleted)
        {
            this.Object = @object;
            this.Deleted = deleted;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDeleteResponseResponse" /> class.
        /// </summary>
        public BetaDeleteResponseResponse()
        {
        }

    }
}