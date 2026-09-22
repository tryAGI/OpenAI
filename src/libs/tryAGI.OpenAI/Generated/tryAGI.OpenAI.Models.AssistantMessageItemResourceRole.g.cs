
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The role of the message author. Always `assistant`.<br/>
    /// Default Value: assistant
    /// </summary>
    public enum AssistantMessageItemResourceRole
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantMessageItemResourceRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantMessageItemResourceRole value)
        {
            return value switch
            {
                AssistantMessageItemResourceRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantMessageItemResourceRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AssistantMessageItemResourceRole.Assistant,
                _ => null,
            };
        }
    }
}