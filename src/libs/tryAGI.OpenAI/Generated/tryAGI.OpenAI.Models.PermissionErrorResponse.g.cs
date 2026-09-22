
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PermissionErrorResponse
    {
        /// <summary>
        /// Details about the permission error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.Error, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.Error, string> Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionErrorResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Details about the permission error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PermissionErrorResponse(
            global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.Error, string> error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionErrorResponse" /> class.
        /// </summary>
        public PermissionErrorResponse()
        {
        }

    }
}