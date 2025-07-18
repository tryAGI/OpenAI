
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A StringCheckGrader object that performs a string comparison between input and reference using a specified operation.
    /// </summary>
    public sealed partial class GraderStringCheck
    {
        /// <summary>
        /// The input text. This may include template strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// The name of the grader.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The string check operation to perform. One of `eq`, `ne`, `like`, or `ilike`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.GraderStringCheckOperationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.GraderStringCheckOperation Operation { get; set; }

        /// <summary>
        /// The reference text. This may include template strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reference { get; set; }

        /// <summary>
        /// The object type, which is always `string_check`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.GraderStringCheckTypeJsonConverter))]
        public global::tryAGI.OpenAI.GraderStringCheckType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraderStringCheck" /> class.
        /// </summary>
        /// <param name="input">
        /// The input text. This may include template strings.
        /// </param>
        /// <param name="name">
        /// The name of the grader.
        /// </param>
        /// <param name="operation">
        /// The string check operation to perform. One of `eq`, `ne`, `like`, or `ilike`.
        /// </param>
        /// <param name="reference">
        /// The reference text. This may include template strings.
        /// </param>
        /// <param name="type">
        /// The object type, which is always `string_check`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraderStringCheck(
            string input,
            string name,
            global::tryAGI.OpenAI.GraderStringCheckOperation operation,
            string reference,
            global::tryAGI.OpenAI.GraderStringCheckType type)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Operation = operation;
            this.Reference = reference ?? throw new global::System.ArgumentNullException(nameof(reference));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraderStringCheck" /> class.
        /// </summary>
        public GraderStringCheck()
        {
        }
    }
}