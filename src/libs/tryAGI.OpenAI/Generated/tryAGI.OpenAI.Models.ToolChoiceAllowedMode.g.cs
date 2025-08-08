
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Constrains the tools available to the model to a pre-defined set.<br/>
    /// `auto` allows the model to pick from among the allowed tools and generate a<br/>
    /// message.<br/>
    /// `required` requires the model to call one or more of the allowed tools.
    /// </summary>
    public enum ToolChoiceAllowedMode
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
    public static class ToolChoiceAllowedModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolChoiceAllowedMode value)
        {
            return value switch
            {
                ToolChoiceAllowedMode.Auto => "auto",
                ToolChoiceAllowedMode.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolChoiceAllowedMode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ToolChoiceAllowedMode.Auto,
                "required" => ToolChoiceAllowedMode.Required,
                _ => null,
            };
        }
    }
}