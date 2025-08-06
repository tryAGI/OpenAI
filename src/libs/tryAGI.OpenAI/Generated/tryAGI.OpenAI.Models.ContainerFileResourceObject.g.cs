
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of this object (`container.file`).
    /// </summary>
    public enum ContainerFileResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        ContainerFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContainerFileResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContainerFileResourceObject value)
        {
            return value switch
            {
                ContainerFileResourceObject.ContainerFile => "container.file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContainerFileResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "container.file" => ContainerFileResourceObject.ContainerFile,
                _ => null,
            };
        }
    }
}