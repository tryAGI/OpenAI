
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveResponsesDelegationSettingsInputParamToolDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        CodeInterpreter,
        /// <summary>
        ///
        /// </summary>
        FileSearch,
        /// <summary>
        ///
        /// </summary>
        Function,
        /// <summary>
        ///
        /// </summary>
        ImageGeneration,
        /// <summary>
        ///
        /// </summary>
        Shell,
        /// <summary>
        ///
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveResponsesDelegationSettingsInputParamToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveResponsesDelegationSettingsInputParamToolDiscriminatorType value)
        {
            return value switch
            {
                LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.CodeInterpreter => "code_interpreter",
                LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.FileSearch => "file_search",
                LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.Function => "function",
                LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.ImageGeneration => "image_generation",
                LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.Shell => "shell",
                LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveResponsesDelegationSettingsInputParamToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.CodeInterpreter,
                "file_search" => LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.FileSearch,
                "function" => LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.Function,
                "image_generation" => LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.ImageGeneration,
                "shell" => LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.Shell,
                "web_search" => LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.WebSearch,
                _ => null,
            };
        }
    }
}