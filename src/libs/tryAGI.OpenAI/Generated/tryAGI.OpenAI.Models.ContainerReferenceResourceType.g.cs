
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The environment type. Always `container_reference`.<br/>
    /// Default Value: container_reference
    /// </summary>
    public enum ContainerReferenceResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        ContainerReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContainerReferenceResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContainerReferenceResourceType value)
        {
            return value switch
            {
                ContainerReferenceResourceType.ContainerReference => "container_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContainerReferenceResourceType? ToEnum(string value)
        {
            return value switch
            {
                "container_reference" => ContainerReferenceResourceType.ContainerReference,
                _ => null,
            };
        }
    }
}