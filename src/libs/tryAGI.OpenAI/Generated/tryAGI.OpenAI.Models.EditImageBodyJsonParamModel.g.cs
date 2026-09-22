
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum EditImageBodyJsonParamModel
    {
        /// <summary>
        ///
        /// </summary>
        ChatgptImageLatest,
        /// <summary>
        ///
        /// </summary>
        GptImage1,
        /// <summary>
        ///
        /// </summary>
        GptImage1Mini,
        /// <summary>
        ///
        /// </summary>
        GptImage15,
        /// <summary>
        ///
        /// </summary>
        GptImage2,
        /// <summary>
        ///
        /// </summary>
        GptImage220260421,
        /// <summary>
        ///
        /// </summary>
        GptImage25Flare,
        /// <summary>
        ///
        /// </summary>
        GptImage25Flare20260908,
        /// <summary>
        ///
        /// </summary>
        GptImage25Sunburst,
        /// <summary>
        ///
        /// </summary>
        GptImage25Sunburst20260908,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageBodyJsonParamModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageBodyJsonParamModel value)
        {
            return value switch
            {
                EditImageBodyJsonParamModel.ChatgptImageLatest => "chatgpt-image-latest",
                EditImageBodyJsonParamModel.GptImage1 => "gpt-image-1",
                EditImageBodyJsonParamModel.GptImage1Mini => "gpt-image-1-mini",
                EditImageBodyJsonParamModel.GptImage15 => "gpt-image-1.5",
                EditImageBodyJsonParamModel.GptImage2 => "gpt-image-2",
                EditImageBodyJsonParamModel.GptImage220260421 => "gpt-image-2-2026-04-21",
                EditImageBodyJsonParamModel.GptImage25Flare => "gpt-image-2.5-flare",
                EditImageBodyJsonParamModel.GptImage25Flare20260908 => "gpt-image-2.5-flare-2026-09-08",
                EditImageBodyJsonParamModel.GptImage25Sunburst => "gpt-image-2.5-sunburst",
                EditImageBodyJsonParamModel.GptImage25Sunburst20260908 => "gpt-image-2.5-sunburst-2026-09-08",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageBodyJsonParamModel? ToEnum(string value)
        {
            return value switch
            {
                "chatgpt-image-latest" => EditImageBodyJsonParamModel.ChatgptImageLatest,
                "gpt-image-1" => EditImageBodyJsonParamModel.GptImage1,
                "gpt-image-1-mini" => EditImageBodyJsonParamModel.GptImage1Mini,
                "gpt-image-1.5" => EditImageBodyJsonParamModel.GptImage15,
                "gpt-image-2" => EditImageBodyJsonParamModel.GptImage2,
                "gpt-image-2-2026-04-21" => EditImageBodyJsonParamModel.GptImage220260421,
                "gpt-image-2.5-flare" => EditImageBodyJsonParamModel.GptImage25Flare,
                "gpt-image-2.5-flare-2026-09-08" => EditImageBodyJsonParamModel.GptImage25Flare20260908,
                "gpt-image-2.5-sunburst" => EditImageBodyJsonParamModel.GptImage25Sunburst,
                "gpt-image-2.5-sunburst-2026-09-08" => EditImageBodyJsonParamModel.GptImage25Sunburst20260908,
                _ => null,
            };
        }
    }
}