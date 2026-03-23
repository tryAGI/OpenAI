
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The memory limit configured for the container.
    /// </summary>
    public enum ContainerResourceMemoryLimit
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
    public static class ContainerResourceMemoryLimitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContainerResourceMemoryLimit value)
        {
            return value switch
            {
                ContainerResourceMemoryLimit.x16g => "16g",
                ContainerResourceMemoryLimit.x1g => "1g",
                ContainerResourceMemoryLimit.x4g => "4g",
                ContainerResourceMemoryLimit.x64g => "64g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContainerResourceMemoryLimit? ToEnum(string value)
        {
            return value switch
            {
                "16g" => ContainerResourceMemoryLimit.x16g,
                "1g" => ContainerResourceMemoryLimit.x1g,
                "4g" => ContainerResourceMemoryLimit.x4g,
                "64g" => ContainerResourceMemoryLimit.x64g,
                _ => null,
            };
        }
    }
}