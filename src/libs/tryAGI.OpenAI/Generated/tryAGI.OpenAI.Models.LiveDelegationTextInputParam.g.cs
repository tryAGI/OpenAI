
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Text generation options for the Live session’s Responses backend.
    /// </summary>
    public sealed partial class LiveDelegationTextInputParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verbosity")]
        public global::tryAGI.OpenAI.LiveTextVerbosity? Verbosity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDelegationTextInputParam" /> class.
        /// </summary>
        /// <param name="verbosity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDelegationTextInputParam(
            global::tryAGI.OpenAI.LiveTextVerbosity? verbosity)
        {
            this.Verbosity = verbosity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDelegationTextInputParam" /> class.
        /// </summary>
        public LiveDelegationTextInputParam()
        {
        }

    }
}