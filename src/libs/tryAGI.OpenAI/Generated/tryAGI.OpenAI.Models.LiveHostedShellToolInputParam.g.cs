
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A Responses shell tool with a container_auto or container_reference environment. Local execution and domain secrets are not supported.
    /// </summary>
    public sealed partial class LiveHostedShellToolInputParam
    {
        /// <summary>
        /// Default Value: shell
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveHostedShellToolInputParamType.Shell</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveHostedShellToolInputParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveHostedShellToolInputParamType Type { get; set; } = global::tryAGI.OpenAI.LiveHostedShellToolInputParamType.Shell;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Environment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveHostedShellToolInputParam" /> class.
        /// </summary>
        /// <param name="environment"></param>
        /// <param name="type">
        /// Default Value: shell
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveHostedShellToolInputParam(
            object environment,
            global::tryAGI.OpenAI.LiveHostedShellToolInputParamType type = global::tryAGI.OpenAI.LiveHostedShellToolInputParamType.Shell)
        {
            this.Type = type;
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveHostedShellToolInputParam" /> class.
        /// </summary>
        public LiveHostedShellToolInputParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveHostedShellToolInputParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveHostedShellToolInputParam FromEnvironment(object environment)
        {
            return new LiveHostedShellToolInputParam
            {
                Environment = environment,
            };
        }

    }
}