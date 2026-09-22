
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A function defined by the application.
    /// </summary>
    public sealed partial class PersistedAgentToolResourceFunction
    {
        /// <summary>
        /// The type of the object. Always `function`.<br/>
        /// Default Value: function
        /// </summary>
        /// <default>global::tryAGI.OpenAI.PersistedAgentToolResourceFunctionType.Function</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceFunctionTypeJsonConverter))]
        public global::tryAGI.OpenAI.PersistedAgentToolResourceFunctionType Type { get; set; } = global::tryAGI.OpenAI.PersistedAgentToolResourceFunctionType.Function;

        /// <summary>
        /// The name of the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of what the function does.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// A JSON Schema object describing the function's arguments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Parameters { get; set; }

        /// <summary>
        /// Whether the function is deferred and discovered through tool search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defer_loading")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DeferLoading { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PersistedAgentToolResourceFunction" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the function.
        /// </param>
        /// <param name="description">
        /// A description of what the function does.
        /// </param>
        /// <param name="parameters">
        /// A JSON Schema object describing the function's arguments.
        /// </param>
        /// <param name="deferLoading">
        /// Whether the function is deferred and discovered through tool search.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `function`.<br/>
        /// Default Value: function
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PersistedAgentToolResourceFunction(
            string name,
            string description,
            object parameters,
            bool deferLoading,
            global::tryAGI.OpenAI.PersistedAgentToolResourceFunctionType type = global::tryAGI.OpenAI.PersistedAgentToolResourceFunctionType.Function)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
            this.DeferLoading = deferLoading;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersistedAgentToolResourceFunction" /> class.
        /// </summary>
        public PersistedAgentToolResourceFunction()
        {
        }

    }
}