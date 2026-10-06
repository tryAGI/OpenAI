
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveContainerMemoryLimit
    {
        /// <summary>
        ///
        /// </summary>
        x16g,
        /// <summary>
        ///
        /// </summary>
        x1g,
        /// <summary>
        ///
        /// </summary>
        x4g,
        /// <summary>
        ///
        /// </summary>
        x64g,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveContainerMemoryLimitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveContainerMemoryLimit value)
        {
            return value switch
            {
                LiveContainerMemoryLimit.x16g => "16g",
                LiveContainerMemoryLimit.x1g => "1g",
                LiveContainerMemoryLimit.x4g => "4g",
                LiveContainerMemoryLimit.x64g => "64g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveContainerMemoryLimit? ToEnum(string value)
        {
            return value switch
            {
                "16g" => LiveContainerMemoryLimit.x16g,
                "1g" => LiveContainerMemoryLimit.x1g,
                "4g" => LiveContainerMemoryLimit.x4g,
                "64g" => LiveContainerMemoryLimit.x64g,
                _ => null,
            };
        }
    }
}