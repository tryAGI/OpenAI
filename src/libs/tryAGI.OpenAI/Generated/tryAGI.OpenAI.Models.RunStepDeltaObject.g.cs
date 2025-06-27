
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents a run step delta i.e. any changed fields on a run step during streaming.
    /// </summary>
    public sealed partial class RunStepDeltaObject
    {
        /// <summary>
        /// The delta containing the fields that have changed on the run step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RunStepDeltaObjectDelta Delta { get; set; }

        /// <summary>
        /// The identifier of the run step, which can be referenced in API endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, which is always `thread.run.step.delta`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDeltaObjectObjectJsonConverter))]
        public global::tryAGI.OpenAI.RunStepDeltaObjectObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaObject" /> class.
        /// </summary>
        /// <param name="delta">
        /// The delta containing the fields that have changed on the run step.
        /// </param>
        /// <param name="id">
        /// The identifier of the run step, which can be referenced in API endpoints.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `thread.run.step.delta`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStepDeltaObject(
            global::tryAGI.OpenAI.RunStepDeltaObjectDelta delta,
            string id,
            global::tryAGI.OpenAI.RunStepDeltaObjectObject @object)
        {
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaObject" /> class.
        /// </summary>
        public RunStepDeltaObject()
        {
        }
    }
}