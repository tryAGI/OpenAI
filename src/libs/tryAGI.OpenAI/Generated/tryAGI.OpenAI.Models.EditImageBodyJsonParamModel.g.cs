
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
                _ => null,
            };
        }
    }
}