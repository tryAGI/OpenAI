
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The citation type. Always `container_file_citation`.<br/>
    /// Default Value: container_file_citation
    /// </summary>
    public enum BetaContainerFileCitationParamType
    {
        /// <summary>
        /// 
        /// </summary>
        ContainerFileCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaContainerFileCitationParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaContainerFileCitationParamType value)
        {
            return value switch
            {
                BetaContainerFileCitationParamType.ContainerFileCitation => "container_file_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaContainerFileCitationParamType? ToEnum(string value)
        {
            return value switch
            {
                "container_file_citation" => BetaContainerFileCitationParamType.ContainerFileCitation,
                _ => null,
            };
        }
    }
}