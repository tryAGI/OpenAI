
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the container file citation. Always `container_file_citation`.<br/>
    /// Default Value: container_file_citation
    /// </summary>
    public enum BetaContainerFileCitationBodyType
    {
        /// <summary>
        /// 
        /// </summary>
        ContainerFileCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaContainerFileCitationBodyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaContainerFileCitationBodyType value)
        {
            return value switch
            {
                BetaContainerFileCitationBodyType.ContainerFileCitation => "container_file_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaContainerFileCitationBodyType? ToEnum(string value)
        {
            return value switch
            {
                "container_file_citation" => BetaContainerFileCitationBodyType.ContainerFileCitation,
                _ => null,
            };
        }
    }
}