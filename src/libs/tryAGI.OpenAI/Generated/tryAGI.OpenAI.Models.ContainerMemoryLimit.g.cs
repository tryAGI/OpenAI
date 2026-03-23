
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContainerMemoryLimit
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
    public static class ContainerMemoryLimitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContainerMemoryLimit value)
        {
            return value switch
            {
                ContainerMemoryLimit.x16g => "16g",
                ContainerMemoryLimit.x1g => "1g",
                ContainerMemoryLimit.x4g => "4g",
                ContainerMemoryLimit.x64g => "64g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContainerMemoryLimit? ToEnum(string value)
        {
            return value switch
            {
                "16g" => ContainerMemoryLimit.x16g,
                "1g" => ContainerMemoryLimit.x1g,
                "4g" => ContainerMemoryLimit.x4g,
                "64g" => ContainerMemoryLimit.x64g,
                _ => null,
            };
        }
    }
}