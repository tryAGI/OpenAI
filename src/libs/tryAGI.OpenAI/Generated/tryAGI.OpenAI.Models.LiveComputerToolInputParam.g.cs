
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveComputerToolInputParam
    {
        /// <summary>
        /// Default Value: computer
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveComputerToolInputParamType.Computer</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveComputerToolInputParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveComputerToolInputParamType Type { get; set; } = global::tryAGI.OpenAI.LiveComputerToolInputParamType.Computer;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveComputerToolInputParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: computer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveComputerToolInputParam(
            global::tryAGI.OpenAI.LiveComputerToolInputParamType type = global::tryAGI.OpenAI.LiveComputerToolInputParamType.Computer)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveComputerToolInputParam" /> class.
        /// </summary>
        public LiveComputerToolInputParam()
        {
        }

    }
}