
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// References a container created with the /v1/containers endpoint<br/>
    /// Default Value: container_reference
    /// </summary>
    public enum LiveContainerReferenceParamType
    {
        /// <summary>
        ///
        /// </summary>
        ContainerReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveContainerReferenceParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveContainerReferenceParamType value)
        {
            return value switch
            {
                LiveContainerReferenceParamType.ContainerReference => "container_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveContainerReferenceParamType? ToEnum(string value)
        {
            return value switch
            {
                "container_reference" => LiveContainerReferenceParamType.ContainerReference,
                _ => null,
            };
        }
    }
}