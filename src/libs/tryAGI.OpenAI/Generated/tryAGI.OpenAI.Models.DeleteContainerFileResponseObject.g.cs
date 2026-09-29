
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum DeleteContainerFileResponseObject
    {
        /// <summary>
        ///
        /// </summary>
        ContainerFileDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteContainerFileResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteContainerFileResponseObject value)
        {
            return value switch
            {
                DeleteContainerFileResponseObject.ContainerFileDeleted => "container.file.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteContainerFileResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "container.file.deleted" => DeleteContainerFileResponseObject.ContainerFileDeleted,
                _ => null,
            };
        }
    }
}