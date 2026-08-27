
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of hosted tool the model should to use. Learn more about<br/>
    /// [built-in tools](/docs/guides/tools).<br/>
    /// Allowed values are:<br/>
    /// - `file_search`<br/>
    /// - `web_search_preview`<br/>
    /// - `computer`<br/>
    /// - `computer_use_preview`<br/>
    /// - `computer_use`<br/>
    /// - `code_interpreter`<br/>
    /// - `image_generation`
    /// </summary>
    public enum BetaToolChoiceTypesType
    {
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
        ComputerUse,
        /// <summary>
        ///
        /// </summary>
        ComputerUsePreview,
        /// <summary>
        ///
        /// </summary>
        FileSearch,
        /// <summary>
        ///
        /// </summary>
        ImageGeneration,
        /// <summary>
        ///
        /// </summary>
        WebSearchPreview,
        /// <summary>
        ///
        /// </summary>
        WebSearchPreview20250311,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaToolChoiceTypesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaToolChoiceTypesType value)
        {
            return value switch
            {
                BetaToolChoiceTypesType.CodeInterpreter => "code_interpreter",
                BetaToolChoiceTypesType.Computer => "computer",
                BetaToolChoiceTypesType.ComputerUse => "computer_use",
                BetaToolChoiceTypesType.ComputerUsePreview => "computer_use_preview",
                BetaToolChoiceTypesType.FileSearch => "file_search",
                BetaToolChoiceTypesType.ImageGeneration => "image_generation",
                BetaToolChoiceTypesType.WebSearchPreview => "web_search_preview",
                BetaToolChoiceTypesType.WebSearchPreview20250311 => "web_search_preview_2025_03_11",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaToolChoiceTypesType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => BetaToolChoiceTypesType.CodeInterpreter,
                "computer" => BetaToolChoiceTypesType.Computer,
                "computer_use" => BetaToolChoiceTypesType.ComputerUse,
                "computer_use_preview" => BetaToolChoiceTypesType.ComputerUsePreview,
                "file_search" => BetaToolChoiceTypesType.FileSearch,
                "image_generation" => BetaToolChoiceTypesType.ImageGeneration,
                "web_search_preview" => BetaToolChoiceTypesType.WebSearchPreview,
                "web_search_preview_2025_03_11" => BetaToolChoiceTypesType.WebSearchPreview20250311,
                _ => null,
            };
        }
    }
}