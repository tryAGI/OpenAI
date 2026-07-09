
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Automatically creates a container for this request<br/>
    /// Default Value: container_auto
    /// </summary>
    public enum BetaContainerAutoParamType
    {
        /// <summary>
        /// 
        /// </summary>
        ContainerAuto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaContainerAutoParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaContainerAutoParamType value)
        {
            return value switch
            {
                BetaContainerAutoParamType.ContainerAuto => "container_auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaContainerAutoParamType? ToEnum(string value)
        {
            return value switch
            {
                "container_auto" => BetaContainerAutoParamType.ContainerAuto,
                _ => null,
            };
        }
    }
}