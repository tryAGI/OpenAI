
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DecisionRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Shared evidence, as a string or an array of user messages containing text and inline images. Non-user roles, function calls, function-call outputs, files, audio, and item references are not supported. At most 128 image parts are allowed across all messages in one request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionInputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.DecisionInput Input { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("questions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.QuestionParam> Questions { get; set; }

        /// <summary>
        /// Opaque caller-provided end-user identifier, scoped by the verified org. Match Responses' limit; this is never the authenticated user identity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_identifier")]
        public string? SafetyIdentifier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionRequest" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="input">
        /// Shared evidence, as a string or an array of user messages containing text and inline images. Non-user roles, function calls, function-call outputs, files, audio, and item references are not supported. At most 128 image parts are allowed across all messages in one request.
        /// </param>
        /// <param name="questions"></param>
        /// <param name="safetyIdentifier">
        /// Opaque caller-provided end-user identifier, scoped by the verified org. Match Responses' limit; this is never the authenticated user identity.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionRequest(
            string model,
            global::tryAGI.OpenAI.DecisionInput input,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.QuestionParam> questions,
            string? safetyIdentifier)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input;
            this.Questions = questions ?? throw new global::System.ArgumentNullException(nameof(questions));
            this.SafetyIdentifier = safetyIdentifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionRequest" /> class.
        /// </summary>
        public DecisionRequest()
        {
        }

    }
}