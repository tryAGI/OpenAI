
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The CPU and memory tier for a new OpenAI-hosted session environment.
    /// </summary>
    public enum ContainerSizeParam
    {
        /// <summary>
        ///
        /// </summary>
        Large,
        /// <summary>
        ///
        /// </summary>
        Medium,
        /// <summary>
        ///
        /// </summary>
        Small,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContainerSizeParamExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContainerSizeParam value)
        {
            return value switch
            {
                ContainerSizeParam.Large => "large",
                ContainerSizeParam.Medium => "medium",
                ContainerSizeParam.Small => "small",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContainerSizeParam? ToEnum(string value)
        {
            return value switch
            {
                "large" => ContainerSizeParam.Large,
                "medium" => ContainerSizeParam.Medium,
                "small" => ContainerSizeParam.Small,
                _ => null,
            };
        }
    }
}