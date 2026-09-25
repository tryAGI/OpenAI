
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Domain-specific access programs to use for this request.
    /// </summary>
    public sealed partial class AccessProgramsParam
    {
        /// <summary>
        /// The Cyber access program to use for this request. Supported values are `standard`, `daybreak_blue`, and `daybreak_red`. If omitted, the API resolves the program from the model's Cyber tier and your organization and project access, subject to model-specific eligibility restrictions. By default, models without a Cyber tier use Standard. Blue-tier models use Daybreak Blue when authorized; otherwise they fall back to Standard unless the model requires Daybreak access. Red-tier models use Daybreak Red and require authorization. Requests that require unavailable Daybreak access return 403. An implicit Standard fallback is represented by null in the response's access_programs field, rather than an explicit Standard selection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cyber")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CyberAccessProgramEnumJsonConverter))]
        public global::tryAGI.OpenAI.CyberAccessProgramEnum? Cyber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessProgramsParam" /> class.
        /// </summary>
        /// <param name="cyber">
        /// The Cyber access program to use for this request. Supported values are `standard`, `daybreak_blue`, and `daybreak_red`. If omitted, the API resolves the program from the model's Cyber tier and your organization and project access, subject to model-specific eligibility restrictions. By default, models without a Cyber tier use Standard. Blue-tier models use Daybreak Blue when authorized; otherwise they fall back to Standard unless the model requires Daybreak access. Red-tier models use Daybreak Red and require authorization. Requests that require unavailable Daybreak access return 403. An implicit Standard fallback is represented by null in the response's access_programs field, rather than an explicit Standard selection.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessProgramsParam(
            global::tryAGI.OpenAI.CyberAccessProgramEnum? cyber)
        {
            this.Cyber = cyber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessProgramsParam" /> class.
        /// </summary>
        public AccessProgramsParam()
        {
        }

    }
}