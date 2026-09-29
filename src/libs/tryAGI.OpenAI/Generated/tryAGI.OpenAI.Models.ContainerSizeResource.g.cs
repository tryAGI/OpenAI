
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The effective CPU and memory tier of an OpenAI-hosted environment.
    /// </summary>
    public enum ContainerSizeResource
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
    public static class ContainerSizeResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContainerSizeResource value)
        {
            return value switch
            {
                ContainerSizeResource.Large => "large",
                ContainerSizeResource.Medium => "medium",
                ContainerSizeResource.Small => "small",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContainerSizeResource? ToEnum(string value)
        {
            return value switch
            {
                "large" => ContainerSizeResource.Large,
                "medium" => ContainerSizeResource.Medium,
                "small" => ContainerSizeResource.Small,
                _ => null,
            };
        }
    }
}