
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveInitialItemDiscriminatorRole
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
        /// <summary>
        ///
        /// </summary>
        Developer,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveInitialItemDiscriminatorRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveInitialItemDiscriminatorRole value)
        {
            return value switch
            {
                LiveInitialItemDiscriminatorRole.Assistant => "assistant",
                LiveInitialItemDiscriminatorRole.Developer => "developer",
                LiveInitialItemDiscriminatorRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveInitialItemDiscriminatorRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => LiveInitialItemDiscriminatorRole.Assistant,
                "developer" => LiveInitialItemDiscriminatorRole.Developer,
                "user" => LiveInitialItemDiscriminatorRole.User,
                _ => null,
            };
        }
    }
}