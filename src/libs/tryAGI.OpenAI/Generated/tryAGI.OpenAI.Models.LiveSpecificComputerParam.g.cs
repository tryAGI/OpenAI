
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveSpecificComputerParam
    {
        /// <summary>
        /// The tool to call. Always `computer`.<br/>
        /// Default Value: computer
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveSpecificComputerParamType.Computer</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveSpecificComputerParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveSpecificComputerParamType Type { get; set; } = global::tryAGI.OpenAI.LiveSpecificComputerParamType.Computer;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSpecificComputerParam" /> class.
        /// </summary>
        /// <param name="type">
        /// The tool to call. Always `computer`.<br/>
        /// Default Value: computer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSpecificComputerParam(
            global::tryAGI.OpenAI.LiveSpecificComputerParamType type = global::tryAGI.OpenAI.LiveSpecificComputerParamType.Computer)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSpecificComputerParam" /> class.
        /// </summary>
        public LiveSpecificComputerParam()
        {
        }

    }
}