
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// A list of the categories along with the input type(s) that the score applies to.
    /// </summary>
    public sealed partial class CreateModerationResponseResultCategoryAppliedInputTypes
    {
        /// <summary>
        /// The applied input type(s) for the category 'hate'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateItem> Hate { get; set; }

        /// <summary>
        /// The applied input type(s) for the category 'hate/threatening'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hate/threatening")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem> HateThreatening { get; set; }

        /// <summary>
        /// The applied input type(s) for the category 'harassment'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("harassment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItem> Harassment { get; set; }

        /// <summary>
        /// The applied input type(s) for the category 'harassment/threatening'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("harassment/threatening")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem> HarassmentThreatening { get; set; }

        /// <summary>
        /// The applied input type(s) for the category 'illicit'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("illicit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitItem> Illicit { get; set; }

        /// <summary>
        /// The applied input type(s) for the category 'illicit/violent'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("illicit/violent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem> IllicitViolent { get; set; }

        /// <summary>
        /// The applied input type(s) for the category 'self-harm'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self-harm")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem> SelfHarm { get; set; }

        /// <summary>
        /// The applied input type(s) for the category 'self-harm/intent'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self-harm/intent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem> SelfHarmIntent { get; set; }

        /// <summary>
        /// The applied input type(s) for the category 'self-harm/instructions'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self-harm/instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction> SelfHarmInstructions { get; set; }

        /// <summary>
        /// The applied input type(s) for the category 'sexual'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sexual")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem> Sexual { get; set; }

        /// <summary>
        /// The applied input type(s) for the category 'sexual/minors'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sexual/minors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor> SexualMinors { get; set; }

        /// <summary>
        /// The applied input type(s) for the category 'violence'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem> Violence { get; set; }

        /// <summary>
        /// The applied input type(s) for the category 'violence/graphic'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violence/graphic")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem> ViolenceGraphic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypes? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypes),
                jsonSerializerContext) as global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypes;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypes? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypes>(
                json,
                jsonSerializerOptions);
        }

    }
}