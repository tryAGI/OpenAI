
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveAllowedToolsChoiceParamToolDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        ApplyPatch,
        /// <summary>
        ///
        /// </summary>
        CodeInterpreter,
        /// <summary>
        ///
        /// </summary>
        Computer,
        /// <summary>
        ///
        /// </summary>
        Custom,
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
        Mcp,
        /// <summary>
        ///
        /// </summary>
        ProgrammaticToolCalling,
        /// <summary>
        ///
        /// </summary>
        Shell,
        /// <summary>
        ///
        /// </summary>
        WebSearch,
        /// <summary>
        ///
        /// </summary>
        WebSearchPreview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveAllowedToolsChoiceParamToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveAllowedToolsChoiceParamToolDiscriminatorType value)
        {
            return value switch
            {
                LiveAllowedToolsChoiceParamToolDiscriminatorType.ApplyPatch => "apply_patch",
                LiveAllowedToolsChoiceParamToolDiscriminatorType.CodeInterpreter => "code_interpreter",
                LiveAllowedToolsChoiceParamToolDiscriminatorType.Computer => "computer",
                LiveAllowedToolsChoiceParamToolDiscriminatorType.Custom => "custom",
                LiveAllowedToolsChoiceParamToolDiscriminatorType.FileSearch => "file_search",
                LiveAllowedToolsChoiceParamToolDiscriminatorType.Function => "function",
                LiveAllowedToolsChoiceParamToolDiscriminatorType.ImageGeneration => "image_generation",
                LiveAllowedToolsChoiceParamToolDiscriminatorType.Mcp => "mcp",
                LiveAllowedToolsChoiceParamToolDiscriminatorType.ProgrammaticToolCalling => "programmatic_tool_calling",
                LiveAllowedToolsChoiceParamToolDiscriminatorType.Shell => "shell",
                LiveAllowedToolsChoiceParamToolDiscriminatorType.WebSearch => "web_search",
                LiveAllowedToolsChoiceParamToolDiscriminatorType.WebSearchPreview => "web_search_preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveAllowedToolsChoiceParamToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch" => LiveAllowedToolsChoiceParamToolDiscriminatorType.ApplyPatch,
                "code_interpreter" => LiveAllowedToolsChoiceParamToolDiscriminatorType.CodeInterpreter,
                "computer" => LiveAllowedToolsChoiceParamToolDiscriminatorType.Computer,
                "custom" => LiveAllowedToolsChoiceParamToolDiscriminatorType.Custom,
                "file_search" => LiveAllowedToolsChoiceParamToolDiscriminatorType.FileSearch,
                "function" => LiveAllowedToolsChoiceParamToolDiscriminatorType.Function,
                "image_generation" => LiveAllowedToolsChoiceParamToolDiscriminatorType.ImageGeneration,
                "mcp" => LiveAllowedToolsChoiceParamToolDiscriminatorType.Mcp,
                "programmatic_tool_calling" => LiveAllowedToolsChoiceParamToolDiscriminatorType.ProgrammaticToolCalling,
                "shell" => LiveAllowedToolsChoiceParamToolDiscriminatorType.Shell,
                "web_search" => LiveAllowedToolsChoiceParamToolDiscriminatorType.WebSearch,
                "web_search_preview" => LiveAllowedToolsChoiceParamToolDiscriminatorType.WebSearchPreview,
                _ => null,
            };
        }
    }
}