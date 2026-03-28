
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents an `assistant` that can call the model and use tools.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class AssistantObject
    {
        /// <summary>
        /// The identifier, which can be referenced in API endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, which is always `assistant`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AssistantObjectObjectJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::tryAGI.OpenAI.AssistantObjectObject Object { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the assistant was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Description { get; set; }

        /// <summary>
        /// ID of the model to use. You can use the [List models](/docs/api-reference/models/list) API to see all of your available models, or see our [Model overview](/docs/models) for descriptions of them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Instructions { get; set; }

        /// <summary>
        /// A list of tool enabled on the assistant. There can be a maximum of 128 tools per assistant. Tools can be of types `code_interpreter`, `file_search`, or `function`.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>> Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_resources")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::tryAGI.OpenAI.AssistantObjectToolResources2? ToolResources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? TopP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::tryAGI.OpenAI.AssistantsApiResponseFormatOption? ResponseFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantObject" /> class.
        /// </summary>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `assistant`.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the assistant was created.
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="model">
        /// ID of the model to use. You can use the [List models](/docs/api-reference/models/list) API to see all of your available models, or see our [Model overview](/docs/models) for descriptions of them.
        /// </param>
        /// <param name="instructions"></param>
        /// <param name="tools">
        /// A list of tool enabled on the assistant. There can be a maximum of 128 tools per assistant. Tools can be of types `code_interpreter`, `file_search`, or `function`.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="toolResources"></param>
        /// <param name="metadata"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="responseFormat"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantObject(
            string id,
            global::System.DateTimeOffset createdAt,
            string model,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>> tools,
            global::tryAGI.OpenAI.AssistantObjectObject @object,
            string? name,
            string? description,
            string? instructions,
            global::tryAGI.OpenAI.AssistantObjectToolResources2? toolResources,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            double? temperature,
            double? topP,
            global::tryAGI.OpenAI.AssistantsApiResponseFormatOption? responseFormat)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.Object = @object;
            this.Name = name;
            this.Description = description;
            this.Instructions = instructions;
            this.ToolResources = toolResources;
            this.Metadata = metadata;
            this.Temperature = temperature;
            this.TopP = topP;
            this.ResponseFormat = responseFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantObject" /> class.
        /// </summary>
        public AssistantObject()
        {
        }
    }
}