
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The citation type. Always `container_file_citation`.<br/>
    /// Default Value: container_file_citation
    /// </summary>
    public enum ContainerFileCitationParamType
    {
        /// <summary>
        /// 
        /// </summary>
        ContainerFileCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContainerFileCitationParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContainerFileCitationParamType value)
        {
            return value switch
            {
                ContainerFileCitationParamType.ContainerFileCitation => "container_file_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContainerFileCitationParamType? ToEnum(string value)
        {
            return value switch
            {
                "container_file_citation" => ContainerFileCitationParamType.ContainerFileCitation,
                _ => null,
            };
        }
    }
}