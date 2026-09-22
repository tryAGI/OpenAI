
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An API error response.
    /// </summary>
    public sealed partial class ErrorResponse2
    {
        /// <summary>
        /// The error returned by the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ErrorBodyResource Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse2" /> class.
        /// </summary>
        /// <param name="error">
        /// The error returned by the API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorResponse2(
            global::tryAGI.OpenAI.ErrorBodyResource error)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse2" /> class.
        /// </summary>
        public ErrorResponse2()
        {
        }

    }
}