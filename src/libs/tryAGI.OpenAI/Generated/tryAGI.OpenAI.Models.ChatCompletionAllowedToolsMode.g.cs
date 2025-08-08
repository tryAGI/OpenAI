
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Constrains the tools available to the model to a pre-defined set.<br/>
    /// `auto` allows the model to pick from among the allowed tools and generate a<br/>
    /// message.<br/>
    /// `required` requires the model to call one or more of the allowed tools.
    /// </summary>
    public enum ChatCompletionAllowedToolsMode
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionAllowedToolsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionAllowedToolsMode value)
        {
            return value switch
            {
                ChatCompletionAllowedToolsMode.Auto => "auto",
                ChatCompletionAllowedToolsMode.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionAllowedToolsMode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ChatCompletionAllowedToolsMode.Auto,
                "required" => ChatCompletionAllowedToolsMode.Required,
                _ => null,
            };
        }
    }
}