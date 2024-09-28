
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem value)
        {
            return value switch
            {
                CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem.Text => "text",
                CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem? ToEnum(string value)
        {
            return value switch
            {
                "text" => CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem.Text,
                "image" => CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem.Image,
                _ => null,
            };
        }
    }
}