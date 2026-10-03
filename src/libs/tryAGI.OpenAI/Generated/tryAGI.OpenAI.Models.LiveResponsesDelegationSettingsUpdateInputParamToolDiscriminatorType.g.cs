
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType
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
    public static class LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType value)
        {
            return value switch
            {
                LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.CodeInterpreter => "code_interpreter",
                LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.FileSearch => "file_search",
                LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.Function => "function",
                LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.ImageGeneration => "image_generation",
                LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.Shell => "shell",
                LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.CodeInterpreter,
                "file_search" => LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.FileSearch,
                "function" => LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.Function,
                "image_generation" => LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.ImageGeneration,
                "shell" => LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.Shell,
                "web_search" => LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.WebSearch,
                _ => null,
            };
        }
    }
}