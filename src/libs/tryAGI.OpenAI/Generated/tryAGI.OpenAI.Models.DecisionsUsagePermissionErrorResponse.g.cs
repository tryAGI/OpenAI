
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DecisionsUsagePermissionErrorResponse
    {
        /// <summary>
        /// Details about the permission error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.DecisionsUsageErrorDetails, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.DecisionsUsageErrorDetails, string> Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsUsagePermissionErrorResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Details about the permission error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionsUsagePermissionErrorResponse(
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.DecisionsUsageErrorDetails, string> error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsUsagePermissionErrorResponse" /> class.
        /// </summary>
        public DecisionsUsagePermissionErrorResponse()
        {
        }

    }
}