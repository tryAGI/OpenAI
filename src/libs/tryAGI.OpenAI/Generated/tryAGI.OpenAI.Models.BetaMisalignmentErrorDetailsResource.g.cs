
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaMisalignmentErrorDetailsResource
    {
        /// <summary>
        /// An optional classification; clients must accept additional values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaMisalignmentErrorTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaMisalignmentErrorType? ErrorType { get; set; }

        /// <summary>
        /// The public explanation for this block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detailed_explanation")]
        public string? DetailedExplanation { get; set; }

        /// <summary>
        /// An optional public continuation instruction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steer")]
        public global::tryAGI.OpenAI.BetaMisalignmentSteer? Steer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMisalignmentErrorDetailsResource" /> class.
        /// </summary>
        /// <param name="errorType">
        /// An optional classification; clients must accept additional values.
        /// </param>
        /// <param name="detailedExplanation">
        /// The public explanation for this block.
        /// </param>
        /// <param name="steer">
        /// An optional public continuation instruction.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMisalignmentErrorDetailsResource(
            global::tryAGI.OpenAI.BetaMisalignmentErrorType? errorType,
            string? detailedExplanation,
            global::tryAGI.OpenAI.BetaMisalignmentSteer? steer)
        {
            this.ErrorType = errorType;
            this.DetailedExplanation = detailedExplanation;
            this.Steer = steer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMisalignmentErrorDetailsResource" /> class.
        /// </summary>
        public BetaMisalignmentErrorDetailsResource()
        {
        }

    }
}