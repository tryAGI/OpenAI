
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A function tool available to the Responses backend when the Live model delegates a task.
    /// </summary>
    public sealed partial class LiveFunctionToolInputParam
    {
        /// <summary>
        /// The tool type. Always `function`.<br/>
        /// Default Value: function
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveFunctionToolInputParamType.Function</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveFunctionToolInputParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveFunctionToolInputParamType Type { get; set; } = global::tryAGI.OpenAI.LiveFunctionToolInputParamType.Function;

        /// <summary>
        /// The name the delegated Responses model uses when calling this function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveFunctionToolInputParam" /> class.
        /// </summary>
        /// <param name="name">
        /// The name the delegated Responses model uses when calling this function.
        /// </param>
        /// <param name="description"></param>
        /// <param name="parameters"></param>
        /// <param name="strict"></param>
        /// <param name="type">
        /// The tool type. Always `function`.<br/>
        /// Default Value: function
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveFunctionToolInputParam(
            string name,
            string? description,
            object? parameters,
            bool? strict,
            global::tryAGI.OpenAI.LiveFunctionToolInputParamType type = global::tryAGI.OpenAI.LiveFunctionToolInputParamType.Function)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Parameters = parameters;
            this.Strict = strict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveFunctionToolInputParam" /> class.
        /// </summary>
        public LiveFunctionToolInputParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveFunctionToolInputParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveFunctionToolInputParam FromName(string name)
        {
            return new LiveFunctionToolInputParam
            {
                Name = name,
            };
        }

    }
}