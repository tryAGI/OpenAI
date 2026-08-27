
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaContainerMemoryLimit
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
    public static class BetaContainerMemoryLimitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaContainerMemoryLimit value)
        {
            return value switch
            {
                BetaContainerMemoryLimit.x16g => "16g",
                BetaContainerMemoryLimit.x1g => "1g",
                BetaContainerMemoryLimit.x4g => "4g",
                BetaContainerMemoryLimit.x64g => "64g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaContainerMemoryLimit? ToEnum(string value)
        {
            return value switch
            {
                "16g" => BetaContainerMemoryLimit.x16g,
                "1g" => BetaContainerMemoryLimit.x1g,
                "4g" => BetaContainerMemoryLimit.x4g,
                "64g" => BetaContainerMemoryLimit.x64g,
                _ => null,
            };
        }
    }
}