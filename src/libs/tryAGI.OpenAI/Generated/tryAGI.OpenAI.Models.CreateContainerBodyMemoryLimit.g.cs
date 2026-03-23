
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Optional memory limit for the container. Defaults to "1g".
    /// </summary>
    public enum CreateContainerBodyMemoryLimit
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
    public static class CreateContainerBodyMemoryLimitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateContainerBodyMemoryLimit value)
        {
            return value switch
            {
                CreateContainerBodyMemoryLimit.x16g => "16g",
                CreateContainerBodyMemoryLimit.x1g => "1g",
                CreateContainerBodyMemoryLimit.x4g => "4g",
                CreateContainerBodyMemoryLimit.x64g => "64g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateContainerBodyMemoryLimit? ToEnum(string value)
        {
            return value switch
            {
                "16g" => CreateContainerBodyMemoryLimit.x16g,
                "1g" => CreateContainerBodyMemoryLimit.x1g,
                "4g" => CreateContainerBodyMemoryLimit.x4g,
                "64g" => CreateContainerBodyMemoryLimit.x64g,
                _ => null,
            };
        }
    }
}